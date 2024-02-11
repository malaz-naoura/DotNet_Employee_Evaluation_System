using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace employee_evaluation_system
{
    public partial class show_employee : Form
    {
        public show_employee()
        {
            InitializeComponent();
            set_listview();
        }

        private void show_employee_Load(object sender, EventArgs e)
        {
            teams.Items.Clear();
            foreach (Team i in Form1.Myteam)
                teams.Items.Add(i.Name);
        }
        public void set_listview()
        {
            listview_evaluation.View = View.Details;
            listview_evaluation.Columns.Add("Name");
            listview_evaluation.Columns.Add("Rate");
            listview_evaluation.Columns.Add("Descreptoin");

        }
        private void teams_SelectedIndexChanged(object sender, EventArgs e)
        {
            employees.Items.Clear();
            employee_info.Items.Clear();
            skill.Items.Clear();
            rate.Clear();
            review.Clear();
            int index = teams.SelectedIndex;
            if (index == -1)
                return;
            foreach (Employee i in Form1.Myteam.ElementAt(index).Employees)
            {
                employees.Items.Add(i.Name);
            }
            listview_evaluation.Items.Clear();
        }

        private void employees_SelectedIndexChanged(object sender, EventArgs e)
        {
            employee_info.Items.Clear();
            skill.Items.Clear();
            rate.Clear();
            review.Clear();

            int index_team = teams.SelectedIndex;
            int index_employee = employees.SelectedIndex;
            if (index_employee == -1)
                return;
            string s = "Name : " + Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Name +
                      "\nAge : " + Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Age +
                      "\nSalary : " + Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Salary +
                      "\nPosition : " + Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Job_Name.Name +
                      "\nGrade : " + Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Job_Name.P.Letter_Grade +
                      "\nHis Manager : " + Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Manager;
            employee_info.Items.AddRange(s.Split('\n'));
            foreach (skill_employee i in Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Skill_Employee)
                skill.Items.Add(i.Name);
            listview_evaluation.Items.Clear();
        }

        private void skill_SelectedIndexChanged(object sender, EventArgs e)
        {
            listview_evaluation.Items.Clear();
            int index_team = teams.SelectedIndex;
            int index_employee = employees.SelectedIndex;
            int index_skill = skill.SelectedIndex;
            if (index_skill == -1)
                return;
            //MessageBox.Show(index_skill.ToString());
            string skill_name = Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Skill_Employee.ElementAt(index_skill).Name;
            double avg = 0;
            foreach (Evaluate_skill i in Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Skill_Employee.ElementAt(index_skill).Evaluate_Skill)
            {
                avg += i.Rate;
                ListViewItem lvi = new ListViewItem();
                lvi.Text = skill_name + "  ";
                lvi.SubItems.Add(i.Rate.ToString() + "  ");
                lvi.SubItems.Add(i.Notes);
                listview_evaluation.Items.Add(lvi);
                listview_evaluation.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            }
            avg /= listview_evaluation.Items.Count;

            if (avg == 100)
                rate_percentage.Mask = "000 %";
            rate_percentage.Text = Convert.ToString(Convert.ToInt16(avg));
            rate.Enabled = true;
            review.Enabled = true;
            evaluate.Enabled = true;
        }


        private void evaluate_Click(object sender, EventArgs e)
        {
            Regex detect_of_rate = new Regex("^\\d{1,3}$");
            Regex detect_of_name = new Regex("^[a-zA-Z]+((\\s)?[a-zA-Z]+)*$");
            ep.Clear();
            if (!detect_of_rate.IsMatch(rate.Text.Trim()))
            {
                ep.SetError(rate, "Please Enter A Correct Rate");
                return;
            }
            if (int.Parse(rate.Text.Trim()) > 100)
            {
                ep.SetError(rate, "Please Enter Rate Between 0 To 100");
                return;
            }
            if (!detect_of_name.IsMatch(review.Text.Trim()))
            {
                ep.SetError(review, "Please Enter A Correct Text Agrees This Form :String(Space + String)* ");
                return;
            }
            int index_team = teams.SelectedIndex;
            int index_employee = employees.SelectedIndex;
            int index_skill = skill.SelectedIndex;
            if (index_skill == -1)
                return;
            Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Skill_Employee.ElementAt(index_skill).Evaluate_Skill.Add(new Evaluate_skill(double.Parse(rate.Text), review.Text));

            rate.Clear();
            review.Clear();
            rate_percentage.Clear();
            skill.ClearSelected();
            if (listview_evaluation.Items.Count != 0)
                show_eevaluate_Click(sender, e);
            rate.Enabled = false;
            review.Enabled = false;
            evaluate.Enabled = false;
        }

        private void show_eevaluate_Click(object sender, EventArgs e)
        {
            ep.Clear();
            listview_evaluation.Items.Clear();
            int index_team = teams.SelectedIndex;
            int index_employee = employees.SelectedIndex;
            if (index_employee == -1)
            {
                ep.SetError(show_evaluate, "Please Select An Employee");
                return;
            }
            foreach (skill_employee i in Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Skill_Employee)
            {
                foreach (Evaluate_skill j in i.Evaluate_Skill)
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = i.Name + "  ";
                    lvi.SubItems.Add(j.Rate.ToString() + "  ");
                    lvi.SubItems.Add(j.Notes);
                    listview_evaluation.Items.Add(lvi);
                    listview_evaluation.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
                }
            }

            double average = 0;
            double temp = 0;
            int weight = 0;
            int count_weight = 0;
            foreach (skill_employee i in Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Skill_Employee)
            {
                temp = 0;
                foreach (Skill s in Form1.Myskill)
                    if (s.Name == i.Name)
                        weight = s.Weight;
              //  MessageBox.Show(weight.ToString());

                foreach (Evaluate_skill k in i.Evaluate_Skill)
                    temp += k.Rate;

                //MessageBox.Show(temp.ToString());

                temp /= i.Evaluate_Skill.Count();
                //MessageBox.Show(temp.ToString());
                temp *= weight;

                count_weight += weight;
                //MessageBox.Show(count_weight.ToString());
                average += temp;
                //MessageBox.Show(average.ToString());

            }

            //MessageBox.Show(average.ToString());
            //MessageBox.Show(count_weight.ToString());
           
            average /= count_weight;
            if (average == 100)
                rate_percentage.Mask = "000 %";
            rate_percentage.Text = Convert.ToString(Convert.ToInt16(average));
        }

        private void show_employee_FormClosed(object sender, FormClosedEventArgs e)
        {

            this.Dispose();

            //foreach (Control c in this.Controls)
            //    Utilities.ResetAllControls(c);
        }
    }


    //This code below is a copy of the Internet
    public class Utilities
    {
        public static void ResetAllControls(Control form)
        {
            foreach (Control control in form.Controls)
            {
                RecursiveResetForm(control);
            }
        }

        static private void RecursiveResetForm(Control control)
        {
            if (control.HasChildren)
            {
                foreach (Control subControl in control.Controls)
                {
                    RecursiveResetForm(subControl);
                }
            }
            switch (control.GetType().Name)
            {
                case "TextBox":
                    TextBox textBox = (TextBox)control;
                    textBox.Text = null;
                    break;

                case "ComboBox":
                    ComboBox comboBox = (ComboBox)control;
                    if (comboBox.Items.Count > 0)
                        comboBox.SelectedIndex = -1;
                    break;

                case "CheckBox":
                    CheckBox checkBox = (CheckBox)control;
                    checkBox.Checked = false;
                    break;

                case "ListBox":
                    ListBox listBox = (ListBox)control;
                    listBox.ClearSelected();
                    break;
            }
        }
    }
}

