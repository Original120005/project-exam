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
    public partial class Form1 : Form
    {
        ListViewItem item;

        public Form1()
        {
            InitializeComponent();

            comboBox1.Items.Add("Day");
            comboBox1.Items.Add("Weekend");
            comboBox1.Items.Add("Month");
            comboBox1.SelectedItem = comboBox1.Items[0];
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;

            item = listView1.Items.Add("01.01.2023");
            item.SubItems.Add("12:00");
            item.SubItems.Add("Hight");
            item.SubItems.Add("Tag");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            object selected = comboBox1.SelectedItem;
            string str_selected = selected.ToString();
            switch (str_selected)
            {

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        public string ReceiveDate
        {
            get { return listView1.Items.ToString(); }
            set { item = listView1.Items.Add(value); }
        }
        
         public string ReceivePriority
        {
            get { return listView1.Items.ToString(); }
            set { item.SubItems.Add(value); }
        }

        public string ReceiveTag
        {
            get { return listView1.Items.ToString(); }
            set { item.SubItems.Add(value); }
        }

        public string ReceiveTime
        {
            get { return listView1.Items.ToString(); }
            set { item.SubItems.Add(value); }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            AddCase addCase = new AddCase();
            addCase.Owner = this;
            addCase.ShowDialog();

        }

    }
}
