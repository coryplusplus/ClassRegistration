namespace DeviceApplication2
{
    partial class Search_Menu
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
            this.subjet_label = new System.Windows.Forms.Label();
            this.course_number_label = new System.Windows.Forms.Label();
            this.subject_input = new System.Windows.Forms.TextBox();
            this.course_number_input = new System.Windows.Forms.TextBox();
            this.submit_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            // 
            // menuItem1
            // 
            this.menuItem1.Text = "Quit";
            this.menuItem1.Click += new System.EventHandler(this.menuItem1_Click);
            // 
            // subjet_label
            // 
            this.subjet_label.Location = new System.Drawing.Point(71, 24);
            this.subjet_label.Name = "subjet_label";
            this.subjet_label.Size = new System.Drawing.Size(100, 20);
            this.subjet_label.Text = "Subject:";
            // 
            // course_number_label
            // 
            this.course_number_label.Location = new System.Drawing.Point(71, 113);
            this.course_number_label.Name = "course_number_label";
            this.course_number_label.Size = new System.Drawing.Size(100, 20);
            this.course_number_label.Text = "Course Number:";
            // 
            // subject_input
            // 
            this.subject_input.Location = new System.Drawing.Point(71, 61);
            this.subject_input.MaxLength = 3;
            this.subject_input.Name = "subject_input";
            this.subject_input.Size = new System.Drawing.Size(100, 21);
            this.subject_input.TabIndex = 2;
            this.subject_input.Text = "AAA";
            // 
            // course_number_input
            // 
            this.course_number_input.Location = new System.Drawing.Point(71, 152);
            this.course_number_input.MaxLength = 3;
            this.course_number_input.Name = "course_number_input";
            this.course_number_input.Size = new System.Drawing.Size(100, 21);
            this.course_number_input.TabIndex = 3;
            this.course_number_input.Text = "###";
            // 
            // submit_search
            // 
            this.submit_search.Location = new System.Drawing.Point(71, 224);
            this.submit_search.Name = "submit_search";
            this.submit_search.Size = new System.Drawing.Size(72, 20);
            this.submit_search.TabIndex = 4;
            this.submit_search.Text = "Submit";
            this.submit_search.Click += new System.EventHandler(this.submit_search_Click);
            // 
            // Search_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.submit_search);
            this.Controls.Add(this.course_number_input);
            this.Controls.Add(this.subject_input);
            this.Controls.Add(this.course_number_label);
            this.Controls.Add(this.subjet_label);
            this.Menu = this.mainMenu1;
            this.Name = "Search_Menu";
            this.Text = "Search_Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.Label subjet_label;
        private System.Windows.Forms.Label course_number_label;
        private System.Windows.Forms.TextBox subject_input;
        private System.Windows.Forms.TextBox course_number_input;
        private System.Windows.Forms.Button submit_search;
    }
}