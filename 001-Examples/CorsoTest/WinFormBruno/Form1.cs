namespace WinFormBruno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSaluta_Click(object sender, EventArgs e)
        {
            MessageBox.Show(txtMessagio.Text);
        }
    }
}
