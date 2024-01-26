namespace DynamicRuntime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        dynamic myValue = "Dinamik";

        private void Form1_Load(object sender, EventArgs e)
        {
            dynamic name = "halkbank";
            //MessageBox.Show(name.ToUpper());

            name = new Random();
            int randomNumber = name.Next(1, 11);
            //MessageBox.Show(randomNumber.ToString());

            name = 8;

            dynamic dynoItem = getJson(name);
            //MessageBox.Show(dynoItem.Info);
            //MessageBox.Show(dynoItem.Value.ToString());


        }

        dynamic getJson(dynamic parameter)
        {
            return new
            {
                Info = "Bu tip, anonimdir",
                Value = parameter,
            };


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.FormBag.Title = "Başlık....";
            form2.FormBag.Color = Color.Red;
            form2.FormBag.Elements = new string[] { "A", "B", "C" };

            form2.Show();

        }
    }
}