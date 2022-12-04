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
    public partial class Form2 : Form
    {
        DataAcs ac = new DataAcs();
        string query;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSet_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            
            switch(x){
                case 2:
                    option1.Visible = true;
                    option2.Visible = true;
                    boxOp1.Visible = true;
                    boxOp2.Visible = true;
                    boxOp3.Text = null;
                    boxOp4.Text = null;
                    boxOp5.Text = null;
                    break;
                case 3:
                    option1.Visible = true;
                    option2.Visible = true;
                    boxOp1.Visible = true;
                    boxOp2.Visible = true;
                    option3.Visible = true;
                    boxOp3.Visible = true;
                    boxOp4.Text = null;
                    boxOp5.Text = null;
                    break;
                case 4:
                    option1.Visible = true;
                    option2.Visible = true;
                    boxOp1.Visible = true;
                    boxOp2.Visible = true;
                    option3.Visible = true;
                    boxOp3.Visible = true;
                    option4.Visible = true;
                    boxOp4.Visible = true;
                    boxOp5.Text = null;
                    break;
                case 5:
                    option1.Visible = true;
                    option2.Visible = true;
                    boxOp1.Visible = true;
                    boxOp2.Visible = true;
                    option3.Visible = true;
                    boxOp3.Visible = true;
                    option4.Visible = true;
                    boxOp4.Visible = true;
                    option5.Visible = true;
                    boxOp5.Visible = true;
                    break;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            option1.Visible = false;
            option2.Visible = false;
            option3.Visible = false;
            option4.Visible = false;
            option5.Visible = false;
            boxOp1.Visible = false;
            boxOp2.Visible = false;
            boxOp3.Visible = false;
            boxOp4.Visible = false;
            boxOp5.Visible = false;


        }

        private void btnAdd_Click(object sender, EventArgs e)
        { string iq = Form31.idquestion;
            int x = int.Parse(textBox1.Text);
            query = "insert into qcm values('','"+iq+ "','" + boxOp1 + "','" + boxOp2 + "','" + boxOp3 + "','" + boxOp4 + "','" + boxOp5 + "')";
            ac.setData(query, "inserted");
        }
    }
}
