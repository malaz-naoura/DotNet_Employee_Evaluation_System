namespace employee_evaluation_system
{
    partial class manager_form
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
            this.add_team = new System.Windows.Forms.Button();
            this.remove_team = new System.Windows.Forms.Button();
            this.remove_skill = new System.Windows.Forms.Button();
            this.add_skill = new System.Windows.Forms.Button();
            this.listBox_team = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBox_skill = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.combo_skill_weight = new System.Windows.Forms.ComboBox();
            this.modify_skill = new System.Windows.Forms.Button();
            this.text_skill_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.modify_team = new System.Windows.Forms.Button();
            this.text_team_leader = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.text_team_name = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.remove_position = new System.Windows.Forms.Button();
            this.listBox_position = new System.Windows.Forms.ListBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.modify_position = new System.Windows.Forms.Button();
            this.add_position = new System.Windows.Forms.Button();
            this.text_position_name = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.text_position_grade = new System.Windows.Forms.ComboBox();
            this.modify_position_info = new System.Windows.Forms.Button();
            this.add_position_info = new System.Windows.Forms.Button();
            this.text_position_max_salary = new System.Windows.Forms.TextBox();
            this.text_position_min_salary = new System.Windows.Forms.TextBox();
            this.listBox_position_info = new System.Windows.Forms.ListBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.remove_position_info = new System.Windows.Forms.Button();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.SuspendLayout();
            // 
            // add_team
            // 
            this.add_team.Location = new System.Drawing.Point(15, 158);
            this.add_team.Name = "add_team";
            this.add_team.Size = new System.Drawing.Size(86, 23);
            this.add_team.TabIndex = 3;
            this.add_team.Text = "Add";
            this.add_team.UseVisualStyleBackColor = true;
            this.add_team.Click += new System.EventHandler(this.add_team_Click);
            // 
            // remove_team
            // 
            this.remove_team.Location = new System.Drawing.Point(61, 308);
            this.remove_team.Name = "remove_team";
            this.remove_team.Size = new System.Drawing.Size(104, 23);
            this.remove_team.TabIndex = 1;
            this.remove_team.TabStop = false;
            this.remove_team.Text = "Remove Team";
            this.remove_team.UseVisualStyleBackColor = true;
            this.remove_team.Click += new System.EventHandler(this.remove_team_Click);
            // 
            // remove_skill
            // 
            this.remove_skill.Location = new System.Drawing.Point(70, 308);
            this.remove_skill.Name = "remove_skill";
            this.remove_skill.Size = new System.Drawing.Size(104, 23);
            this.remove_skill.TabIndex = 3;
            this.remove_skill.TabStop = false;
            this.remove_skill.Text = "Remove Skill";
            this.remove_skill.UseVisualStyleBackColor = true;
            this.remove_skill.Click += new System.EventHandler(this.remove_skill_Click);
            // 
            // add_skill
            // 
            this.add_skill.Location = new System.Drawing.Point(19, 158);
            this.add_skill.Name = "add_skill";
            this.add_skill.Size = new System.Drawing.Size(89, 23);
            this.add_skill.TabIndex = 2;
            this.add_skill.Text = "Add";
            this.add_skill.UseVisualStyleBackColor = true;
            this.add_skill.Click += new System.EventHandler(this.add_skill_Click);
            // 
            // listBox_team
            // 
            this.listBox_team.FormattingEnabled = true;
            this.listBox_team.Location = new System.Drawing.Point(6, 21);
            this.listBox_team.Name = "listBox_team";
            this.listBox_team.Size = new System.Drawing.Size(213, 264);
            this.listBox_team.TabIndex = 4;
            this.listBox_team.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.listBox_team);
            this.groupBox1.Controls.Add(this.remove_team);
            this.groupBox1.Location = new System.Drawing.Point(27, 253);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 360);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Teams";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.listBox_skill);
            this.groupBox2.Controls.Add(this.remove_skill);
            this.groupBox2.Location = new System.Drawing.Point(314, 253);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(251, 360);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Skills";
            // 
            // listBox_skill
            // 
            this.listBox_skill.FormattingEnabled = true;
            this.listBox_skill.Location = new System.Drawing.Point(19, 21);
            this.listBox_skill.Name = "listBox_skill";
            this.listBox_skill.Size = new System.Drawing.Size(213, 264);
            this.listBox_skill.TabIndex = 5;
            this.listBox_skill.TabStop = false;
            this.listBox_skill.SelectedIndexChanged += new System.EventHandler(this.listBox_skill_SelectedIndexChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.combo_skill_weight);
            this.groupBox3.Controls.Add(this.modify_skill);
            this.groupBox3.Controls.Add(this.add_skill);
            this.groupBox3.Controls.Add(this.text_skill_name);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(314, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(251, 204);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Add Skill";
            // 
            // combo_skill_weight
            // 
            this.combo_skill_weight.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.combo_skill_weight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combo_skill_weight.FormattingEnabled = true;
            this.combo_skill_weight.Location = new System.Drawing.Point(95, 74);
            this.combo_skill_weight.Name = "combo_skill_weight";
            this.combo_skill_weight.Size = new System.Drawing.Size(100, 21);
            this.combo_skill_weight.TabIndex = 1;
            // 
            // modify_skill
            // 
            this.modify_skill.Location = new System.Drawing.Point(146, 158);
            this.modify_skill.Name = "modify_skill";
            this.modify_skill.Size = new System.Drawing.Size(86, 23);
            this.modify_skill.TabIndex = 3;
            this.modify_skill.Text = "Modify";
            this.modify_skill.UseVisualStyleBackColor = true;
            this.modify_skill.Click += new System.EventHandler(this.modify_skill_Click);
            // 
            // text_skill_name
            // 
            this.text_skill_name.Location = new System.Drawing.Point(95, 35);
            this.text_skill_name.Name = "text_skill_name";
            this.text_skill_name.Size = new System.Drawing.Size(100, 20);
            this.text_skill_name.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Weight";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.dateTimePicker1);
            this.groupBox4.Controls.Add(this.modify_team);
            this.groupBox4.Controls.Add(this.text_team_leader);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.add_team);
            this.groupBox4.Controls.Add(this.text_team_name);
            this.groupBox4.Controls.Add(this.label2);
            this.groupBox4.Controls.Add(this.label1);
            this.groupBox4.Location = new System.Drawing.Point(18, 28);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(234, 204);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add Team";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(107, 70);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(100, 20);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // modify_team
            // 
            this.modify_team.Location = new System.Drawing.Point(131, 158);
            this.modify_team.Name = "modify_team";
            this.modify_team.Size = new System.Drawing.Size(86, 23);
            this.modify_team.TabIndex = 4;
            this.modify_team.Text = "Modify ";
            this.modify_team.UseVisualStyleBackColor = true;
            this.modify_team.Click += new System.EventHandler(this.modify_team_Click);
            // 
            // text_team_leader
            // 
            this.text_team_leader.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.text_team_leader.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.text_team_leader.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_team_leader.FormattingEnabled = true;
            this.text_team_leader.Location = new System.Drawing.Point(107, 102);
            this.text_team_leader.Name = "text_team_leader";
            this.text_team_leader.Size = new System.Drawing.Size(100, 21);
            this.text_team_leader.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 110);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 100;
            this.label5.Text = "Team Leader";
            // 
            // text_team_name
            // 
            this.text_team_name.Location = new System.Drawing.Point(107, 32);
            this.text_team_name.Name = "text_team_name";
            this.text_team_name.Size = new System.Drawing.Size(100, 20);
            this.text_team_name.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 100;
            this.label2.Text = "Creation Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 100;
            this.label1.Text = "Name";
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox5.Controls.Add(this.remove_position);
            this.groupBox5.Controls.Add(this.listBox_position);
            this.groupBox5.Location = new System.Drawing.Point(625, 253);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(251, 360);
            this.groupBox5.TabIndex = 10;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Position";
            // 
            // remove_position
            // 
            this.remove_position.Location = new System.Drawing.Point(68, 308);
            this.remove_position.Name = "remove_position";
            this.remove_position.Size = new System.Drawing.Size(104, 23);
            this.remove_position.TabIndex = 1;
            this.remove_position.TabStop = false;
            this.remove_position.Text = "Remove Position";
            this.remove_position.UseVisualStyleBackColor = true;
            this.remove_position.Click += new System.EventHandler(this.remove_position_Click);
            // 
            // listBox_position
            // 
            this.listBox_position.FormattingEnabled = true;
            this.listBox_position.Location = new System.Drawing.Point(15, 19);
            this.listBox_position.Name = "listBox_position";
            this.listBox_position.Size = new System.Drawing.Size(213, 264);
            this.listBox_position.TabIndex = 0;
            this.listBox_position.TabStop = false;
            this.listBox_position.SelectedIndexChanged += new System.EventHandler(this.listBox_position_SelectedIndexChanged);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox6.Controls.Add(this.modify_position);
            this.groupBox6.Controls.Add(this.add_position);
            this.groupBox6.Controls.Add(this.text_position_name);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Location = new System.Drawing.Point(625, 32);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(251, 200);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Add Position";
            // 
            // modify_position
            // 
            this.modify_position.Location = new System.Drawing.Point(153, 154);
            this.modify_position.Name = "modify_position";
            this.modify_position.Size = new System.Drawing.Size(75, 23);
            this.modify_position.TabIndex = 3;
            this.modify_position.Text = "Modify";
            this.modify_position.UseVisualStyleBackColor = true;
            this.modify_position.Click += new System.EventHandler(this.modify_position_Click);
            // 
            // add_position
            // 
            this.add_position.Location = new System.Drawing.Point(32, 154);
            this.add_position.Name = "add_position";
            this.add_position.Size = new System.Drawing.Size(75, 23);
            this.add_position.TabIndex = 2;
            this.add_position.Text = "Add";
            this.add_position.UseVisualStyleBackColor = true;
            this.add_position.Click += new System.EventHandler(this.add_position_Click);
            // 
            // text_position_name
            // 
            this.text_position_name.Location = new System.Drawing.Point(119, 35);
            this.text_position_name.Name = "text_position_name";
            this.text_position_name.Size = new System.Drawing.Size(100, 20);
            this.text_position_name.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(35, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Grade";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(35, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Minimum Salary";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(35, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Maximum Salary";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox7.Controls.Add(this.text_position_grade);
            this.groupBox7.Controls.Add(this.modify_position_info);
            this.groupBox7.Controls.Add(this.add_position_info);
            this.groupBox7.Controls.Add(this.text_position_max_salary);
            this.groupBox7.Controls.Add(this.text_position_min_salary);
            this.groupBox7.Controls.Add(this.label8);
            this.groupBox7.Controls.Add(this.label9);
            this.groupBox7.Controls.Add(this.label7);
            this.groupBox7.Location = new System.Drawing.Point(944, 36);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(251, 196);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Position Info";
            // 
            // text_position_grade
            // 
            this.text_position_grade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.text_position_grade.FormattingEnabled = true;
            this.text_position_grade.Location = new System.Drawing.Point(129, 31);
            this.text_position_grade.Name = "text_position_grade";
            this.text_position_grade.Size = new System.Drawing.Size(100, 21);
            this.text_position_grade.TabIndex = 0;
            // 
            // modify_position_info
            // 
            this.modify_position_info.Location = new System.Drawing.Point(153, 150);
            this.modify_position_info.Name = "modify_position_info";
            this.modify_position_info.Size = new System.Drawing.Size(75, 23);
            this.modify_position_info.TabIndex = 4;
            this.modify_position_info.Text = "Modify";
            this.modify_position_info.UseVisualStyleBackColor = true;
            this.modify_position_info.Click += new System.EventHandler(this.modify_position_info_Click);
            // 
            // add_position_info
            // 
            this.add_position_info.Location = new System.Drawing.Point(44, 150);
            this.add_position_info.Name = "add_position_info";
            this.add_position_info.Size = new System.Drawing.Size(75, 23);
            this.add_position_info.TabIndex = 3;
            this.add_position_info.Text = "Add";
            this.add_position_info.UseVisualStyleBackColor = true;
            this.add_position_info.Click += new System.EventHandler(this.add_position_info_Click);
            // 
            // text_position_max_salary
            // 
            this.text_position_max_salary.Location = new System.Drawing.Point(131, 99);
            this.text_position_max_salary.Name = "text_position_max_salary";
            this.text_position_max_salary.Size = new System.Drawing.Size(100, 20);
            this.text_position_max_salary.TabIndex = 2;
            // 
            // text_position_min_salary
            // 
            this.text_position_min_salary.Location = new System.Drawing.Point(131, 66);
            this.text_position_min_salary.Name = "text_position_min_salary";
            this.text_position_min_salary.Size = new System.Drawing.Size(100, 20);
            this.text_position_min_salary.TabIndex = 1;
            // 
            // listBox_position_info
            // 
            this.listBox_position_info.FormattingEnabled = true;
            this.listBox_position_info.Location = new System.Drawing.Point(16, 21);
            this.listBox_position_info.Name = "listBox_position_info";
            this.listBox_position_info.Size = new System.Drawing.Size(213, 264);
            this.listBox_position_info.TabIndex = 11;
            this.listBox_position_info.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox8.Controls.Add(this.remove_position_info);
            this.groupBox8.Controls.Add(this.listBox_position_info);
            this.groupBox8.Location = new System.Drawing.Point(944, 253);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(245, 360);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Position Info";
            // 
            // remove_position_info
            // 
            this.remove_position_info.Location = new System.Drawing.Point(68, 308);
            this.remove_position_info.Name = "remove_position_info";
            this.remove_position_info.Size = new System.Drawing.Size(120, 23);
            this.remove_position_info.TabIndex = 2;
            this.remove_position_info.TabStop = false;
            this.remove_position_info.Text = "Remove Position Info";
            this.remove_position_info.UseVisualStyleBackColor = true;
            this.remove_position_info.Click += new System.EventHandler(this.remove_position_info_Click);
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // manager_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 626);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "manager_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager Tools";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.manager_form_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button add_team;
        private System.Windows.Forms.Button remove_team;
        private System.Windows.Forms.Button remove_skill;
        private System.Windows.Forms.Button add_skill;
        private System.Windows.Forms.ListBox listBox_team;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox text_skill_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox text_team_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_skill;
        private System.Windows.Forms.ComboBox text_team_leader;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button modify_skill;
        private System.Windows.Forms.Button modify_team;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button remove_position;
        private System.Windows.Forms.ListBox listBox_position;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button modify_position;
        private System.Windows.Forms.Button add_position;
        private System.Windows.Forms.TextBox text_position_name;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button modify_position_info;
        private System.Windows.Forms.Button add_position_info;
        private System.Windows.Forms.TextBox text_position_max_salary;
        private System.Windows.Forms.TextBox text_position_min_salary;
        private System.Windows.Forms.ComboBox text_position_grade;
        private System.Windows.Forms.ListBox listBox_position_info;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button remove_position_info;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.ComboBox combo_skill_weight;
    }
}