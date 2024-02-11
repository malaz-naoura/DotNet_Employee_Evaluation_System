namespace employee_evaluation_system
{
    partial class show_employee
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
            this.teams = new System.Windows.Forms.ListBox();
            this.employees = new System.Windows.Forms.ListBox();
            this.employee_info = new System.Windows.Forms.ListBox();
            this.skill = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.rate = new System.Windows.Forms.TextBox();
            this.review = new System.Windows.Forms.TextBox();
            this.evaluate = new System.Windows.Forms.Button();
            this.show_evaluate = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.g_evaluate = new System.Windows.Forms.GroupBox();
            this.g_show_evaluation = new System.Windows.Forms.GroupBox();
            this.listview_evaluation = new System.Windows.Forms.ListView();
            this.rate_percentage = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ep = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.g_evaluate.SuspendLayout();
            this.g_show_evaluation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // teams
            // 
            this.teams.FormattingEnabled = true;
            this.teams.Location = new System.Drawing.Point(6, 19);
            this.teams.Name = "teams";
            this.teams.Size = new System.Drawing.Size(233, 147);
            this.teams.TabIndex = 0;
            this.teams.SelectedIndexChanged += new System.EventHandler(this.teams_SelectedIndexChanged);
            // 
            // employees
            // 
            this.employees.FormattingEnabled = true;
            this.employees.Location = new System.Drawing.Point(6, 19);
            this.employees.Name = "employees";
            this.employees.Size = new System.Drawing.Size(233, 199);
            this.employees.TabIndex = 1;
            this.employees.SelectedIndexChanged += new System.EventHandler(this.employees_SelectedIndexChanged);
            // 
            // employee_info
            // 
            this.employee_info.FormattingEnabled = true;
            this.employee_info.Location = new System.Drawing.Point(6, 19);
            this.employee_info.Name = "employee_info";
            this.employee_info.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.employee_info.Size = new System.Drawing.Size(233, 147);
            this.employee_info.TabIndex = 3;
            this.employee_info.TabStop = false;
            // 
            // skill
            // 
            this.skill.FormattingEnabled = true;
            this.skill.Location = new System.Drawing.Point(6, 14);
            this.skill.Name = "skill";
            this.skill.Size = new System.Drawing.Size(233, 199);
            this.skill.TabIndex = 2;
            this.skill.SelectedIndexChanged += new System.EventHandler(this.skill_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Review";
            // 
            // rate
            // 
            this.rate.Enabled = false;
            this.rate.Location = new System.Drawing.Point(90, 21);
            this.rate.Name = "rate";
            this.rate.Size = new System.Drawing.Size(182, 20);
            this.rate.TabIndex = 0;
            // 
            // review
            // 
            this.review.Enabled = false;
            this.review.Location = new System.Drawing.Point(90, 60);
            this.review.Multiline = true;
            this.review.Name = "review";
            this.review.Size = new System.Drawing.Size(182, 46);
            this.review.TabIndex = 1;
            // 
            // evaluate
            // 
            this.evaluate.Enabled = false;
            this.evaluate.Location = new System.Drawing.Point(108, 130);
            this.evaluate.Name = "evaluate";
            this.evaluate.Size = new System.Drawing.Size(99, 23);
            this.evaluate.TabIndex = 2;
            this.evaluate.Text = "Evaluate";
            this.evaluate.UseVisualStyleBackColor = true;
            this.evaluate.Click += new System.EventHandler(this.evaluate_Click);
            // 
            // show_evaluate
            // 
            this.show_evaluate.Location = new System.Drawing.Point(90, 207);
            this.show_evaluate.Name = "show_evaluate";
            this.show_evaluate.Size = new System.Drawing.Size(117, 23);
            this.show_evaluate.TabIndex = 0;
            this.show_evaluate.Text = "Show All Evaluation";
            this.show_evaluate.UseVisualStyleBackColor = true;
            this.show_evaluate.Click += new System.EventHandler(this.show_eevaluate_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.employees);
            this.groupBox1.Location = new System.Drawing.Point(12, 232);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(257, 236);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employees";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.teams);
            this.groupBox2.Location = new System.Drawing.Point(12, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 178);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Teams";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.employee_info);
            this.groupBox3.Location = new System.Drawing.Point(334, 26);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(257, 178);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Employees_Info";
            // 
            // g_evaluate
            // 
            this.g_evaluate.Controls.Add(this.review);
            this.g_evaluate.Controls.Add(this.evaluate);
            this.g_evaluate.Controls.Add(this.label1);
            this.g_evaluate.Controls.Add(this.label2);
            this.g_evaluate.Controls.Add(this.rate);
            this.g_evaluate.Location = new System.Drawing.Point(642, 26);
            this.g_evaluate.Name = "g_evaluate";
            this.g_evaluate.Size = new System.Drawing.Size(298, 178);
            this.g_evaluate.TabIndex = 3;
            this.g_evaluate.TabStop = false;
            this.g_evaluate.Text = "Evaluate";
            // 
            // g_show_evaluation
            // 
            this.g_show_evaluation.Controls.Add(this.listview_evaluation);
            this.g_show_evaluation.Controls.Add(this.rate_percentage);
            this.g_show_evaluation.Controls.Add(this.label3);
            this.g_show_evaluation.Controls.Add(this.show_evaluate);
            this.g_show_evaluation.Location = new System.Drawing.Point(642, 232);
            this.g_show_evaluation.Name = "g_show_evaluation";
            this.g_show_evaluation.Size = new System.Drawing.Size(298, 236);
            this.g_show_evaluation.TabIndex = 4;
            this.g_show_evaluation.TabStop = false;
            this.g_show_evaluation.Text = "Show Evaluation";
            // 
            // listview_evaluation
            // 
            this.listview_evaluation.Location = new System.Drawing.Point(6, 53);
            this.listview_evaluation.Name = "listview_evaluation";
            this.listview_evaluation.Size = new System.Drawing.Size(281, 148);
            this.listview_evaluation.TabIndex = 3;
            this.listview_evaluation.TabStop = false;
            this.listview_evaluation.UseCompatibleStateImageBehavior = false;
            this.listview_evaluation.View = System.Windows.Forms.View.Details;
            // 
            // rate_percentage
            // 
            this.rate_percentage.Location = new System.Drawing.Point(130, 27);
            this.rate_percentage.Mask = "00%";
            this.rate_percentage.Name = "rate_percentage";
            this.rate_percentage.ReadOnly = true;
            this.rate_percentage.Size = new System.Drawing.Size(100, 20);
            this.rate_percentage.TabIndex = 10;
            this.rate_percentage.TabStop = false;
            this.rate_percentage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Average Rate";
            // 
            // ep
            // 
            this.ep.ContainerControl = this;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.skill);
            this.groupBox4.Location = new System.Drawing.Point(334, 232);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(257, 236);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Skills";
            // 
            // show_employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(982, 480);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.g_evaluate);
            this.Controls.Add(this.g_show_evaluation);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "show_employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Evaluate Employee And Show Evaluation";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.show_employee_FormClosed);
            this.Load += new System.EventHandler(this.show_employee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.g_evaluate.ResumeLayout(false);
            this.g_evaluate.PerformLayout();
            this.g_show_evaluation.ResumeLayout(false);
            this.g_show_evaluation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ep)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox teams;
        private System.Windows.Forms.ListBox employees;
        private System.Windows.Forms.ListBox employee_info;
        private System.Windows.Forms.ListBox skill;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox rate;
        private System.Windows.Forms.TextBox review;
        private System.Windows.Forms.Button evaluate;
        private System.Windows.Forms.Button show_evaluate;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox g_evaluate;
        private System.Windows.Forms.GroupBox g_show_evaluation;
        private System.Windows.Forms.ErrorProvider ep;
        private System.Windows.Forms.MaskedTextBox rate_percentage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView listview_evaluation;
    }
}