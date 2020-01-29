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
    public partial class SaveStu : Form
    {
        SqlConnection con = new SqlConnection("Data Source=HAIER-PC\\SQLEXPRESS;Initial Catalog=DBMStask;Integrated Security=True");
        public SaveStu()
        {
            InitializeComponent();
            genderdd.AddItem("Male");
            genderdd.AddItem("Female");
            depdd.AddItem("SE");
            depdd.AddItem("CS");
            depdd.AddItem("IT");
            depdd.AddItem("MEDIA");
            depdd.AddItem("GEOLOGY");
            programdd.AddItem("MASTERS");
            programdd.AddItem("BACHELORS");
            programdd.AddItem("PHD");
            programdd.AddItem("M.PHIL");
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string sid, sfn, sln, sg, sp,sadd, sd, sdob;
            sid = IDTB.Text.ToString();
            sfn = FNTB.Text.ToString();
            sln = LNTB.Text.ToString();
            sg = genderdd.selectedValue;
            sadd = ATB.Text.ToString();
            sp = programdd.selectedValue;
            sd = depdd.selectedValue;
            sdob = DOBP.Value.ToString();
            con.Open();
            SqlCommand cmd = new SqlCommand("Insert Into Student(StudentID,FirstName,LastName,Gender,DOB,Address,Department,Program) values ('"+sid+"','" + sfn + "','" + sln + "','" + sg + "','" + sdob + "','" + sadd + "','" + sd + "','" + sp + "')", con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            if (i == 1)
                MessageBox.Show("Value added!");
            else
                MessageBox.Show("Error!");
            
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
