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
            this.components = new System.ComponentModel.Container();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.menuItem2 = new System.Windows.Forms.MenuItem();
            this.view_schedule = new System.Windows.Forms.Button();
            this.lookup_class = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.menuItem1,
            this.menuItem2});
            // 
            // menuItem1
            // 
            this.menuItem1.Index = 0;
            this.menuItem1.Text = "Quit";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // menuItem2
            // 
            this.menuItem2.Index = 1;
            this.menuItem2.Text = "Back";
            this.menuItem2.Click += new System.EventHandler(this.menuItem2_Click);
            // 
            // view_schedule
            // 
            this.view_schedule.Location = new System.Drawing.Point(60, 96);
            this.view_schedule.Name = "view_schedule";
            this.view_schedule.Size = new System.Drawing.Size(104, 28);
            this.view_schedule.TabIndex = 0;
            this.view_schedule.Text = "View Schedule";
            this.view_schedule.Click += new System.EventHandler(this.view_schedule_Click);
            // 
            // lookup_class
            // 
            this.lookup_class.Location = new System.Drawing.Point(60, 186);
            this.lookup_class.Name = "lookup_class";
            this.lookup_class.Size = new System.Drawing.Size(104, 28);
            this.lookup_class.TabIndex = 1;
            this.lookup_class.Text = "Lookup Class";
            this.lookup_class.Click += new System.EventHandler(this.lookup_class_Click);
            // 
            // Main_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
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
    }
}