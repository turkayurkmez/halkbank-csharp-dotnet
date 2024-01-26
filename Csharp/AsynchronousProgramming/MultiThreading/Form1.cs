namespace MultiThreading
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        Thread thread = null;
        private void buttonCounter_Click(object sender, EventArgs e)
        {

            thread = new Thread(new ThreadStart(count));
            thread.Start();

            thread.Join();
            MessageBox.Show("Sayım tamam!");


        }

        void count()
        {
            for (int i = 0; i <= 100000; i++)
            {
                labelCounter.Text = i.ToString();
                progressBar1.Value = i / 1000;
            }


        }

        private void buttonMesaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tıklandı");
        }
    }
}