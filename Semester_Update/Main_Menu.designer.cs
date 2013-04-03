namespace DeviceApplication2
{
    partial class Main_Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.view_schedule = new System.Windows.Forms.Button();
            this.lookup_class = new System.Windows.Forms.Button();
            this.view_q = new System.Windows.Forms.Button();
            this.Settings = new System.Windows.Forms.Button();
            this.addToCalendar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.menuItem2);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Logout";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Text = "Help";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // view_schedule
            // 
            this.view_schedule.BackColor = System.Drawing.SystemColors.GrayText;
            this.view_schedule.Location = new System.Drawing.Point(16, 73);
            this.view_schedule.Name = "view_schedule";
            this.view_schedule.Size = new System.Drawing.Size(202, 28);
            this.view_schedule.TabIndex = 0;
            this.view_schedule.Text = "View Registered Courses";
            this.view_schedule.Click += new System.EventHandler(this.view_schedule_Click);
            // 
            // lookup_class
            // 
            this.lookup_class.BackColor = System.Drawing.SystemColors.GrayText;
            this.lookup_class.Location = new System.Drawing.Point(16, 27);
            this.lookup_class.Name = "lookup_class";
            this.lookup_class.Size = new System.Drawing.Size(202, 28);
            this.lookup_class.TabIndex = 1;
            this.lookup_class.Text = "Find Course and Register";
            this.lookup_class.Click += new System.EventHandler(this.lookup_class_Click);
            // 
            // view_q
            // 
            this.view_q.BackColor = System.Drawing.SystemColors.GrayText;
            this.view_q.Location = new System.Drawing.Point(16, 120);
            this.view_q.Name = "view_q";
            this.view_q.Size = new System.Drawing.Size(202, 28);
            this.view_q.TabIndex = 2;
            this.view_q.Text = "View Courses in your Queue";
            this.view_q.Click += new System.EventHandler(this.view_q_Click);
            // 
            // Settings
            // 
            this.Settings.BackColor = System.Drawing.SystemColors.GrayText;
            this.Settings.Location = new System.Drawing.Point(16, 211);
            this.Settings.Name = "Settings";
            this.Settings.Size = new System.Drawing.Size(202, 28);
            this.Settings.TabIndex = 3;
            this.Settings.Text = "Settings";
            this.Settings.Click += new System.EventHandler(this.Settings_Click);
            // 
            // addToCalendar
            // 
            this.addToCalendar.BackColor = System.Drawing.SystemColors.GrayText;
            this.addToCalendar.Location = new System.Drawing.Point(16, 168);
            this.addToCalendar.Name = "addToCalendar";
            this.addToCalendar.Size = new System.Drawing.Size(202, 28);
            this.addToCalendar.TabIndex = 4;
            this.addToCalendar.Text = "Add Classes To Calendar";
            this.addToCalendar.Click += new System.EventHandler(this.addToCalendar_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.addToCalendar);
            this.Controls.Add(this.Settings);
            this.Controls.Add(this.view_q);
            this.Controls.Add(this.lookup_class);
            this.Controls.Add(this.view_schedule);
            this.Menu = this.mainMenu1;
            this.Name = "Main_Menu";
            this.Text = "Main Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.MenuItem menuItem2;
        private System.Windows.Forms.Button view_schedule;
        private System.Windows.Forms.Button lookup_class;
        private System.Windows.Forms.Button view_q;
        private System.Windows.Forms.Button Settings;
        private System.Windows.Forms.Button addToCalendar;
    }
}