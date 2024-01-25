namespace EventMechanisms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ((Button)(sender)).BackColor = Color.Red;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {
            ProductService productService = new ProductService();
            Product product = new Product { Name = "Monitör", Price = 2500 };
            productService.Created += ProductService_Created;

            productService.Create(product);
        }

        private void ProductService_Created(object sender, ProductCreatedEventArgs e)
        {
            MessageBox.Show($"{e.User} kullanıcısı {e.Product.Name} isimli ürünü {e.CreatedDate} tarihinde ekledi");
        }
    }
}