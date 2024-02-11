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

    public partial class add_employeescs : Form
    {

        public add_employeescs()
        {
            InitializeComponent();
        }
        private void add_employeescs_Load(object sender, EventArgs e)
        {
            show_skill.Items.Clear();
            check_team.Items.Clear();
            position.Items.Clear();
            manager.Items.Clear();
            foreach (Skill i in Form1.Myskill)
                show_skill.Items.Add(i.Name);
            foreach (Team i in Form1.Myteam)
                check_team.Items.Add(i.Name);
            foreach (Position i in Form1.Mypositions)
                position.Items.Add(i.Name);
            manager.Items.Add("Not Have A Manager");
            foreach (Employee i in Form1.Mymanagers)
                manager.Items.Add(i.Name);
        }

        //                                           **ADD EMPLOYEE**
        private void add_employee_Click(object sender, EventArgs e)
        {
            ep.Clear();
            if (finish_add.Enabled == true || add_to_team.Enabled == true)
            {
                ep.SetError(add_employee, "Please Finish Adding This Employee To Add Another");
                return;
            }
            Regex detect_from_name = new Regex("^[a-zA-Z]+((\\s)?[a-zA-Z]+)*$");
            Regex detect_from_salary = new Regex("^\\d+$");
            Regex detect_from_age = new Regex("^\\d{2}$");
            if (!detect_from_name.IsMatch(name.Text.Trim()))
            {
                ep.SetError(name, " Please Enter A Correct Name Agrees This Form: String(Space + String)*");
                return;
            }
            if (!detect_from_salary.IsMatch(salary.Text.Trim()))
            {
                ep.SetError(salary, "Please Enter A Correct Salary");
                return;
            }

            if (!detect_from_age.IsMatch(age.Text.Trim()))
            {
                ep.SetError(age, "Please Enter A Correct Age");
                return;
            }
            if (position.SelectedIndex == -1)
            {
                ep.SetError(position, "Please Select The Position");
                return;
            }
            if (grade.SelectedIndex == -1)
            {
                ep.SetError(grade, "Please Select The Grade");
                return;
            }

            double max = Form1.Mypositions.ElementAt(position.SelectedIndex).P.ElementAt(grade.SelectedIndex).Maximum_Salary;
            double min = Form1.Mypositions.ElementAt(position.SelectedIndex).P.ElementAt(grade.SelectedIndex).Minimum_Salary;
            if (double.Parse(salary.Text) > max || double.Parse(salary.Text) < min)
            {
                ep.SetError(salary, "Please Enter Value Applicable To Grading Salary Rules : Between (" + min + "," + max + ")");
                return;
            }


            Position_employee temp=null;
            string s = position.Text;
            string ma = manager.Text;
            if (manager.SelectedIndex == -1|| manager.SelectedIndex==0)
                ma = "Not Have A Manger";
            foreach (Position i in Form1.Mypositions)
                if (i.Name == s)
                {
                    temp = new Position_employee(i.Name, i.P.ElementAt(grade.SelectedIndex));
                    break;
                }
            
             Form1.Myemployees.Add(new Employee(name.Text, Convert.ToDouble(salary.Text), int.Parse(age.Text), temp, ma));
            if (position.SelectedIndex == 0)
            {
                Form1.Mymanagers.Add(Form1.Myemployees.Last());
                print_manager_to_combobox();
            }



            clear_basic_info();
            name.ReadOnly = true;
            salary.ReadOnly = true;
            age.ReadOnly = true;
            position.Enabled = false;
            grade.Enabled = false;
            manager.Enabled = false;
            add_skill.Enabled = true;
            add_to_team.Enabled = true;
            show_employee_info();
        }
        void Show_last_employee()
        {
            string s = "Name : " + Form1.Myemployees.Last().Name + "\nSalary : " + Form1.Myemployees.Last().Salary +
                "\nAge :" + Form1.Myemployees.Last().Age + "\nJob Name : " + Form1.Myemployees.Last().Job_Name.Name +
                "\nLetter Grade : " + Form1.Myemployees.Last().Job_Name.P.Letter_Grade +
                "\nMin Salary : " + Form1.Myemployees.Last().Job_Name.P.Minimum_Salary +
                "\tMax Salary : " + Form1.Myemployees.Last().Job_Name.P.Maximum_Salary +
                "\nManager Name : " + Form1.Myemployees.Last().Manager;
            show_employee.Items.AddRange(s.Split('\n'));

        }
        void clear_basic_info()
        {
            name.Clear();
            salary.Clear();
            age.Clear();
            position.SelectedIndex = -1;
            grade.SelectedIndex = -1;
            manager.SelectedIndex = -1;

        }
        void print_manager_to_combobox()
        {
            manager.Items.Clear();
            foreach (Employee i in Form1.Mymanagers)
                manager.Items.Add(i.Name);
        }
        private void position_SelectedIndexChanged(object sender, EventArgs e)
        {
            grade.Items.Clear();
            int index = position.SelectedIndex;
            if (index == -1)
                return;
            foreach (Position_info i in Form1.Mypositions.ElementAt(index).P)
                grade.Items.Add(i.Letter_Grade);
        }

        //                                        **ADD SKILLS**
        private void add_skill_Click_1(object sender, EventArgs e)
        {
            ep.Clear();
            int index = show_skill.SelectedIndex;
            if (index == -1)
            {
                ep.SetError(add_skill, "Please Select The Skill You Want To Add");
                return;
            }
            Regex detect_of_rate = new Regex("^\\d{1,3}$");
            Regex detect_of_name = new Regex("^[a-zA-Z]+((\\s)?[a-zA-Z]+)*$");

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
            if (!detect_of_name.IsMatch(notes.Text.Trim()))
            {
                ep.SetError(notes, "Please Enter A Correct Text Agrees This Form :String(Space + String)* ");
                return;
            }
            string s = show_skill.SelectedItem.ToString();
            string n = notes.Text.Trim();
            skill_employee se = new skill_employee(s);
            se.add_evaluate(new Evaluate_skill(double.Parse(rate.Text), n));
            Form1.Myemployees.Last().Skill_Employee.Add(se);
            show_skill.Items.RemoveAt(index);
            clear_skill();
            show_employee_info();
        }
        void clear_skill()
        {
            show_skill.SelectedIndex = -1;
            rate.Clear();
            notes.Clear();
        }
        void print_skill()
        {
            
            if (Form1.Myemployees.Last().Skill_Employee.Count == 0)
                return;

            foreach (skill_employee i in Form1.Myemployees.Last().Skill_Employee)
                show_employee.Items.Add("Has : " + i.Name);
        }

        //                                      **Add Teams
        List<int> indices_of_teams = new List<int>();
        private void add_to_team_Click(object sender, EventArgs e)
        {

            ep.Clear();
            if (check_team.CheckedIndices.Count == 0)
            {
                ep.SetError(add_to_team, "Please Check The Teams");
                return;
            }
            foreach (string i in check_team.CheckedItems)
                //foreach(Team t in Form1.Myteam)
                //    if(t.Name==i)
                Form1.Myemployees.Last().Teams.Add(i);

            foreach (int i in check_team.CheckedIndices)
                Form1.Myteam.ElementAt(i).add_employee(Form1.Myemployees.Last());

            foreach (int i in check_team.CheckedIndices)
            {
                check_team.SetItemCheckState(i, CheckState.Unchecked);
            }
            finish_add.Enabled = true;
            add_to_team.Enabled = false;
            show_employee_info();
        }
        void print_team()
        {
            if (Form1.Myemployees.Last().Teams.Count == 0)
                return;
            show_employee.Items.Add("The Teams : ");
            foreach (string i in Form1.Myemployees.Last().Teams)
                show_employee.Items.Add(i);
        }

        void show_employee_info()
        {
            show_employee.Items.Clear();
            Show_last_employee();
            print_skill();
            print_team();
        }
        bool if_finish = false;
        private void finish_add_Click(object sender, EventArgs e)
        {

            if_finish = true;
            show_employee.Items.Clear();
            add_employee.Enabled = true;
            add_skill.Enabled = false;
            add_to_team.Enabled = false;
            finish_add.Enabled = false;

            name.ReadOnly = false;
            salary.ReadOnly = false;
            age.ReadOnly = false;
            position.Enabled = true;
            grade.Enabled = true;
            manager.Enabled = true;

        }

        private void add_employeescs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Employee delete=Form1.Myemployees.Last();

            if (if_finish == false)
                Form1.Myemployees.Remove(delete);

            //foreach (Control c in this.Controls)
            //    Utilities.ResetAllControls(c);
         
            this.Dispose();
        }

        //This code below is a copy from the Internet
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
                            comboBox.SelectedIndex = 0;
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
}




