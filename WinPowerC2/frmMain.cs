namespace WinPowerC2
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        #region Logs

        void fnLogOK(string szMsg)
        {
            richTextBox1.SelectionColor = Color.LimeGreen;
            richTextBox1.AppendText("[+] ");
            richTextBox1.SelectionColor = Color.White;
            richTextBox1.AppendText(szMsg);
        }
        void fnLogInfo(string szMsg)
        {
            richTextBox1.SelectionColor = Color.AliceBlue;
            richTextBox1.AppendText("[*] ");
            richTextBox1.SelectionColor = Color.White;
            richTextBox1.AppendText(szMsg);
        }
        void fnLogError(string szMsg)
        {
            richTextBox1.SelectionColor = Color.Red;
            richTextBox1.AppendText("[-] ");
            richTextBox1.SelectionColor = Color.White;
            richTextBox1.AppendText(szMsg);
        }
        void fnLogWarn(string szMsg)
        {
            richTextBox1.SelectionColor = Color.LightGoldenrodYellow;
            richTextBox1.AppendText("[!] ");
            richTextBox1.SelectionColor = Color.White;
            richTextBox1.AppendText(szMsg);
        }
        void fnLogClear(string szMsg)
        {
            richTextBox1.Clear();
        }

        #endregion
        #region Listener

        void fnListenerStart()
        {

        }
        void fnListenerStop()
        {

        }
        void fnListenerRestart()
        {

        }

        #endregion

        void fnSetup()
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            fnSetup();
        }

        //Listener
        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            frmListener f = new frmListener();

            f.ShowDialog();
        }
        //Start
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }
        //Restart
        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }
        //Stop
        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }
    }
}
