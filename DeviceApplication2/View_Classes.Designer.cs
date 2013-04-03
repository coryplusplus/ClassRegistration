namespace DeviceApplication2
{
    partial class View_Classes
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
            this.class_list = new System.Windows.Forms.ListBox();
            this.add_or_remove = new System.Windows.Forms.Button();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // class_list
            // 
            this.class_list.Location = new System.Drawing.Point(13, 26);
            this.class_list.Name = "class_list";
            this.class_list.Size = new System.Drawing.Size(207, 184);
            this.class_list.TabIndex = 1;
            // 
            // add_or_remove
            // 
            if (!from_login)
            {
                this.add_or_remove.Location = new System.Drawing.Point(53, 227);
                this.add_or_remove.Name = "add_or_remove";
                this.add_or_remove.Size = new System.Drawing.Size(118, 24);
                this.add_or_remove.TabIndex = 2;
                this.add_or_remove.Text = "button1";
                this.add_or_remove.Click += new System.EventHandler(this.add_or_remove_Click);
            }
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Quit";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // View_Classes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            if (!from_login)
            this.Controls.Add(this.add_or_remove);
            this.Controls.Add(this.class_list);
            this.Menu = this.mainMenu1;
            this.Name = "View_Classes";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox class_list;
        private System.Windows.Forms.Button add_or_remove;
        private System.Windows.Forms.MenuItem menuItem1;

    }
}