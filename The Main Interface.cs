using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_evaluation_system
{
    public partial class Form1 : Form
    {
        public static manager_form mf;
        public static add_employeescs ae;
        public static show_employee se;
        public static List<Team> Myteam;
        public static List<Skill> Myskill;
        public static List<Position> Mypositions;
        public static List<Employee> Mymanagers;
        public static List<Employee> Myemployees;
        public Form1()
        {
            InitializeComponent();
            Myteam = new List<Team>();
            Myskill = new List<Skill>();
            Mypositions = new List<Position>();
            Mymanagers = new List<Employee>();
            Myemployees = new List<Employee>();
            initial_employee();
            //mf = new manager_form();
            //ae = new add_employeescs();
            //se = new show_employee();
           
        }

        private void manager_tools_Click(object sender, EventArgs e)
        {
            // mf.ShowDialog();
            var to_dispose = new manager_form();
            to_dispose.ShowDialog();

        }

        private void add_employee_Click(object sender, EventArgs e)
        {
            //ae.ShowDialog();
            var to_dispose = new add_employeescs();
            to_dispose.ShowDialog();
        }

        private void show_employee_Click(object sender, EventArgs e)
        {
            //se.ShowDialog();
            var to_dispose = new show_employee();
            to_dispose.ShowDialog();
        }
        private void modify_employee_Click(object sender, EventArgs e)
        {
            var to_dispose = new Modify_Employees();
            to_dispose.ShowDialog();
        }
        void initial_employee()
        {
            Myteam.Add(new Team("Perpetual Motion", DateTime.Now));
            Myteam.Add(new Team("Team Dynamite", DateTime.Now));
            Myteam.Add(new Team("The Extreme Team", DateTime.Now));
            Myteam.Add(new Team("Overdrivers", DateTime.Now));
            Myteam.Add(new Team("Empty Coffee Cups", DateTime.Now));

            Myskill.Add(new Skill("Financial management", 4));
            Myskill.Add(new Skill("Marketing,sales and customer service", 3));
            Myskill.Add(new Skill("Communication and negotiation", 4));
            Myskill.Add(new Skill("Leadership", 1));
            Myskill.Add(new Skill("Project management and planning", 5));

            Mypositions.Add(new Position("Manager"));
            Mypositions.Add(new Position("Software Developer"));
            Mypositions.Add(new Position("Maintenance Staff"));
            Mypositions.Add(new Position("Staff Positions"));
            Mypositions.Add(new Position("Contractors"));

                int count = 100000;
            foreach (Position i in Mypositions)
            {
                
                for (int j = 1; j <= 5; j++)
                    i.P.Add(new Position_info(Convert.ToChar(96 + j), (1000000-count-j*10000), (600000-count-j*10000)));
                count += 100000;
            }

            
            Myemployees.Add(new Employee("Malaz", 300000, 19, new Position_employee("Software Developer", new Position_info('a', 150000, 75000)), "Ghiath"));
            Myemployees.Last().add_to_team("Perpetual Motion");
            Myteam.ElementAt(0).Employees.Add(Myemployees.Last());


            Myemployees.Add(new Employee("Mezo", 250000, 20, new Position_employee("Maintenance Staff", new Position_info('c', 100000, 50000)), "joudi"));
            Myemployees.Last().add_to_team("Team Dynamite");
            Myteam.ElementAt(1).Employees.Add(Myemployees.Last());


            Myemployees.Add(new Employee("Ghiath", 200000, 25, new Position_employee("Manager", new Position_info('a', 200000, 100000)), "Not Have A Manager"));
            Myemployees.Last().add_to_team("The Extreme Team");
            Mymanagers.Add(Myemployees.Last());
            Myteam.ElementAt(2).Employees.Add(Myemployees.Last());


            Myemployees.Add(new Employee("Sara", 90000, 18, new Position_employee("Staff Positions", new Position_info('a', 50000, 100000)), "Ghiath"));
            Myemployees.Last().add_to_team("Overdrivers");
            Myteam.ElementAt(3).Employees.Add(Myemployees.Last());
            skill_employee sk = new skill_employee("Communication and negotiation");
            sk.add_evaluate(new Evaluate_skill(100, "Good Accent"));
            Myteam.ElementAt(0).Employees.Last().Skill_Employee.Add(sk);


            skill_employee sk2 = new skill_employee("Financial management");
            sk2.add_evaluate(new Evaluate_skill(100, "No Comment"));
            Myteam.ElementAt(0).Employees.Last().Skill_Employee.Add(sk2);
        }

       
    }
}
