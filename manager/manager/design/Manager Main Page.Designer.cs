namespace manager.design
{
    partial class manager_main_page
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
            this.btnmenu = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnreservationreport = new System.Windows.Forms.Button();
            this.btnhall = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnmenu
            // 
            this.btnmenu.Location = new System.Drawing.Point(154, 96);
            this.btnmenu.Name = "btnmenu";
            this.btnmenu.Size = new System.Drawing.Size(197, 97);
            this.btnmenu.TabIndex = 0;
            this.btnmenu.Text = "MENU";
            this.btnmenu.UseVisualStyleBackColor = true;
            this.btnmenu.Click += new System.EventHandler(this.btnmenu_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(388, 222);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(197, 97);
            this.btnupdate.TabIndex = 1;
            this.btnupdate.Text = "UPDATE OWN PROFILE";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnreservationreport
            // 
            this.btnreservationreport.Location = new System.Drawing.Point(154, 222);
            this.btnreservationreport.Name = "btnreservationreport";
            this.btnreservationreport.Size = new System.Drawing.Size(197, 97);
            this.btnreservationreport.TabIndex = 2;
            this.btnreservationreport.Text = "RESERVATION REPORT";
            this.btnreservationreport.UseVisualStyleBackColor = true;
            this.btnreservationreport.Click += new System.EventHandler(this.btnreservationreport_Click);
            // 
            // btnhall
            // 
            this.btnhall.Location = new System.Drawing.Point(388, 96);
            this.btnhall.Name = "btnhall";
            this.btnhall.Size = new System.Drawing.Size(197, 97);
            this.btnhall.TabIndex = 4;
            this.btnhall.Text = "HALL";
            this.btnhall.UseVisualStyleBackColor = true;
            this.btnhall.Click += new System.EventHandler(this.btnhall_Click);
            // 
            // manager_main_page
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 438);
            this.Controls.Add(this.btnhall);
            this.Controls.Add(this.btnreservationreport);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnmenu);
            this.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "manager_main_page";
            this.Text = "manager_main_page";
            this.Load += new System.EventHandler(this.manager_main_page_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnmenu;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnreservationreport;
        private System.Windows.Forms.Button btnhall;
    }
}