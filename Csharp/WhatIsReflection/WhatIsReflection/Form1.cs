using System.Reflection;

namespace WhatIsReflection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGetMembers_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;

            var members = typeof(DateTime).GetMembers().ToList().DistinctBy(m => m.Name);

            foreach (var item in members)
            {
                listBoxMembers.Items.Add(item.Name);
            }

            var type = dateTime.GetType();
            dynamic dateTimeOnRunTime = Activator.CreateInstance(type, 2024, 1, 26);
            var target = 0;

            // var day = (int)dateTimeOnRunTime.GetType().GetProperty("Day").GetValue(dateTimeOnRunTime);

            dynamic year = dateTimeOnRunTime.Year;

            MessageBox.Show(year.ToString());







        }
    }
}