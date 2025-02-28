namespace manager.design
{
    partial class FoodItem
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
            this.menucategorytable = new System.Windows.Forms.DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.menucategorytable)).BeginInit();
            this.SuspendLayout();
            // 
            // menucategorytable
            // 
            this.menucategorytable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menucategorytable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.menucategorytable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.menucategorytable.Location = new System.Drawing.Point(12, 115);
            this.menucategorytable.MultiSelect = false;
            this.menucategorytable.Name = "menucategorytable";
            this.menucategorytable.RowHeadersVisible = false;
            this.menucategorytable.RowHeadersWidth = 51;
            this.menucategorytable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.menucategorytable.Size = new System.Drawing.Size(793, 398);
            this.menucategorytable.TabIndex = 10;
            this.menucategorytable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.menucategorytable_CellContentClick);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 10.2F);
            this.button3.Location = new System.Drawing.Point(572, 74);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 35);
            this.button3.TabIndex = 9;
            this.button3.Text = "EDIT";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 10.2F);
            this.button2.Location = new System.Drawing.Point(688, 74);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "DELETE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 10.2F);
            this.button1.Location = new System.Drawing.Point(12, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(774, 47);
            this.label2.TabIndex = 6;
            this.label2.Text = "MENU";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // FoodItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 540);
            this.Controls.Add(this.menucategorytable);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Name = "FoodItem";
            this.Text = "FoodItem";
            ((System.ComponentModel.ISupportInitialize)(this.menucategorytable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView menucategorytable;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}