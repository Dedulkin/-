namespace Ревью
{
    partial class UpdtRev
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdtRev));
            this.id_lb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rate_Num = new System.Windows.Forms.NumericUpDown();
            this.save_btn = new System.Windows.Forms.Button();
            this.desc_Tb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.name_lb = new System.Windows.Forms.Label();
            this.count_lb = new System.Windows.Forms.Label();
            this.idcre_lb = new System.Windows.Forms.Label();
            this.sum_lb = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rate_Num)).BeginInit();
            this.SuspendLayout();
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Location = new System.Drawing.Point(369, 15);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(35, 13);
            this.id_lb.TabIndex = 17;
            this.id_lb.Text = "label5";
            this.id_lb.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(222, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "Максимальное кол-во символов 1000.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(14, 402);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(266, 21);
            this.label3.TabIndex = 15;
            this.label3.Text = "Оцените произведение от 1 до 10:\r\n";
            // 
            // rate_Num
            // 
            this.rate_Num.Location = new System.Drawing.Point(286, 403);
            this.rate_Num.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.rate_Num.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.rate_Num.Name = "rate_Num";
            this.rate_Num.Size = new System.Drawing.Size(38, 20);
            this.rate_Num.TabIndex = 14;
            this.rate_Num.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // save_btn
            // 
            this.save_btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.save_btn.Location = new System.Drawing.Point(439, 384);
            this.save_btn.Name = "save_btn";
            this.save_btn.Size = new System.Drawing.Size(129, 56);
            this.save_btn.TabIndex = 13;
            this.save_btn.Text = "Сохранить изменения";
            this.save_btn.UseVisualStyleBackColor = false;
            this.save_btn.Click += new System.EventHandler(this.save_btn_Click);
            // 
            // desc_Tb
            // 
            this.desc_Tb.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.desc_Tb.Location = new System.Drawing.Point(11, 52);
            this.desc_Tb.MaxLength = 1000;
            this.desc_Tb.Multiline = true;
            this.desc_Tb.Name = "desc_Tb";
            this.desc_Tb.Size = new System.Drawing.Size(557, 326);
            this.desc_Tb.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "Вы пишите рецензию на:";
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.name_lb.Location = new System.Drawing.Point(208, 11);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(52, 21);
            this.name_lb.TabIndex = 9;
            this.name_lb.Text = "label1";
            // 
            // count_lb
            // 
            this.count_lb.AutoSize = true;
            this.count_lb.Location = new System.Drawing.Point(514, 35);
            this.count_lb.Name = "count_lb";
            this.count_lb.Size = new System.Drawing.Size(35, 13);
            this.count_lb.TabIndex = 20;
            this.count_lb.Text = "label4";
            this.count_lb.Visible = false;
            // 
            // idcre_lb
            // 
            this.idcre_lb.AutoSize = true;
            this.idcre_lb.Location = new System.Drawing.Point(514, 24);
            this.idcre_lb.Name = "idcre_lb";
            this.idcre_lb.Size = new System.Drawing.Size(35, 13);
            this.idcre_lb.TabIndex = 19;
            this.idcre_lb.Text = "label4";
            this.idcre_lb.Visible = false;
            // 
            // sum_lb
            // 
            this.sum_lb.AutoSize = true;
            this.sum_lb.Location = new System.Drawing.Point(511, 11);
            this.sum_lb.Name = "sum_lb";
            this.sum_lb.Size = new System.Drawing.Size(35, 13);
            this.sum_lb.TabIndex = 18;
            this.sum_lb.Text = "label4";
            this.sum_lb.Visible = false;
            // 
            // UpdtRev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(245)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(578, 450);
            this.Controls.Add(this.count_lb);
            this.Controls.Add(this.idcre_lb);
            this.Controls.Add(this.sum_lb);
            this.Controls.Add(this.id_lb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rate_Num);
            this.Controls.Add(this.save_btn);
            this.Controls.Add(this.desc_Tb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.name_lb);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdtRev";
            this.Text = "Введите изменения";
            ((System.ComponentModel.ISupportInitialize)(this.rate_Num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_lb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown rate_Num;
        private System.Windows.Forms.Button save_btn;
        private System.Windows.Forms.TextBox desc_Tb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label count_lb;
        private System.Windows.Forms.Label idcre_lb;
        private System.Windows.Forms.Label sum_lb;
    }
}