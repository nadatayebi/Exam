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

    public partial class Form31 : Form
    {


        public static string idquestion= "";

        fstPage fr = new fstPage();
        DataAcs ac = new DataAcs();
        string query;
        DataSet ds;
        int qnum = 1;

        public Form31()
        {
            InitializeComponent();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            string x = fstPage.idexam;
                 query = "insert into questions(num_question,enonce,id_exam) values('" + textBox1.Text+ "', '" + textBox2.Text + "', '" + x+ "') ";
             ac.setData(query, "inserted");
         
        }

        private void qcm_Click(object sender, EventArgs e)
        {
            query = "select id_question from questions where num_question='" + textBox1.Text + "' and enonce='" + textBox2.Text + "'";
            DataSet st = new DataSet();
            st = ac.GetData(query);

            idquestion = st.Tables[0].Rows[0][0].ToString();
            Form2 fr = new Form2();
            fr.ShowDialog();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            Form5 fr = new Form5();
            fr.ShowDialog();
        }
    }
}
