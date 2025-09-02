namespace MyFormsGUIApp
{

    //these class can be implemeted in another file and linked using partial keyword
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello, KPMG!");
        }
    }
}
