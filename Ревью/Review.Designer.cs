namespace Ревью
{
    partial class Review
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
            this.label1 = new System.Windows.Forms.Label();
            this.list_DGV = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.id_lb = new System.Windows.Forms.Label();
            this.desc_Tb = new System.Windows.Forms.TextBox();
            this.rate_lb = new System.Windows.Forms.Label();
            this.del_btn = new System.Windows.Forms.Button();
            this.updt_btn = new System.Windows.Forms.Button();
            this.help_lb = new System.Windows.Forms.Label();
            this.sum_lb = new System.Windows.Forms.Label();
            this.idcre_lb = new System.Windows.Forms.Label();
            this.count_lb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.list_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Вот список произведений на\r\nкоторые вы писали рецензии:";
            // 
            // list_DGV
            // 
            this.list_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_DGV.Location = new System.Drawing.Point(17, 58);
            this.list_DGV.Name = "list_DGV";
            this.list_DGV.Size = new System.Drawing.Size(337, 380);
            this.list_DGV.TabIndex = 1;
            this.list_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_DGV_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(395, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ваша оценка:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(395, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ваша рецензия:";
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Location = new System.Drawing.Point(912, 9);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(35, 13);
            this.id_lb.TabIndex = 4;
            this.id_lb.Text = "label4";
            this.id_lb.Visible = false;
            // 
            // desc_Tb
            // 
            this.desc_Tb.Location = new System.Drawing.Point(399, 70);
            this.desc_Tb.Multiline = true;
            this.desc_Tb.Name = "desc_Tb";
            this.desc_Tb.ReadOnly = true;
            this.desc_Tb.Size = new System.Drawing.Size(548, 368);
            this.desc_Tb.TabIndex = 5;
            // 
            // rate_lb
            // 
            this.rate_lb.AutoSize = true;
            this.rate_lb.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.rate_lb.Location = new System.Drawing.Point(505, 22);
            this.rate_lb.Name = "rate_lb";
            this.rate_lb.Size = new System.Drawing.Size(18, 21);
            this.rate_lb.TabIndex = 6;
            this.rate_lb.Text = "0";
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.del_btn.Location = new System.Drawing.Point(686, 4);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(161, 30);
            this.del_btn.TabIndex = 7;
            this.del_btn.Text = "Удалить  рецензию";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // updt_btn
            // 
            this.updt_btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.updt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updt_btn.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.updt_btn.Location = new System.Drawing.Point(686, 34);
            this.updt_btn.Name = "updt_btn";
            this.updt_btn.Size = new System.Drawing.Size(161, 30);
            this.updt_btn.TabIndex = 8;
            this.updt_btn.Text = "Изменить  рецензию";
            this.updt_btn.UseVisualStyleBackColor = false;
            this.updt_btn.Click += new System.EventHandler(this.updt_btn_Click);
            // 
            // help_lb
            // 
            this.help_lb.AutoSize = true;
            this.help_lb.Location = new System.Drawing.Point(588, 9);
            this.help_lb.Name = "help_lb";
            this.help_lb.Size = new System.Drawing.Size(35, 13);
            this.help_lb.TabIndex = 9;
            this.help_lb.Text = "label4";
            this.help_lb.Visible = false;
            // 
            // sum_lb
            // 
            this.sum_lb.AutoSize = true;
            this.sum_lb.Location = new System.Drawing.Point(588, 27);
            this.sum_lb.Name = "sum_lb";
            this.sum_lb.Size = new System.Drawing.Size(35, 13);
            this.sum_lb.TabIndex = 11;
            this.sum_lb.Text = "label4";
            this.sum_lb.Visible = false;
            // 
            // idcre_lb
            // 
            this.idcre_lb.AutoSize = true;
            this.idcre_lb.Location = new System.Drawing.Point(591, 40);
            this.idcre_lb.Name = "idcre_lb";
            this.idcre_lb.Size = new System.Drawing.Size(35, 13);
            this.idcre_lb.TabIndex = 12;
            this.idcre_lb.Text = "label4";
            this.idcre_lb.Visible = false;
            // 
            // count_lb
            // 
            this.count_lb.AutoSize = true;
            this.count_lb.Location = new System.Drawing.Point(591, 51);
            this.count_lb.Name = "count_lb";
            this.count_lb.Size = new System.Drawing.Size(35, 13);
            this.count_lb.TabIndex = 13;
            this.count_lb.Text = "label4";
            this.count_lb.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ревью.Properties.Resources.upd;
            this.pictureBox1.Location = new System.Drawing.Point(914, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(245)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.count_lb);
            this.Controls.Add(this.idcre_lb);
            this.Controls.Add(this.sum_lb);
            this.Controls.Add(this.help_lb);
            this.Controls.Add(this.updt_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.rate_lb);
            this.Controls.Add(this.desc_Tb);
            this.Controls.Add(this.id_lb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.list_DGV);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Review";
            this.Text = "Review";
            this.Load += new System.EventHandler(this.Review_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView list_DGV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label id_lb;
        private System.Windows.Forms.TextBox desc_Tb;
        private System.Windows.Forms.Label rate_lb;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button updt_btn;
        private System.Windows.Forms.Label help_lb;
        private System.Windows.Forms.Label sum_lb;
        private System.Windows.Forms.Label idcre_lb;
        private System.Windows.Forms.Label count_lb;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}