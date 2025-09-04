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
        long slow()
        {
            long sum = 0;
            for (long i = 0; i < 999999999; i++)
            {
                sum += i;
            }
            return sum;
        }
        //sync Code
        //private void button2_Click(object sender, EventArgs e)
        //{
        //    label1.Text = slow().ToString();
        //}

        //async Code
        private async void button2_Click(object sender, EventArgs e)

        {
            Task<long> task =new Task<long>(slow);
            task.Start();
            long res= await task;
            label1.Text=res.ToString();
        }
    }
}
