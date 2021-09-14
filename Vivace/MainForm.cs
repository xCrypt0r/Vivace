using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vivace
{
    public partial class MainForm : Form
    {
        public static MainForm FrmMain;
        public static ListForm FrmList;
        public static WMPLib.WindowsMediaPlayer MusicPlayer = new WMPLib.WindowsMediaPlayer();
        public static string[] Musics;
        public static string[] Answer;
        public static string NowPlaying;
        public static string MainTitle;
        public static HashSet<string> Matched = new HashSet<string>();
        public static List<string> Skipped = new List<string>();
        public static CancellationTokenSource TokenSource;
        public static DateTime StartTime = DateTime.Now;

        public MainForm()
        {
            InitializeComponent();
            LoadMusics();

            FrmMain = this;
            FrmList = new ListForm();
            picCover.Left = (this.ClientSize.Width - picCover.Size.Width) / 2;

            FrmList.Show(this);

            tmrUptime.Interval = 1000;

            tmrUptime.Start();
        }

        public void LoadMusics()
        {
            var dialog = new CommonOpenFileDialog();

            dialog.IsFolderPicker = true;

            if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            {
                Musics = Directory
                    .GetFiles(dialog.FileName, "*.*", SearchOption.AllDirectories)
                    .Where
                    (
                        file => file.EndsWith(".mp3")
                                || file.EndsWith(".flac")
                                || file.EndsWith(".m4a")
                    )
                    .ToArray();

                PlayRandomMusic();
            }
        }

        public async void PlayRandomMusic()
        {
            var remainingMusics = Array.FindAll
            (
                Musics,
                name => !Matched.Contains(name) && !Skipped.Contains(name)
            );

            if (remainingMusics.Length < 1)
            {
                MessageBox.Show("게임이 종료되었습니다!");

                return;
            }

            var random = new Random();
            var fileName = remainingMusics[random.Next(0, remainingMusics.Length)];
            var music = TagLib.File.Create(fileName);
            var coverImage = music.Tag.Pictures.FirstOrDefault();
            var mStream = new MemoryStream();
            var highlight = double.Parse(music.Tag.FirstComposer ?? "0");

            Answer = music.Tag.Comment.Split(',');
            NowPlaying = fileName;
            MainTitle = music.Tag.Title;
            picCover.Image = null;
            lblCount.Text = (Matched.Count + Skipped.Count + 1) + " / " + Musics.Length;
            txtAnswer.Text = "";
            txtAnswer.Enabled = true;

            txtAnswer.Focus();
            HideAnswer();

            MusicPlayer.URL = fileName;
            MusicPlayer.settings.volume = 20;
            MusicPlayer.controls.currentPosition = highlight;

            MusicPlayer.controls.play();

            lblArtist.Text = music.Tag.FirstPerformer ?? "N/A";
            lblTitle.Text = Path.GetFileNameWithoutExtension(fileName);
            lblArtist.Left = (this.ClientSize.Width - lblArtist.Size.Width) / 2;
            lblTitle.Left = (this.ClientSize.Width - lblTitle.Size.Width) / 2;

            if (coverImage != null)
            {
                var pData = coverImage.Data.Data;

                mStream.Write(pData, 0, Convert.ToInt32(pData.Length));

                var bitmap = new Bitmap(mStream, false);

                mStream.Dispose();

                picCover.Image = bitmap;
            }

            TokenSource = new CancellationTokenSource();

            await AutoSkipAfterDelay(TokenSource.Token, 5000);
        }

        public async Task AutoSkipAfterDelay(CancellationToken token, int delay)
        {
            try
            {
                await Task.Delay(delay, token);

                SkipMusic();
                txtAnswer.Clear();
            }
            catch (OperationCanceledException) when (token.IsCancellationRequested)
            {
                return;
            }
        }

        private async void PlayNextMusic()
        {
            txtAnswer.Enabled = false;

            ShowAnswer();
            await Task.Delay(1000);
            PlayRandomMusic();
        }

        public void SkipMusic()
        {
            TokenSource.Cancel();
            FrmList.LstSkipped.Items.Add(MainTitle);
            Skipped.Add(NowPlaying);
            UpdateCorrectRate();

            FrmList.LblSkippedCount.Text = FrmList.LstSkipped.Items.Count.ToString();

            PlayNextMusic();
        }

        private void CheckAnswer()
        {
            if (Answer.Contains(txtAnswer.Text.ToUpper()))
            {
                TokenSource.Cancel();
                FrmList.LstMatched.Items.Add(MainTitle);
                Matched.Add(NowPlaying);
                UpdateCorrectRate();

                FrmList.LblMatchedCount.Text = Matched.Count.ToString();

                PlayNextMusic();
            }

            txtAnswer.Clear();
        }

        public void HideAnswer()
        {
            picCover.Visible = false;
            lblTitle.Visible = false;
            lblArtist.Visible = false;
        }

        public void ShowAnswer()
        {
            picCover.Visible = true;
            lblTitle.Visible = true;
            lblArtist.Visible = true;
        }

        public void UpdateCorrectRate()
        {
            var matchedCount = (double)Matched.Count;
            var skippedCount = (double)Skipped.Count;
            var correctRate = matchedCount / (matchedCount + skippedCount);
            var percentage = correctRate * 100;

            FrmList.LblCorrectRate.Text = "정답률: " + percentage.ToString("F2") + "%";
            FrmList.LstMatched.TopIndex = FrmList.LstMatched.Items.Count - 1;
            FrmList.LstSkipped.TopIndex = FrmList.LstSkipped.Items.Count - 1;
        }

        private void txtAnswer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckAnswer();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                (picCover.Visible ? (Action)HideAnswer : ShowAnswer)();
            }
            else if (e.KeyCode == Keys.End)
            {
                SkipMusic();
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Imports.ReleaseCapture();
                Imports.SendMessage(Handle, Imports.WM_NCLBUTTONDOWN, Imports.HT_CAPTION, 0);
            }
        }

        private void MainForm_LocationChanged(object sender, EventArgs e)
        {
            FrmList.Left = this.Right;
            FrmList.Top = this.Top;
        }

        private void tmrUptime_Tick(object sender, EventArgs e)
        {
            var elapsed = DateTime.Now - StartTime;

            lblUptime.Text = elapsed.ToString(@"hh\:mm\:ss");
        }
    }

    static class Imports
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(
            IntPtr hWnd,
            int Msg,
            int wParam,
            int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
    }
}
