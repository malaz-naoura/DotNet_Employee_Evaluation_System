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
    public partial class manager_form : Form
    {


        void initial_values()
        {
            Tool_team("re_print");
            Tool_skill("re_print");
            tool_postion("re_print");
        }
        public manager_form()
        {
            InitializeComponent();
            initial_values();
            for (int i = 97; i < 122; i++)
                text_position_grade.Items.Add(Convert.ToChar(i));
            for (int i = 1; i <= 5; i++)
                combo_skill_weight.Items.Add(i);

            if (Form1.Myemployees.Count >= 0)
                foreach (Employee i in Form1.Myemployees)
                    text_team_leader.Items.Add(i.Name);

        }

        //                                        **Skills**
        private void add_skill_Click(object sender, EventArgs e)
        {
            ep.Clear();
            Regex detect_from_name = new Regex("^[a-zA-Z]+((\\s)?[a-zA-Z]+)*$");
            if (!detect_from_name.IsMatch(text_skill_name.Text.Trim()))
            {
                ep.SetError(text_skill_name, "Please Enter A Correct Name Of Skill Agrees This Form :String(Space + String)* ");
                return;
            }
            if (combo_skill_weight.SelectedIndex == -1)
            {
                ep.SetError(combo_skill_weight, "Please Choose The Weight Of Skill");
                return;

            }

            Form1.Myskill.Add(new Skill(text_skill_name.Text.Trim(), int.Parse(combo_skill_weight.SelectedItem.ToString())));
            string s = Form1.Myskill.Last().Name + " : " + int.Parse(combo_skill_weight.SelectedItem.ToString());
            listBox_skill.Items.Add(s);

            Tool_skill("clear");
        }

        private void modify_skill_Click(object sender, EventArgs e)
        {
            ep.Clear();
            Regex detect_from_name = new Regex("^[a-zA-Z]+((\\s)?[a-zA-Z]+)*$");
            int index = listBox_skill.SelectedIndex;
            if (index == -1)
            {
                ep.SetError(modify_skill, "Please Select The Skill You Want To Modify");
                return;
            }
            if (text_skill_name.Text == "" && combo_skill_weight.SelectedIndex == -1)
            {
                ep.SetError(modify_skill, "Please Enter The Name Or Weight Of Skill To Modify");
                return;
            }
            if (text_skill_name.Text != "")
                if (!detect_from_name.IsMatch(text_skill_name.Text.Trim()))
                {
                    ep.SetError(text_skill_name, "Please Enter A Correct Name Of Skill Agrees This Form :String(Space + String)* ");
                    return;
                }
                else
                    Form1.Myskill.ElementAt(index).Name = text_skill_name.Text.Trim();

            if (combo_skill_weight.SelectedIndex != -1)
                Form1.Myskill.ElementAt(index).Weight = int.Parse(combo_skill_weight.SelectedItem.ToString());

            Tool_skill("clear");
            Tool_skill("re_print");
        }
        void Tool_skill(string s)
        {
            if (s == "clear")
            {
                text_skill_name.Clear();
                combo_skill_weight.SelectedIndex = -1;
            }
            else if (s == "re_print")
            {
                listBox_skill.Items.Clear();
                foreach (Skill i in Form1.Myskill)
                    listBox_skill.Items.Add(i.Name);//+ " : " + i.Weight
            }
        }
        private void remove_skill_Click(object sender, EventArgs e)
        {
            ep.Clear();
            int index = listBox_skill.SelectedIndex;
            if (index == -1)
            {
                ep.SetError(remove_skill, "Please Select The Skill You Want To Remove");
                return;
            }
            Form1.Myskill.RemoveAt(index);
            Tool_skill("re_print");
        }

        private void listBox_skill_SelectedIndexChanged(object sender, EventArgs e)
        {
            Tool_skill("clear");
            int index = listBox_skill.SelectedIndex;
            if (index == -1)
                return;
            combo_skill_weight.SelectedIndex = int.Parse(Form1.Myskill.ElementAt(index).Weight.ToString()) - 1;
        }


        //                                      **Teams**
        private void add_team_Click(object sender, EventArgs e)
        {
            ep.Clear();
            Regex detect_from_name = new Regex("^[a-zA-Z]+((\\s)?[a-zA-Z]+)*$");
            if (!detect_from_name.IsMatch(text_team_name.Text.Trim()))
            {
                ep.SetError(text_team_name, "Please Enter A Correct Name Of Team Agrees This Form :String(Space + String)* ");
                return;
            }
            if (text_team_leader.SelectedIndex == -1)
            {
                ep.SetError(text_team_leader, "Please Choose A Team Leader");
                return;
            }
            foreach (Employee i in Form1.Myemployees)
            {
                if (text_team_leader.SelectedItem.ToString() == i.Name)
                    Form1.Myteam.Add(new Team(text_team_name.Text.Trim(), dateTimePicker1.Value, i));
            }

            listBox_team.Items.Add(Form1.Myteam.Last().Name);
            Tool_team("clear");
        }

        private void modify_team_Click(object sender, EventArgs e)
        {
            ep.Clear();
            Regex detect_from_name = new Regex("^[a-zA-Z]+((\\s)?[a-zA-Z]+)*$");
            int index = listBox_team.SelectedIndex;
            if (index == -1)
            {
                ep.SetError(modify_team, "Please Select The Team You Want To Modify");
                return;
            }
            if (text_team_name.Text.Trim() == "" && text_team_leader.SelectedIndex == -1)
            {
                ep.SetError(modify_team, "Please Enter Name Of Team Or Name Of Leader To Modify");
                return;
            }
            if (text_team_leader.SelectedIndex != -1)
                Form1.Myteam.ElementAt(index).Team_Leader = Form1.Myemployees.ElementAt(text_team_leader.SelectedIndex);
            if (text_team_name.Text != "")
                if (!detect_from_name.IsMatch(text_team_name.Text.Trim()))
                {
                    ep.SetError(text_team_name, "please enter A Correct Name Of Team Agrees This Form :String(Space + String)* ");
                    return;
                }
                else
                    Form1.Myteam.ElementAt(index).Name = text_team_name.Text.Trim();

            Tool_team("clear");
            Tool_team("re_print");
        }

        void Tool_team(string s)
        {
            if (s == "clear")
            {
                text_team_name.Clear();
                text_team_leader.SelectedIndex = -1;
                dateTimePicker1.ResetText();
            }
            else if (s == "re_print")
            {
                listBox_team.Items.Clear();
                foreach (Team i in Form1.Myteam)
                    listBox_team.Items.Add(i.Name);
            }
        }
        private void remove_team_Click(object sender, EventArgs e)
        {
            ep.Clear();
            int index = listBox_team.SelectedIndex;
            if (index == -1)
            {
                ep.SetError(remove_team, "Please Select The Team You Want To Remove");
                return;
            }
            Form1.Myteam.RemoveAt(index);
            Tool_team("re_print");
        }

        //                      **Position**
        private void add_position_Click(object sender, EventArgs e)
        {
            ep.Clear();
            Regex detect_from_name = new Regex("^[a-zA-Z]+((\\s)?[a-zA-Z]+)*$");

            if (!detect_from_name.IsMatch(text_position_name.Text.Trim()))
            {
                ep.SetError(text_position_name, "Please Enter A Correct Name Agrees This Form :String(Space + String)* ");
                return;
            }
            Form1.Mypositions.Add(new Position(text_position_name.Text.Trim()));
            listBox_position.Items.Add(Form1.Mypositions.Last().Name);
            tool_postion("clear");
            listBox_position_info.Items.Clear();
        }

        private void modify_position_Click(object sender, EventArgs e)
        {
            ep.Clear();
            Regex detect_from_name = new Regex("^[a-zA-Z]+((\\s)?[a-zA-Z]+)*$");
            int index = listBox_position.SelectedIndex;
            if (index == -1)
            {
                ep.SetError(modify_position, "Please Select The Position You Want To Modify");
                return;
            }
            if (!detect_from_name.IsMatch(text_position_name.Text.Trim()))
            {
                ep.SetError(text_position_name, "Please Enter A Correct Name Agrees This Form :String(Space + String)* ");
                return;
            }
            Form1.Mypositions.ElementAt(index).Name = text_position_name.Text.Trim();

            tool_postion("clear");
            tool_postion("re_print");
        }
        void tool_postion(string s)
        {
            if (s == "clear")
            {
                text_position_grade.SelectedIndex = -1;
                text_position_name.Clear();
                text_position_min_salary.Clear();
                text_position_max_salary.Clear();
            }
            else if (s == "re_print")
            {
                listBox_position.Items.Clear();
                foreach (Position i in Form1.Mypositions)
                    listBox_position.Items.Add(i.Name);
            }
        }

        private void remove_position_Click(object sender, EventArgs e)
        {
            ep.Clear();
            int index = listBox_position.SelectedIndex;
            if (index == -1)
            {
                ep.SetError(remove_position, "Please Select The Position You Want To Remove");
                return;
            }
            Form1.Mypositions.RemoveAt(index);
            tool_postion("re_print");
        }

        //                                       **position info**
        private void add_position_info_Click(object sender, EventArgs e)
        {
            ep.Clear();
            Regex detect_from_salary = new Regex("^\\d+$");
            int index = listBox_position.SelectedIndex;
            if (index == -1)
            {
                ep.SetError(add_position_info, "Please Select The Position You Want To Add This Info To It");
                return;
            }
            if (text_position_grade.SelectedIndex == -1)
            {
                ep.SetError(text_position_grade, "Please Select The Grade");
                return;
            }
            if (!detect_from_salary.IsMatch(text_position_min_salary.Text.Trim()))
            {
                ep.SetError(text_position_min_salary, "Please Enter A Correct Min Salary");
                return;
            }
            if (!detect_from_salary.IsMatch(text_position_max_salary.Text.Trim()))
            {
                ep.SetError(text_position_max_salary, "Please Enter A Correct Max Salary");
                return;
            }
            Position_info p = new Position_info(Convert.ToChar(text_position_grade.Text), double.Parse(text_position_max_salary.Text.Trim()), double.Parse(text_position_min_salary.Text.Trim()));
            Form1.Mypositions.ElementAt(index).P.Add(p);
            listBox_position_info.Items.Add(Form1.Mypositions.ElementAt(index).P.Last().Letter_Grade
               + "\t" + Form1.Mypositions.ElementAt(index).P.Last().Minimum_Salary + "\t" + Form1.Mypositions.ElementAt(index).P.Last().Maximum_Salary);
            tool_position_info("clear");
        }

        private void modify_position_info_Click(object sender, EventArgs e)
        {
            ep.Clear();
            Regex detect_from_salary = new Regex("^\\d+$");

            int index = listBox_position.SelectedIndex;
            int index2 = listBox_position_info.SelectedIndex;
            if (index == -1)
            {
                ep.SetError(modify_position_info, "Please Select The Position You Want To Modify This Info");
                return;
            }
            if (index2 == -1)
            {
                ep.SetError(modify_position_info, "Please Select The Position Info You Want To Modify");
                return;
            }
            if (text_position_min_salary.Text != "")
            {
                if (!detect_from_salary.IsMatch(text_position_min_salary.Text.Trim()))
                {
                    ep.SetError(text_position_min_salary, "Please Enter A Correct Min Salary");
                    return;
                }
                Form1.Mypositions.ElementAt(index).P.ElementAt(index2).Minimum_Salary = double.Parse(text_position_min_salary.Text.Trim());
            }
            if (text_position_max_salary.Text != "")
            {
                if (!detect_from_salary.IsMatch(text_position_max_salary.Text.Trim()))
                {
                    ep.SetError(text_position_max_salary, "Please Enter A Correct Max Salary");
                    return;
                }
                Form1.Mypositions.ElementAt(index).P.ElementAt(index2).Maximum_Salary = double.Parse(text_position_max_salary.Text.Trim());
            }
            if (text_position_grade.SelectedIndex != -1)
            {
                Form1.Mypositions.ElementAt(index).P.ElementAt(index2).Letter_Grade =Convert.ToChar(text_position_grade.SelectedItem);
            }
                tool_position_info("clear");
            listBox_position_info.Items.Clear();
            foreach (Position_info i in Form1.Mypositions.ElementAt(index).P)
                listBox_position_info.Items.Add(i.Letter_Grade + "\t" + i.Minimum_Salary + "\t" + i.Maximum_Salary);
        }
        void tool_position_info(string s)
        {
            if (s == "clear")
            {
                text_position_min_salary.Clear();
                text_position_max_salary.Clear();
                text_position_grade.ResetText();
            }

        }

        private void listBox_position_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox_position.SelectedIndex;
            if (index == -1)
                return;
            listBox_position_info.Items.Clear();
            foreach (Position_info i in Form1.Mypositions.ElementAt(index).P)
                listBox_position_info.Items.Add(i.Letter_Grade + "\t " + i.Minimum_Salary + "\t\t" + i.Maximum_Salary);
        }

        private void remove_position_info_Click(object sender, EventArgs e)
        {
            int index = listBox_position.SelectedIndex;
            int index2 = listBox_position_info.SelectedIndex;
            if (index == -1)
            {
                ep.SetError(modify_position_info, "Please Select The Position You Want To Modify This Info");
                return;
            }
            if (index2 == -1)
            {
                ep.SetError(modify_position_info, "Please Select The Position Info You Want To Modify");
                return;
            }
            Form1.Mypositions.ElementAt(index).P.RemoveAt(index2);
            listBox_position_info.Items.Clear();
            foreach (Position_info i in Form1.Mypositions.ElementAt(index).P)
                listBox_position_info.Items.Add(i.Letter_Grade + "\t" + i.Maximum_Salary + "\t" + i.Minimum_Salary);

        }

        private void manager_form_FormClosed(object sender, FormClosedEventArgs e)
        {

            this.Dispose();

            //foreach (Control c in this.Controls)
            //    Utilities.ResetAllControls(c);
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
}
