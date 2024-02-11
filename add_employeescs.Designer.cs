namespace employee_evaluation_system
{
    partial class add_employeescs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.manager = new System.Windows.Forms.ComboBox();
            this.grade = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add_employee = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.salary = new System.Windows.Forms.TextBox();
            this.position = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.finish_add = new System.Windows.Forms.Button();
            this.show_employee = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.notes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.show_skill = new System.Windows.Forms.ListBox();
            this.rate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.add_skill = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.add_to_team = new System.Windows.Forms.Button();
            this.check_team = new System.Windows.Forms.CheckedListBox();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.manager);
            this.groupBox5.Controls.Add(this.grade);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.add_employee);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.name);
            this.groupBox5.Controls.Add(this.age);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.salary);
            this.groupBox5.Controls.Add(this.position);
            this.groupBox5.Location = new System.Drawing.Point(6, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(263, 345);
            this.groupBox5.TabIndex = 0;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Basic info";
            // 
            // manager
            // 
            this.manager.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.manager.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.manager.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.manager.FormattingEnabled = true;
            this.manager.Location = new System.Drawing.Point(100, 243);
            this.manager.Name = "manager";
            this.manager.Size = new System.Drawing.Size(135, 21);
            this.manager.TabIndex = 5;
            // 
            // grade
            // 
            this.grade.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.grade.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.grade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.grade.FormattingEnabled = true;
            this.grade.Location = new System.Drawing.Point(100, 199);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(135, 21);
            this.grade.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salary";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 207);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Grade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Age";
            // 
            // add_employee
            // 
            this.add_employee.Location = new System.Drawing.Point(68, 306);
            this.add_employee.Name = "add_employee";
            this.add_employee.Size = new System.Drawing.Size(112, 23);
            this.add_employee.TabIndex = 6;
            this.add_employee.Text = "Add Employee";
            this.add_employee.UseVisualStyleBackColor = true;
            this.add_employee.Click += new System.EventHandler(this.add_employee_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Position";
            // 
            // name
            // 
            this.name.Location = new System.Drawing.Point(100, 38);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(135, 20);
            this.name.TabIndex = 0;
            // 
            // age
            // 
            this.age.Location = new System.Drawing.Point(100, 118);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(135, 20);
            this.age.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 246);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Manager";
            // 
            // salary
            // 
            this.salary.Location = new System.Drawing.Point(100, 79);
            this.salary.Name = "salary";
            this.salary.Size = new System.Drawing.Size(135, 20);
            this.salary.TabIndex = 1;
            // 
            // position
            // 
            this.position.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.position.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.position.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.position.FormattingEnabled = true;
            this.position.Location = new System.Drawing.Point(100, 159);
            this.position.Name = "position";
            this.position.Size = new System.Drawing.Size(135, 21);
            this.position.TabIndex = 3;
            this.position.SelectedIndexChanged += new System.EventHandler(this.position_SelectedIndexChanged);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.finish_add);
            this.groupBox4.Controls.Add(this.show_employee);
            this.groupBox4.Location = new System.Drawing.Point(885, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 345);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Employee Information";
            // 
            // finish_add
            // 
            this.finish_add.Enabled = false;
            this.finish_add.Location = new System.Drawing.Point(101, 301);
            this.finish_add.Name = "finish_add";
            this.finish_add.Size = new System.Drawing.Size(91, 23);
            this.finish_add.TabIndex = 0;
            this.finish_add.Text = "Finished Add";
            this.finish_add.UseVisualStyleBackColor = true;
            this.finish_add.Click += new System.EventHandler(this.finish_add_Click);
            // 
            // show_employee
            // 
            this.show_employee.FormattingEnabled = true;
            this.show_employee.Location = new System.Drawing.Point(6, 28);
            this.show_employee.Name = "show_employee";
            this.show_employee.Size = new System.Drawing.Size(280, 238);
            this.show_employee.TabIndex = 0;
            this.show_employee.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.notes);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.show_skill);
            this.groupBox2.Controls.Add(this.rate);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.add_skill);
            this.groupBox2.Location = new System.Drawing.Point(321, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(249, 345);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Skill";
            // 
            // notes
            // 
            this.notes.Location = new System.Drawing.Point(72, 234);
            this.notes.Multiline = true;
            this.notes.Name = "notes";
            this.notes.Size = new System.Drawing.Size(144, 47);
            this.notes.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(17, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Review";
            // 
            // show_skill
            // 
            this.show_skill.FormattingEnabled = true;
            this.show_skill.Location = new System.Drawing.Point(16, 33);
            this.show_skill.Name = "show_skill";
            this.show_skill.Size = new System.Drawing.Size(210, 160);
            this.show_skill.TabIndex = 0;
            // 
            // rate
            // 
            this.rate.Location = new System.Drawing.Point(72, 208);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(144, 20);
            this.rate.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Rate";
            // 
            // add_skill
            // 
            this.add_skill.Enabled = false;
            this.add_skill.Location = new System.Drawing.Point(72, 306);
            this.add_skill.Name = "add_skill";
            this.add_skill.Size = new System.Drawing.Size(91, 23);
            this.add_skill.TabIndex = 3;
            this.add_skill.Text = "Add Skills";
            this.add_skill.UseVisualStyleBackColor = true;
            this.add_skill.Click += new System.EventHandler(this.add_skill_Click_1);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.add_to_team);
            this.groupBox3.Controls.Add(this.check_team);
            this.groupBox3.Location = new System.Drawing.Point(608, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(233, 345);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add To Teams";
            // 
            // add_to_team
            // 
            this.add_to_team.Enabled = false;
            this.add_to_team.Location = new System.Drawing.Point(58, 301);
            this.add_to_team.Name = "add_to_team";
            this.add_to_team.Size = new System.Drawing.Size(91, 23);
            this.add_to_team.TabIndex = 1;
            this.add_to_team.Text = "Add To Teams";
            this.add_to_team.UseVisualStyleBackColor = true;
            this.add_to_team.Click += new System.EventHandler(this.add_to_team_Click);
            // 
            // check_team
            // 
            this.check_team.CheckOnClick = true;
            this.check_team.FormattingEnabled = true;
            this.check_team.Location = new System.Drawing.Point(12, 28);
            this.check_team.Name = "check_team";
            this.check_team.Size = new System.Drawing.Size(201, 229);
            this.check_team.TabIndex = 0;
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // add_employeescs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1206, 382);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Name = "add_employeescs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Employeescs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.add_employeescs_FormClosed);
            this.Load += new System.EventHandler(this.add_employeescs_Load);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListBox show_employee;
        private System.Windows.Forms.ComboBox grade;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button add_skill;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button add_employee;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button add_to_team;
        private System.Windows.Forms.CheckedListBox check_team;
        private System.Windows.Forms.ComboBox manager;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox position;
        private System.Windows.Forms.TextBox salary;
        private System.Windows.Forms.TextBox age;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox rate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.ListBox show_skill;
        private System.Windows.Forms.TextBox notes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button finish_add;
    }
}