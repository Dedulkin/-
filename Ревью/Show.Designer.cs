namespace Ревью
{
    partial class Show
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Show));
            this.cre_lb = new System.Windows.Forms.Label();
            this.hello_lb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.desc_Tb = new System.Windows.Forms.TextBox();
            this.list_DGV = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.list_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // cre_lb
            // 
            this.cre_lb.AutoSize = true;
            this.cre_lb.Location = new System.Drawing.Point(653, 46);
            this.cre_lb.Name = "cre_lb";
            this.cre_lb.Size = new System.Drawing.Size(0, 13);
            this.cre_lb.TabIndex = 0;
            this.cre_lb.Visible = false;
            // 
            // hello_lb
            // 
            this.hello_lb.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.hello_lb.Location = new System.Drawing.Point(12, 13);
            this.hello_lb.Name = "hello_lb";
            this.hello_lb.Size = new System.Drawing.Size(483, 46);
            this.hello_lb.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(402, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Рецензия:";
            // 
            // desc_Tb
            // 
            this.desc_Tb.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.desc_Tb.Location = new System.Drawing.Point(402, 83);
            this.desc_Tb.Multiline = true;
            this.desc_Tb.Name = "desc_Tb";
            this.desc_Tb.ReadOnly = true;
            this.desc_Tb.Size = new System.Drawing.Size(287, 355);
            this.desc_Tb.TabIndex = 12;
            // 
            // list_DGV
            // 
            this.list_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_DGV.Location = new System.Drawing.Point(16, 62);
            this.list_DGV.Name = "list_DGV";
            this.list_DGV.Size = new System.Drawing.Size(380, 376);
            this.list_DGV.TabIndex = 14;
            this.list_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_DGV_CellContentClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ревью.Properties.Resources.upd;
            this.pictureBox1.Location = new System.Drawing.Point(656, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Show
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(245)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(699, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.list_DGV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.desc_Tb);
            this.Controls.Add(this.hello_lb);
            this.Controls.Add(this.cre_lb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Show";
            this.Text = "Просмотр рецензий";
            this.Load += new System.EventHandler(this.Show_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cre_lb;
        private System.Windows.Forms.Label hello_lb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox desc_Tb;
        private System.Windows.Forms.DataGridView list_DGV;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}