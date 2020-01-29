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
    public partial class StudentData : Form
    {
        SqlConnection con = new SqlConnection("Data Source=HAIER-PC\\SQLEXPRESS;Initial Catalog=DBMStask;Integrated Security=True");

        public StudentData()
        {
            InitializeComponent();

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentData_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM STUDENT", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            dgv.DataSource = dt;
            con.Close();
        }
    }
}
