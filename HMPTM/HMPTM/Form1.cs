using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HMPTM
{
    public partial class Form1 : Form
    {
        static string[] fillings =
            {"Pudding", "Water"};
        static string[] fildContainers =
            {"Taj Mahal",""};

        public Form1()
        {
            InitializeComponent();
            DropDownFiller.Items.AddRange(fillings);
            DropDownContainer.Items.AddRange(fildContainers);
            DropDownFiller.SelectedIndex = 0;
            DropDownContainer.SelectedIndex = 0;
            this.button1.Click += new EventHandler(button1_Click);
            
           
        }

        private void DropDownFiller_SelectedIndexChanged(object sender, EventArgs e)
        {
            object fillerSelected = DropDownFiller.SelectedItem;
            string fillerSelctstring = fillerSelected.ToString();
            

            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void DropDownContainer_SelectedIndexChanged(object sender, EventArgs e)
        {
            object ContainerSelected = DropDownContainer.SelectedItem;
            string fillerSelctstring = ContainerSelected.ToString();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calculate();
        }
        private void Calculate()
        {
            this.textBox2.Text = "The button was pushed!";
        }

        
    }
}
