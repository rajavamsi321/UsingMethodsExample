using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

            int mjjhghjs = new int();
            
           
            lstBoxOutputS1.Items.Clear();
            
            if (int.TryParse(tBSub1S1.Text, out s1sub1) && 
                int.TryParse(tBSub2S1.Text, out s1sub2) &&
                int.TryParse(tBSub3S1.Text, out s1sub3))
            {
                Student s1 = new Student();
                s1.sub1 = s1sub1;
                s1.sub2 = s1sub2;
                s1.sub3 = s1sub3;

                

                lstBoxOutputS1.Items.Add("Scored Max\t" + CalcMaxValue(s1sub1,s1sub2,s1sub3));
                lstBoxOutputS1.Items.Add("Scored Min\t" + CalcMinValue(s1sub1, s1sub2, s1sub3));
                lstBoxOutputS1.Items.Add("Total\t\t" + CalTotal(s1sub1, s1sub2, s1sub3));
                lstBoxOutputS1.Items.Add("Average\t\t" + CalAverage(s1sub1, s1sub2, s1sub3));
                lstBoxOutputS1.Items.Add("Result\t\t" + CalGrade(s1sub1, s1sub2, s1sub3));

                int temp = s1.CalAverage();
                lstBoxOutputS1.Items.Add("Average: using class \t" + temp);
                lstBoxOutputS1.Items.Add("Total: using class \t\t" + s1.CalTotal());

                OutputWriteToFile otptWrite = new OutputWriteToFile();
                otptWrite.fileContent = "Score Min\t" + CalcMaxValue(s1sub1, s1sub2, s1sub3) + "\r\n" +
                                        "Scored Min\t" + CalcMinValue(s1sub1, s1sub2, s1sub3) + "\r\n" +
                                        "Total\t\t" + CalTotal(s1sub1, s1sub2, s1sub3) + "\r\n" +
                                        "Average\t\t" + CalAverage(s1sub1, s1sub2, s1sub3) + "\r\n" +
                                        "Result\t\t" + CalGrade(s1sub1, s1sub2, s1sub3)+"\r\n";
                otptWrite.filePath = @"C:/Users/pavan/Desktop/NewRandom/StudentDetails.txt";
                otptWrite.writeFile();




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
                Student s2 = new Student();
                s2.sub1 = s2sub1;
                s2.sub2 = s2sub2;
                s2.sub3 = s2sub3;
                lstBoxOutputS2.Items.Add("Scored Max\t" + CalcMaxValue(s2sub1, s2sub2, s2sub3));
                lstBoxOutputS2.Items.Add("Scored Min\t" + CalcMinValue(s2sub1, s2sub2, s2sub3));
                lstBoxOutputS2.Items.Add("Total\t\t" + CalTotal(s2sub1, s2sub2, s2sub3));
                lstBoxOutputS2.Items.Add("Average\t\t" + CalAverage(s2sub1, s2sub2, s2sub3));
                lstBoxOutputS2.Items.Add("Result\t\t" + CalGrade(s2sub1, s2sub2, s2sub3));
                int temp = s2.CalAverage();
                lstBoxOutputS2.Items.Add("Average: using class \t" + temp);
                lstBoxOutputS2.Items.Add("Total: using class \t\t" + s2.CalTotal());

                OutputWriteToFile otptWrite = new OutputWriteToFile();
                otptWrite.fileContent = "Score Min\t" + CalcMaxValue(s2sub1, s2sub2, s2sub3) + "\r\n" +
                                        "Scored Min\t" + CalcMinValue(s2sub1, s2sub2, s2sub3) + "\r\n" +
                                        "Total\t\t" + CalTotal(s2sub1, s2sub2, s2sub3) + "\r\n" +
                                        "Average\t\t" + CalAverage(s2sub1, s2sub2, s2sub3) + "\r\n" +
                                        "Result\t\t" + CalGrade(s2sub1, s2sub2, s2sub3);
                otptWrite.filePath = @"C:/Users/pavan/Desktop/NewRandom/StudentDetails.txt";
                otptWrite.writeFile();

            }
            else
            {
                MessageBox.Show("Enter Valid Input", "Invalid Input");
            }
        }

        private void btnDelLogs_Click(object sender, EventArgs e)
        {
            FileDeleteLogs fDelete = new FileDeleteLogs();
            fDelete.filePath = @"C:/Users/pavan/Desktop/NewRandom/StudentDetails.txt";
            fDelete.deleteLogs();
        }
    }


    public class Student
    {
        public int sub1;
        public int sub2;
        public int sub3;

        public int CalTotal()
        {
            int total;
            total = sub1 + sub2 + sub3;
            return total;
        }
        public int CalAverage()
        {
            int avg;
            avg = CalTotal() / 3;
            return avg;
        }
    }

    public class OutputWriteToFile
    {
        public string filePath;
        public string fileContent;
        public void writeFile()
        {
            StreamWriter writeToFile = File.AppendText(filePath);
            string a = fileContent;
            writeToFile.WriteLine(a);
            writeToFile.Close();
        }

    }

    public class FileDeleteLogs
    {
        public string filePath;
        public void deleteLogs()
        {
            File.Delete(filePath);
        }
    }
}
