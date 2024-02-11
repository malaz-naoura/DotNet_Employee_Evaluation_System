using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace employee_evaluation_system
{

    public class Position_info
    {
        char letter_grade;
        double minimum_salary;
        double maximum_salary;
        public char Letter_Grade
        {
            set { letter_grade = value; }
            get { return letter_grade; }
        }
        public double Minimum_Salary
        {
            set { minimum_salary = value; }
            get { return minimum_salary; }
        }
        public double Maximum_Salary
        {
            set { maximum_salary = value; }
            get { return maximum_salary; }
        }
        public Position_info(char l, double max, double min)
        {
            letter_grade = l;
            maximum_salary = max;
            minimum_salary = min;
        }
    }
    public class Position
    {
        protected string name;
        public List<Position_info> P;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public Position(string name)
        {
            P = new List<Position_info>();
            this.name = name;
        }

    }
    public class Position_employee
    {
        string name;
        Position_info p;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public Position_info P { get { return p; } }
        public Position_employee(string n, Position_info p)
        {
            this.name = n;
            this.p = p;
        }
    }
    public class Skill
    {
        protected string name;
        protected int weight;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public int Weight
        {
            set { if (value > 0) weight = value; else weight = 1; }
            get { return weight; }
        }
        public Skill(string name, int weight)
        {
            this.name = name;
            this.weight = weight;
        }
    }
    public class Evaluate_skill
    {
        double rate;
        string notes;
        public double Rate
        {
            set { rate = value; }
            get { return rate; }
        }
        public string Notes
        {
            set { notes = value; }
            get { return notes; }
        }
        public Evaluate_skill(double rate, string notes)
        {
            this.rate = rate;
            this.notes = notes;
        }

    }
    public class skill_employee
    {
        string name;
        List<Evaluate_skill> evaluate_skill;
        public List<Evaluate_skill> Evaluate_Skill { get { return evaluate_skill; } }
        public string Name { get { return name; } }

        public skill_employee(string name)
        {
            evaluate_skill = new List<Evaluate_skill>();
            this.name = name;
        }
        public void add_evaluate(Evaluate_skill e)
        {
            evaluate_skill.Add(e);
        }

    }
    public class Employee
    {
        string name;
        double salary;
        int age;
        Position_employee job_name;
        List<skill_employee> skill_emp;
        string manager;
        List<string> teams;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public double Salary
        {
            set
            {
                if (value > 0)
                    salary = value;
            }
            get { return salary; }
        }
        public int Age
        {
            set
            {
                if (value > 0)
                    age = value;
            }
            get { return age; }
        }
        public Position_employee Job_Name { get { return job_name; } }
        public List<skill_employee> Skill_Employee { get { return skill_emp; } }
        public string Manager
        {
            set { manager = value; }
            get { return manager; }
        }
        public List<string> Teams { get { return teams; } }
        public Employee(string name, double salary, int age, Position_employee job_name)
        {
            teams = new List<string>();
            skill_emp = new List<skill_employee>();
            this.name = name;
            this.salary = salary;
            this.age = age;
            this.job_name = job_name;
        }
        public Employee(string name, double salary, int age, Position_employee job_name, string manager) : this(name, salary, age, job_name)
        {
            this.manager = manager;
        }
        public void add_skill(skill_employee s)
        {
            skill_emp.Add(s);
        }

        public void remove_skill(string name)
        {
            foreach (skill_employee i in skill_emp)
                if (i.Name == name)
                {
                    skill_emp.Remove(i);
                    break;
                }
        }
        public void remove_skill(int index)
        {
            skill_emp.RemoveAt(index);
        }
        public void add_to_team(string t)
        {
            teams.Add(t);
        }
        public void remove_from_team(string t)
        {
            teams.Remove(t);
        }
    }
    public class Team
    {
        string name;
        DateTime date;
        List<Employee> employees;
        Employee team_leader;
        public string Name
        {
            set { name = value; }
            get { return name; }
        }
        public DateTime Date { get { return date; } }
        public List<Employee> Employees { get { return employees; } }
        public Employee Team_Leader
        {
            get { return team_leader; }
            set { team_leader = value; }
        }
        public Team(string name, DateTime d)
        {
            employees = new List<Employee>();
            this.name = name;
            this.date = d;

        }
        public Team(string name, DateTime d, Employee team_leader) : this(name, d)
        {
            this.team_leader = team_leader;
        }
        public void add_employee(Employee e)
        {
            employees.Add(e);
        }
        public void remove_employee(Employee e)
        {
            employees.Remove(e);
        }
        public bool employee_is_here(Employee e)
        {
            foreach (Employee i in employees)
                if (e == i)
                {
                    return true;
                }

            return false;

        }
    }
}
