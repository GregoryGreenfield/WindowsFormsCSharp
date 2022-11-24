using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DebugLogsRunningForm
{
    public partial class DebugLogsRunning : Form
    {
        public DebugLogsRunning()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void Label1_Click(object sender, EventArgs e)
        {

        }
        private void Timer1_Tick(object sender, EventArgs e)
        {            
            // Set the Multiline property to true.
            txtBox.Multiline = true;
            // Add vertical scroll bars to the TextBox control.
            txtBox.AcceptsTab = true;
            // Set WordWrap to true to allow text to wrap to the next line.
            txtBox.WordWrap = true;
            // Set the default text of the control.
            txtBox.Text = "Welcome!" + Environment.NewLine + "Second Line";

            lblMessage.Text = DateTime.Now.ToString();

            string path_generator(string suite_number)
            {
                return "W:\\DebugLogs\\Suite " + suite_number + "\\Linac" + System.DateTime.Now.ToString("ddd") + "Log.txt";
            }

            DateTime LastWriteTime(string suite_number)
            {
                string this_path = path_generator(suite_number);
                return File.GetLastWriteTime(this_path);
            }

            void background_colour_green(string suite_number)
            {
                if (suite_number == "1")
                {
                    label1.BackColor = Color.MediumSeaGreen;
                }
                if (suite_number == "2")
                {
                    label2.BackColor = Color.MediumSeaGreen;
                }
                if (suite_number == "3")
                {
                    label3.BackColor = Color.MediumSeaGreen;
                }
                if (suite_number == "4")
                {
                    label4.BackColor = Color.MediumSeaGreen;
                }
                if (suite_number == "5")
                {
                    label5.BackColor = Color.MediumSeaGreen;
                }
                if (suite_number == "6")
                {
                    label6.BackColor = Color.MediumSeaGreen;
                }
                if (suite_number == "8")
                {
                    label8.BackColor = Color.MediumSeaGreen;
                }
                if (suite_number == "10")
                {
                    label10.BackColor = Color.MediumSeaGreen;
                }
                if (suite_number == "11")
                {
                    label11.BackColor = Color.MediumSeaGreen;
                }
                if (suite_number == "12")
                {
                    label12.BackColor = Color.MediumSeaGreen;
                }
            }

            void background_colour_red(string suite_number)
            {
                if (suite_number == "1")
                {
                    label1.BackColor = Color.Red;
                }
                if (suite_number == "2")
                {
                    label2.BackColor = Color.Red;
                }
                if (suite_number == "3")
                {
                    label3.BackColor = Color.Red;
                }
                if (suite_number == "4")
                {
                    label4.BackColor = Color.Red;
                }
                if (suite_number == "5")
                {
                    label5.BackColor = Color.Red;
                }
                if (suite_number == "6")
                {
                    label6.BackColor = Color.Red;
                }
                if (suite_number == "8")
                {
                    label8.BackColor = Color.Red;
                }
                if (suite_number == "10")
                {
                    label10.BackColor = Color.Red;
                }
                if (suite_number == "11")
                {
                    label11.BackColor = Color.Red;
                }
                if (suite_number == "12")
                {
                    label12.BackColor = Color.Red;
                }
            }
            
            string delta_change(string suite_number)
            {
                DateTime now_minus_six = DateTime.Now.Subtract(new TimeSpan(0, 25, 0));
                DateTime last_update = LastWriteTime(suite_number);
                int comparison = last_update.CompareTo(now_minus_six);
                if (comparison >= 1)
                {
                    background_colour_green(suite_number);
                    return last_update.ToString("T");
                    //return "Y";
                }
                else
                {
                    background_colour_red(suite_number);
                    return last_update.ToString("T");
                    //return "    N";
                }
            }

            void Update_all()
            {
                string Update_1 = delta_change("1");
                string Update_2 = delta_change("2");
                string Update_3 = delta_change("3");
                string Update_4 = delta_change("4");
                string Update_5 = delta_change("5");
                string Update_6 = delta_change("6");
                string Update_8 = delta_change("8");
                string Update_10 = delta_change("10");
                string Update_11 = delta_change("11");
                string Update_12 = delta_change("12");

                txtBox.Text = "Suite\tLast Updated" + Environment.NewLine + "S1\t" + Update_1 + Environment.NewLine + "S2\t" + Update_2 + Environment.NewLine + "S3\t" + Update_3 + Environment.NewLine + "S4\t" + Update_4 + Environment.NewLine + "S5\t" + Update_5 + Environment.NewLine + "S6\t" + Update_6 + Environment.NewLine + "S8\t" + Update_8 + Environment.NewLine + "S10\t" + Update_10 + Environment.NewLine + "S11\t" + Update_11 + Environment.NewLine + "S12\t" + Update_12;
            }
            Update_all();
        }
    }
}
