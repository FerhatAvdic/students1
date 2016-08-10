using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace student
{


    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<students> studentsList = new List<students>();

        private void button1_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab == tabPage1)
            {
                try
                {
                    studentsList.Add(new undergraduate() { Name = studentName.Text, Surname = studentSurname.Text, ProjectGrade = Int32.Parse(undergraduateGrade.Text) });
                }
                catch (System.IO.IOException)
                {
                    Console.WriteLine("Null value entered");
                }
                finally
                {
                    listBox1.Items.Add(studentName.Text + " " + studentSurname.Text + " " + undergraduateGrade.Text);
                }
               
            }
                
            else if (tabControl1.SelectedTab == tabPage2)
            {
                studentsList.Add(new master() { Name = studentName.Text, Surname = studentSurname.Text, MasterWorkType = masterWorkType.Text, MasterWorkGrade = Int32.Parse(masterWorkGrade.Text) });
                listBox1.Items.Add(studentName.Text + " " + studentSurname.Text + " " + masterWorkType.Text + ": " + masterWorkGrade.Text);
            }
                
            else if (tabControl1.SelectedTab == tabPage3)
            {
                studentsList.Add(new pHd() { Name = studentName.Text, Surname = studentSurname.Text, DissertationGrade = Int32.Parse(pHdGrade.Text) });
                listBox1.Items.Add(studentName.Text + " " + studentSurname.Text + " " + pHdGrade.Text);
            }
                
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
