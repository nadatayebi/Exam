using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace Exam.classes
{
    class DataAcs
    {
        //connection 

        protected SqlConnection getConnectioon()
        {
            SqlConnection cnx = new SqlConnection();
            cnx.ConnectionString = @"Data Source=DESKTOP-RVGEFLO; Initial Catalog = examManager; Integrated Security = True";
            return cnx;
        }

        //getData

        public DataSet GetData(string query)
        {
            SqlConnection cnx = getConnectioon();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            cmd.CommandText = query;
            //to execute it in the database and fill datatable
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataSet st = new DataSet();
            adapter.Fill(st);
            return st;

        }

        //setData 

        public void setData(string query, string msg)
        {
            SqlConnection cnx = getConnectioon();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            cnx.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            cnx.Close();
            MessageBox.Show(msg, "info", MessageBoxButtons.OK);

        }

        public void setData(string query)
        {
            SqlConnection cnx = getConnectioon();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            cnx.Open();
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            cnx.Close();


        }

        //getData for comobox and dataGrids

        public SqlDataReader getComboGrid(string query)
        {
            SqlConnection cnx = getConnectioon();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnx;
            cnx.Open();
            cmd = new SqlCommand(query, cnx);
            SqlDataReader sdr = cmd.ExecuteReader();
            return sdr;
        }
       
    }
}
