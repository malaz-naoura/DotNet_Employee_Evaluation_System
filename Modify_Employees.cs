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
    public partial class Modify_Employees : Form
    {
        public Modify_Employees()
        {
            InitializeComponent();
            print_team_to_listview();
            start();
        }

        void start()
        {
            show_skill.Items.Clear();
            check_team.Items.Clear();
            position.Items.Clear();
            manager.Items.Clear();
            //foreach (Skill i in Form1.Myskill)
            //    show_skill.Items.Add(i.Name);
            foreach (Team i in Form1.Myteam)
                check_team.Items.Add(i.Name);
            foreach (Position i in Form1.Mypositions)
                position.Items.Add(i.Name);
            manager.Items.Add("Not Have A Manager");
            foreach (Employee i in Form1.Mymanagers)
                manager.Items.Add(i.Name);
        }
        void print_team_to_listview()
        {
            foreach (Team t in Form1.Myteam)
                team_employee_listview.Items.Add(t.Name, 0);
        }
        bool b_team = true;
        int index_team = -1;
        int index_employee = -1;
        private void team_employee_listview_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (b_team == true)
                foreach (int i in team_employee_listview.SelectedIndices)
                {
                    index_team = i;
                    team_employee_listview.Items.Clear();
                    foreach (Employee emp in Form1.Myteam.ElementAt(index_team).Employees)
                    {
                        team_employee_listview.Items.Add(emp.Name, 1);
                    }
                    b_team = false;
                }
            else
                foreach (int ind_emp in team_employee_listview.SelectedIndices)
                {
                    index_employee = ind_emp;
                    // MessageBox.Show(index_employee.ToString());
                    show_employee_info();
                    show_skill.Items.Clear();

                    //                                           ***Basic info***
                    name.Text = Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Name;
                    salary.Text = Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Salary.ToString();
                    age.Text = Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Age.ToString();
                    position.SelectedItem = Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Job_Name.Name;
                    //Why don't Wrok this way
                    //grade.SelectedItem = Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Job_Name.P.Letter_Grade.ToString();
                    int grade_index = Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Job_Name.P.Letter_Grade;
                    grade.SelectedIndex = grade_index - 97;
                    manager.SelectedItem = Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Manager;
                    //                                           ***skills***
                    foreach (Skill sk in Form1.Myskill)
                    {
                        show_skill.Items.Add(sk.Name);
                        foreach (skill_employee sk_em in Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Skill_Employee)
                            if (sk.Name == sk_em.Name)
                                show_skill.Items.Remove(sk.Name);
                    }
                    //                                              ***Teams***

                    List<int> index_teams_of_employee = new List<int>();
                    int temp_index = -1;
                    foreach (Team t in Form1.Myteam)
                    {
                        temp_index++;
                        foreach (string t_emp in Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Teams)
                            if (t.Name == t_emp)
                                index_teams_of_employee.Add(temp_index);
                    }
                    foreach (int ind in index_teams_of_employee)
                        check_team.SetItemCheckState(ind, CheckState.Checked);
                }
        }


        private void back_to_teams_Click(object sender, EventArgs e)
        {
            b_team = true;
            index_team = -1;
            index_employee = -1;
            team_employee_listview.Items.Clear();
            print_team_to_listview();
            foreach (int a in check_team.CheckedIndices)
                check_team.SetItemCheckState(a, CheckState.Unchecked);

            show_employee.Items.Clear();
            clear_skill();
            show_skill.Items.Clear();
            clear_basic_info();
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

        private void add_skill_Click(object sender, EventArgs e)
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
            Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Skill_Employee.Add(se);
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
        void show_employee_info()
        {
            show_employee.Items.Clear();
            Show_last_employee();
            print_skill();
            print_team();
        }
        void Show_last_employee()
        {
            string s = "Name : " + Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Name + "\nSalary : " + Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Salary +
                "\nAge :" + Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Age + "\nJob Name : " + Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Job_Name.Name +
                "\nLetter Grade : " + Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Job_Name.P.Letter_Grade +
                "\nMin Salary : " + Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Job_Name.P.Minimum_Salary +
                "\tMax Salary : " + Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Job_Name.P.Maximum_Salary +
                "\nManager Name : " + Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Manager;
            show_employee.Items.AddRange(s.Split('\n'));

        }
        void print_skill()
        {

            if (Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Skill_Employee.Count == 0)
                return;

            foreach (skill_employee i in Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Skill_Employee)
                show_employee.Items.Add("Has : " + i.Name);
        }
        void print_team()
        {
            if (Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Teams.Count == 0)
                return;
            show_employee.Items.Add("The Teams : ");
            foreach (string i in Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Teams)
                show_employee.Items.Add(i);
        }

        private void modify_employee_Click(object sender, EventArgs e)
        {
            Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Name = name.Text;
            Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Salary = double.Parse(salary.Text);
            Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Age = int.Parse(age.Text);
            Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Job_Name.Name = position.SelectedItem.ToString();
            Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Job_Name.P.Letter_Grade = Convert.ToChar(grade.SelectedItem.ToString());
            double max_salary = Form1.Mypositions.ElementAt(position.SelectedIndex).P.ElementAt(grade.SelectedIndex).Maximum_Salary;
            double min_salary = Form1.Mypositions.ElementAt(position.SelectedIndex).P.ElementAt(grade.SelectedIndex).Minimum_Salary;
            Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Job_Name.P.Maximum_Salary = max_salary;
            Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Job_Name.P.Minimum_Salary = min_salary;
            if (manager.SelectedIndex == -1 || manager.SelectedIndex == 0)
                Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Manager = "Not Have A Manger";
            modify_employee.Enabled = false;
        }

        private void modify_to_team_Click(object sender, EventArgs e)
        {

            Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Teams.Clear();
            MessageBox.Show(Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Teams.Count().ToString());

            Employee emp = Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee);
            foreach (Team t in Form1.Myteam)
            {
                //MessageBox.Show(index_team + "::::" + index_employee);
                //MessageBox.Show(t.Name+" ::: "+ Form1.Myteam.ElementAt(index_team).Employees.ElementAt(index_employee).Name);
                if (t.employee_is_here(emp) == true)
                {
                    // MessageBox.Show("is here");
                    t.remove_employee(emp);
                    //MessageBox.Show("was here");
                }
            }

            foreach (string i in check_team.CheckedItems)
                emp.Teams.Add(i);

            foreach (int i in check_team.CheckedIndices)
                Form1.Myteam.ElementAt(i).add_employee(emp);
            modify_to_team.Enabled = false;
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
        private void finish_modifying_Click(object sender, EventArgs e)
        {
            show_employee.Items.Clear();
            clear_skill();
            show_skill.Items.Clear();
            clear_basic_info();
            modify_employee.Enabled = true;
            modify_to_team.Enabled = true;
            back_to_teams_Click(sender, e);
        }
    }

}
