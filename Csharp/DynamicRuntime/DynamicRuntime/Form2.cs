using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DynamicRuntime
{
    public partial class Form2 : Form, IFormBag
    {
        public Form2()
        {
            FormBag = new FormBag();
            InitializeComponent();
        }

        public dynamic FormBag { get; }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = FormBag.Title;
            BackColor = FormBag.Color;
            foreach (var item in FormBag.Elements)
            {
                listBox1.Items.Add(item);

            }
        }
    }
}
