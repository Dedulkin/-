namespace Ревью
{
    partial class Add_cre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Add_cre));
            this.label1 = new System.Windows.Forms.Label();
            this.fio_Tb = new System.Windows.Forms.TextBox();
            this.desc_Tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.type_Cb = new System.Windows.Forms.ComboBox();
            this.auth_Cb = new System.Windows.Forms.ComboBox();
            this.lb = new System.Windows.Forms.Label();
            this.auth_lb = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.auth_Tb = new System.Windows.Forms.TextBox();
            this.genre_List = new System.Windows.Forms.CheckedListBox();
            this.genre_lb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(196, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название произведения:";
            // 
            // fio_Tb
            // 
            this.fio_Tb.Location = new System.Drawing.Point(12, 42);
            this.fio_Tb.Name = "fio_Tb";
            this.fio_Tb.Size = new System.Drawing.Size(290, 20);
            this.fio_Tb.TabIndex = 1;
            // 
            // desc_Tb
            // 
            this.desc_Tb.Location = new System.Drawing.Point(344, 42);
            this.desc_Tb.Multiline = true;
            this.desc_Tb.Name = "desc_Tb";
            this.desc_Tb.Size = new System.Drawing.Size(355, 313);
            this.desc_Tb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(344, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Краткое описание произведения:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(12, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 21);
            this.label3.TabIndex = 4;
            this.label3.Text = "Тип произведения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(12, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(172, 21);
            this.label4.TabIndex = 5;
            this.label4.Text = "Автор произведения:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(12, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 21);
            this.label5.TabIndex = 6;
            this.label5.Text = "Жанр/ы произведения:";
            // 
            // type_Cb
            // 
            this.type_Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_Cb.FormattingEnabled = true;
            this.type_Cb.Location = new System.Drawing.Point(12, 101);
            this.type_Cb.Name = "type_Cb";
            this.type_Cb.Size = new System.Drawing.Size(151, 21);
            this.type_Cb.TabIndex = 7;
            // 
            // auth_Cb
            // 
            this.auth_Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.auth_Cb.FormattingEnabled = true;
            this.auth_Cb.Location = new System.Drawing.Point(12, 149);
            this.auth_Cb.Name = "auth_Cb";
            this.auth_Cb.Size = new System.Drawing.Size(201, 21);
            this.auth_Cb.TabIndex = 8;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.lb.Location = new System.Drawing.Point(12, 173);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(151, 21);
            this.lb.TabIndex = 9;
            this.lb.Text = "Не нашли автора? ";
            // 
            // auth_lb
            // 
            this.auth_lb.AutoSize = true;
            this.auth_lb.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.auth_lb.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.auth_lb.Location = new System.Drawing.Point(151, 173);
            this.auth_lb.Name = "auth_lb";
            this.auth_lb.Size = new System.Drawing.Size(84, 21);
            this.auth_lb.TabIndex = 10;
            this.auth_lb.Text = "Добавьте!";
            this.auth_lb.Click += new System.EventHandler(this.auth_lb_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.add_btn.Location = new System.Drawing.Point(570, 382);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(129, 56);
            this.add_btn.TabIndex = 11;
            this.add_btn.Text = "Сохранить произведение";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // auth_Tb
            // 
            this.auth_Tb.Location = new System.Drawing.Point(12, 150);
            this.auth_Tb.Name = "auth_Tb";
            this.auth_Tb.Size = new System.Drawing.Size(201, 20);
            this.auth_Tb.TabIndex = 12;
            this.auth_Tb.Visible = false;
            // 
            // genre_List
            // 
            this.genre_List.CheckOnClick = true;
            this.genre_List.FormattingEnabled = true;
            this.genre_List.Location = new System.Drawing.Point(16, 230);
            this.genre_List.Name = "genre_List";
            this.genre_List.Size = new System.Drawing.Size(286, 199);
            this.genre_List.TabIndex = 13;
            // 
            // genre_lb
            // 
            this.genre_lb.AutoSize = true;
            this.genre_lb.Location = new System.Drawing.Point(345, 382);
            this.genre_lb.Name = "genre_lb";
            this.genre_lb.Size = new System.Drawing.Size(0, 13);
            this.genre_lb.TabIndex = 14;
            this.genre_lb.Visible = false;
            // 
            // Add_cre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(245)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.genre_lb);
            this.Controls.Add(this.genre_List);
            this.Controls.Add(this.auth_Tb);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.auth_lb);
            this.Controls.Add(this.lb);
            this.Controls.Add(this.auth_Cb);
            this.Controls.Add(this.type_Cb);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.desc_Tb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fio_Tb);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Add_cre";
            this.Text = "Добавить произведение";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox fio_Tb;
        private System.Windows.Forms.TextBox desc_Tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox type_Cb;
        private System.Windows.Forms.ComboBox auth_Cb;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label auth_lb;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.TextBox auth_Tb;
        private System.Windows.Forms.CheckedListBox genre_List;
        private System.Windows.Forms.Label genre_lb;
    }
}