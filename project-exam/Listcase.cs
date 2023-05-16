using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace exam_17._05
{
    public partial class AddCase : Form
    {

        static class Send
        {
            public static string Value { get; set; }
        }

        public AddCase()
        {
            InitializeComponent();

            comboBox1.Items.Add("Low");
            comboBox1.Items.Add("High");
            comboBox1.SelectedItem = comboBox1.Items[0];
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            textBox3.Text = dateTimePicker1.Value.ToLongDateString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox5.Text = textBox1.Text;
        }

        private void maskedTextBox1_Leave(object sender, EventArgs e)
        {
            textBox4.Text = maskedTextBox1.Text;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox6.Text = textBox2.Text;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string date = dateTimePicker1.Text;

            Form1 main = Owner as Form1;
            if (main != null)
            {
                main.ReceiveDate = date;
                main.ReceiveTime = maskedTextBox1.Text;
                main.ReceivePriority = comboBox1.SelectedItem.ToString();
                main.ReceiveTag = textBox1.Text;
            }

            Close();
        }
    }
}
