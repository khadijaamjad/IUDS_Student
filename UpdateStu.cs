using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DBMStask
{
    public partial class UpdateStu : Form
    {
        SqlConnection con = new SqlConnection("Data Source=HAIER-PC\\SQLEXPRESS;Initial Catalog=DBMStask;Integrated Security=True");

        public UpdateStu()
        {
            InitializeComponent();
            FDD.AddItem("FirstName");
            FDD.AddItem("LastName");
            FDD.AddItem("Gender");
            FDD.AddItem("Department");
            FDD.AddItem("Program");
            FDD.AddItem("Address");
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string si,ov, nv;
            si=FDD.selectedValue;
            ov = OTB.Text.ToString();
            nv = ntb.Text.ToString();
            con.Open();
            SqlCommand cmd = new SqlCommand("UPDATE STUDENT set " +si+ "='" + nv + "' WHERE " +si+ " ='" + ov+"'", con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 1)
                MessageBox.Show("Student(s) updated!");
            else
                MessageBox.Show("No record found!");
        }
    }
}
