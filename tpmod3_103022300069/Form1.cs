namespace tpmod3_103022300069
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "Halo, " + formNama.Text;
        }
    }
}
