using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exam.classes;
using System.Data.SqlClient;
// Data Source = DESKTOP - RVGEFLO; Initial Catalog = examManager; Integrated Security = True


namespace Exam
{
    public partial class fstPage : Form
    {
        //attributes

        public static string idexam = "";
        public static string nomexam = "";
        DataAcs ac = new DataAcs();
        string query;
        
       


        public fstPage()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void fstPage_Load(object sender, EventArgs e)
        {
            query = "select * from Exam";
            SqlDataReader rd;
            rd = ac.getComboGrid(query);
            if (rd.HasRows)
            {

                this.dataGridView1.Rows.Clear();
                while (rd.Read())
                {
                    this.dataGridView1.Rows.Add(rd["id_exam"], rd["nom_exam"]);

                }
            }
        }
        
            private void rjButton3_Click(object sender, EventArgs e)
        {
            query = "insert into Exam(id_exam, nom_exam) values('" + textBox1.Text + "', '" + textBox2.Text + "')";
            ac.setData(query, "");

        }
      
      

        private void rjButton2_Click(object sender, EventArgs e)
        {
            idexam = textBox1.Text;
            Form31 fr = new Form31();
            fr.ShowDialog();
          
        }

        private void refresh_Click(object sender, EventArgs e)
        {
            query = "select * from Exam";
            SqlDataReader rd;
            rd = ac.getComboGrid(query);
            if (rd.HasRows)
            {

                this.dataGridView1.Rows.Clear();
                while (rd.Read())
                {
                    this.dataGridView1.Rows.Add(rd["id_exam"], rd["nom_exam"]);

                }
            }
            else
                MessageBox.Show("empty");




        
    }
    }
}
