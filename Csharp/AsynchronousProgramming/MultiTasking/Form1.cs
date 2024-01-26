namespace MultiTasking
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void buttonMesaj_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tıklandı");
        }

        private async void buttonCounter_Click(object sender, EventArgs e)
        {
            await Task.Run(counter);
            MessageBox.Show("Bitti");
        }

        private Task counter()
        {
            for (int i = 0; i < 50000; i++)
            {
                labelCounter.Text = i.ToString();
                progressBar1.Value = i / 500;
            }
            return Task.CompletedTask;
        }
    }
}