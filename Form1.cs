using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBMStask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Optiondd.AddItem("Insert");
            Optiondd.AddItem("Update");
            Optiondd.AddItem("Search");
            Optiondd.AddItem("Delete");
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string option = Optiondd.selectedValue;
            if (option == "Insert")
            {
                SaveStu ae = new SaveStu();
                ae.Show();
            }
            else if (option == "Update")
            {
                UpdateStu ue = new UpdateStu();
                ue.Show();
            }
            else if (option == "Delete")
            {
                DeleteStu de = new DeleteStu();
                de.Show();
            }
            else if (option == "Search")
            {
                SearchStu se = new SearchStu();
                se.Show();
            }
            
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            StudentData sd = new StudentData();
            sd.Show();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
