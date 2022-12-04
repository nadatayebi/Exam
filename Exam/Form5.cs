using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Exam.classes;

namespace Exam
{
    public partial class Form5 : Form
    {
        string query;
        DataAcs ac = new DataAcs();
        
        public Form5()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string idq =Form31.idquestion;
            query = "insert into openQ values('','" + idq + "','" + textBox1.Text + "')";
            ac.setData(query, "insrted");


        }
    }
}
