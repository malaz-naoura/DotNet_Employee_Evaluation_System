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
    public partial class Log_In : Form
    {
        public Log_In()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#ffffff");
            //this.Opacity = 3;
            textBox1.BackColor= ColorTranslator.FromHtml("#ffffff");
            
        }

        private void Log_In_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim() == "manager") 
            {
                this.Hide();
                Form1 f = new Form1();
                f.Show();
            }
            else 
            {
                Form1 f = new Form1();
                this.Hide();
                show_employee se = new show_employee();
                se.Show();
            }
        }
    }
}
