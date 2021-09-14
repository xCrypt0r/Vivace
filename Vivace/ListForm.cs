using System;
using System.Windows.Forms;

namespace Vivace
{
    public partial class ListForm : Form
    {
        public ListBox LstMatched;
        public ListBox LstSkipped;
        public Label LblMatchedCount;
        public Label LblSkippedCount;
        public Label LblCorrectRate;

        public ListForm()
        {
            InitializeComponent();

            LstMatched = lstMatched;
            LstSkipped = lstSkipped;
            LblMatchedCount = lblMatchedCount;
            LblSkippedCount = lblSkippedCount;
            LblCorrectRate = lblCorrectRate;
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            this.Left = MainForm.FrmMain.Right;
            this.Top = MainForm.FrmMain.Top;
        }
    }
}
