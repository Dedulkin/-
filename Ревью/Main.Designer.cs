namespace Ревью
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.id_lb = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.table_btn = new System.Windows.Forms.Button();
            this.review_btn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Location = new System.Drawing.Point(34, 398);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(10, 13);
            this.id_lb.TabIndex = 0;
            this.id_lb.Text = " ";
            this.id_lb.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.table_btn);
            this.panel1.Controls.Add(this.review_btn);
            this.panel1.Controls.Add(this.id_lb);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(129, 450);
            this.panel1.TabIndex = 1;
            // 
            // table_btn
            // 
            this.table_btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.table_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.table_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.table_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.table_btn.Location = new System.Drawing.Point(0, 55);
            this.table_btn.Name = "table_btn";
            this.table_btn.Size = new System.Drawing.Size(129, 55);
            this.table_btn.TabIndex = 2;
            this.table_btn.Text = "Список произведений";
            this.table_btn.UseVisualStyleBackColor = false;
            this.table_btn.Click += new System.EventHandler(this.table_btn_Click);
            // 
            // review_btn
            // 
            this.review_btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.review_btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.review_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.review_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.review_btn.Location = new System.Drawing.Point(0, 0);
            this.review_btn.Name = "review_btn";
            this.review_btn.Size = new System.Drawing.Size(129, 55);
            this.review_btn.TabIndex = 1;
            this.review_btn.Text = "Мои рецензии";
            this.review_btn.UseVisualStyleBackColor = false;
            this.review_btn.Click += new System.EventHandler(this.review_btn_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(129, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(959, 450);
            this.panel2.TabIndex = 2;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(245)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(1088, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label id_lb;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button table_btn;
        private System.Windows.Forms.Button review_btn;
        private System.Windows.Forms.Panel panel2;
    }
}