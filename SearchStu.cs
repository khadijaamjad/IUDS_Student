using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMStask
{
    public partial class SearchStu : Form
    {
        SqlConnection con = new SqlConnection("Data Source=HAIER-PC\\SQLEXPRESS;Initial Catalog=DBMStask;Integrated Security=True");
        public SearchStu()
        {
            InitializeComponent();
            searchdd.AddItem("StudentID");
            searchdd.AddItem("FirstName");
            searchdd.AddItem("LastName");
            searchdd.AddItem("Gender");
            searchdd.AddItem("Department");
            searchdd.AddItem("Program");
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string inp=searchdd.selectedValue;
            string info = itb.Text.ToString();
            con.Open();
            SqlCommand cmd = new SqlCommand("SELECT * FROM STUDENT WHERE "+inp+" ='"+info+"'", con);
            int i = cmd.ExecuteNonQuery();
            if (i == 1)
                MessageBox.Show("Student(s) exists!");
            else
                MessageBox.Show("No record found!");
            con.Close();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
