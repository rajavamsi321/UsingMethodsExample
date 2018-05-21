using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingMethodsExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStdt1_Click(object sender, EventArgs e)
        {
            int s1sub1, s1sub2, s1sub3;
           
            
           
            lstBoxOutputS1.Items.Clear();
            
            if (int.TryParse(tBSub1S1.Text, out s1sub1) && 
                int.TryParse(tBSub2S1.Text, out s1sub2) &&
                int.TryParse(tBSub3S1.Text, out s1sub3))
            {
                lstBoxOutputS1.Items.Add("Scored Max\t" + CalcMaxValue(s1sub1,s1sub2,s1sub3));
                lstBoxOutputS1.Items.Add("Scored Min\t" + CalcMinValue(s1sub1, s1sub2, s1sub3));
                lstBoxOutputS1.Items.Add("Total\t\t" + CalTotal(s1sub1, s1sub2, s1sub3));
                lstBoxOutputS1.Items.Add("Average\t\t" + CalAverage(s1sub1, s1sub2, s1sub3));
                lstBoxOutputS1.Items.Add("Result\t\t" + CalGrade(s1sub1, s1sub2, s1sub3));


            }
            else
            {
                MessageBox.Show("Enter Valid Input", "Invalid Input");
            }
           
        }

        int CalcMaxValue(int a1, int a2, int a3)
        {
            if ((a1 > a2) && (a1 > a3))
            {
                return a1;
            }
            else if ((a2 > a3) && (a2 > a3))
            {
                return a2;
            }
            else
            {
                return a3;
            }
        }
        int CalcMinValue(int a1, int a2, int a3)
        {
            if ((a1 < a2) && (a1 < a3))
            {
                return a1;
            }
            else if ((a2 < a3) && (a2 < a3))
            {
                return a2;
            }
            else
            {
                return a3;
            }

        }
        int CalTotal(int a1, int a2, int a3)
        {
            int total;
            total = a1 + a2 + a3;
            return total;
        }
        int CalAverage(int a1, int a2, int a3)
        {
            int avg;
            avg = CalTotal(a1, a2, a3) / 3;
            return avg;
        }
        string CalGrade(int a1, int a2, int a3)
        {
            int average;
            average = CalAverage(a1, a2, a3);
            if (average > 60 && average < 75)
            {
                return "GRADE C";
            }
            else if (average > 75 && average < 90)
            {
                return "GRADE B";
            }
            else if (average > 90)
            {
                return "GRADE A";
            }
            else
            {
                return "GRADE D";
            }
        }

        private void btnStdt2_Click(object sender, EventArgs e)
        {
            int s2sub1, s2sub2, s2sub3;
            lstBoxOutputS2.Items.Clear();
            if (int.TryParse(tBoxSub1S2.Text, out s2sub1) &&
                int.TryParse(tBoxSub2S2.Text, out s2sub2) &&
                int.TryParse(tBoxSub3S2.Text, out s2sub3))
            {
                lstBoxOutputS2.Items.Add("Scored Max\t" + CalcMaxValue(s2sub1, s2sub2, s2sub3));
                lstBoxOutputS2.Items.Add("Scored Min\t" + CalcMinValue(s2sub1, s2sub2, s2sub3));
                lstBoxOutputS2.Items.Add("Total\t\t" + CalTotal(s2sub1, s2sub2, s2sub3));
                lstBoxOutputS2.Items.Add("Average\t\t" + CalAverage(s2sub1, s2sub2, s2sub3));
                lstBoxOutputS2.Items.Add("Result\t\t" + CalGrade(s2sub1, s2sub2, s2sub3));


            }
            else
            {
                MessageBox.Show("Enter Valid Input", "Invalid Input");
            }
        }
    }
}
