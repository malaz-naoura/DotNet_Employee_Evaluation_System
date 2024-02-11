namespace employee_evaluation_system
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.manager_tools = new System.Windows.Forms.Button();
            this.add_employee = new System.Windows.Forms.Button();
            this.show_employee = new System.Windows.Forms.Button();
            this.modify_employee = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // manager_tools
            // 
            this.manager_tools.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.manager_tools.Location = new System.Drawing.Point(24, 296);
            this.manager_tools.Name = "manager_tools";
            this.manager_tools.Size = new System.Drawing.Size(124, 23);
            this.manager_tools.TabIndex = 0;
            this.manager_tools.Text = "Manager Tools";
            this.manager_tools.UseVisualStyleBackColor = false;
            this.manager_tools.Click += new System.EventHandler(this.manager_tools_Click);
            // 
            // add_employee
            // 
            this.add_employee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.add_employee.Location = new System.Drawing.Point(171, 296);
            this.add_employee.Name = "add_employee";
            this.add_employee.Size = new System.Drawing.Size(124, 23);
            this.add_employee.TabIndex = 1;
            this.add_employee.Text = "Add Employee";
            this.add_employee.UseVisualStyleBackColor = false;
            this.add_employee.Click += new System.EventHandler(this.add_employee_Click);
            // 
            // show_employee
            // 
            this.show_employee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.show_employee.Location = new System.Drawing.Point(465, 296);
            this.show_employee.Name = "show_employee";
            this.show_employee.Size = new System.Drawing.Size(124, 23);
            this.show_employee.TabIndex = 2;
            this.show_employee.Text = "Show Employee";
            this.show_employee.UseVisualStyleBackColor = false;
            this.show_employee.Click += new System.EventHandler(this.show_employee_Click);
            // 
            // modify_employee
            // 
            this.modify_employee.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.modify_employee.Location = new System.Drawing.Point(310, 296);
            this.modify_employee.Name = "modify_employee";
            this.modify_employee.Size = new System.Drawing.Size(124, 23);
            this.modify_employee.TabIndex = 3;
            this.modify_employee.Text = "Modify Employee";
            this.modify_employee.UseVisualStyleBackColor = false;
            this.modify_employee.Click += new System.EventHandler(this.modify_employee_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(654, 371);
            this.Controls.Add(this.modify_employee);
            this.Controls.Add(this.show_employee);
            this.Controls.Add(this.add_employee);
            this.Controls.Add(this.manager_tools);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manager";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manager_tools;
        private System.Windows.Forms.Button add_employee;
        private System.Windows.Forms.Button show_employee;
        private System.Windows.Forms.Button modify_employee;
    }
}

