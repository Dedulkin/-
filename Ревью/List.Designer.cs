namespace Ревью
{
    partial class List
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
            this.list_DGV = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.add_btn = new System.Windows.Forms.Button();
            this.review_btn = new System.Windows.Forms.Button();
            this.id_lb = new System.Windows.Forms.Label();
            this.search_tb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cat_Cb = new System.Windows.Forms.ComboBox();
            this.filtr_Cb = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.desc_Tb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.show_btn = new System.Windows.Forms.Button();
            this.del_btn = new System.Windows.Forms.Button();
            this.updt_btn = new System.Windows.Forms.Button();
            this.id_user_lb = new System.Windows.Forms.Label();
            this.cre_lb = new System.Windows.Forms.Label();
            this.creator_lb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.list_DGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // list_DGV
            // 
            this.list_DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.list_DGV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.list_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.list_DGV.Location = new System.Drawing.Point(12, 57);
            this.list_DGV.Name = "list_DGV";
            this.list_DGV.Size = new System.Drawing.Size(641, 319);
            this.list_DGV.TabIndex = 0;
            this.list_DGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.list_DGV_CellContentClick);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вот список доступных для оценивания произведений на данный момент: ";
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.add_btn.Location = new System.Drawing.Point(287, 382);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(129, 56);
            this.add_btn.TabIndex = 2;
            this.add_btn.Text = "Добавить произведение";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Visible = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // review_btn
            // 
            this.review_btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.review_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.review_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.review_btn.Location = new System.Drawing.Point(535, 382);
            this.review_btn.Name = "review_btn";
            this.review_btn.Size = new System.Drawing.Size(118, 56);
            this.review_btn.TabIndex = 3;
            this.review_btn.Text = "Написать рецензию";
            this.review_btn.UseVisualStyleBackColor = false;
            this.review_btn.Click += new System.EventHandler(this.review_btn_Click);
            // 
            // id_lb
            // 
            this.id_lb.AutoSize = true;
            this.id_lb.Location = new System.Drawing.Point(618, 14);
            this.id_lb.Name = "id_lb";
            this.id_lb.Size = new System.Drawing.Size(35, 13);
            this.id_lb.TabIndex = 4;
            this.id_lb.Text = "label2";
            this.id_lb.Visible = false;
            // 
            // search_tb
            // 
            this.search_tb.Location = new System.Drawing.Point(325, 31);
            this.search_tb.Name = "search_tb";
            this.search_tb.Size = new System.Drawing.Size(115, 20);
            this.search_tb.TabIndex = 5;
            this.search_tb.TextChanged += new System.EventHandler(this.search_tb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(322, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 6;
            this.label2.Text = "Поиск:";
            // 
            // cat_Cb
            // 
            this.cat_Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cat_Cb.FormattingEnabled = true;
            this.cat_Cb.Location = new System.Drawing.Point(446, 31);
            this.cat_Cb.Name = "cat_Cb";
            this.cat_Cb.Size = new System.Drawing.Size(103, 21);
            this.cat_Cb.TabIndex = 7;
            this.cat_Cb.SelectedIndexChanged += new System.EventHandler(this.cat_Cb_SelectedIndexChanged);
            // 
            // filtr_Cb
            // 
            this.filtr_Cb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtr_Cb.FormattingEnabled = true;
            this.filtr_Cb.Location = new System.Drawing.Point(555, 31);
            this.filtr_Cb.Name = "filtr_Cb";
            this.filtr_Cb.Size = new System.Drawing.Size(98, 21);
            this.filtr_Cb.TabIndex = 8;
            this.filtr_Cb.Visible = false;
            this.filtr_Cb.SelectedIndexChanged += new System.EventHandler(this.filtr_Cb_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(443, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Фильтровать по:";
            // 
            // desc_Tb
            // 
            this.desc_Tb.Location = new System.Drawing.Point(660, 57);
            this.desc_Tb.Multiline = true;
            this.desc_Tb.Name = "desc_Tb";
            this.desc_Tb.ReadOnly = true;
            this.desc_Tb.Size = new System.Drawing.Size(287, 381);
            this.desc_Tb.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(659, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Краткое описание:";
            // 
            // show_btn
            // 
            this.show_btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.show_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.show_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.show_btn.Location = new System.Drawing.Point(422, 382);
            this.show_btn.Name = "show_btn";
            this.show_btn.Size = new System.Drawing.Size(107, 56);
            this.show_btn.TabIndex = 12;
            this.show_btn.Text = "Показать рецензии";
            this.show_btn.UseVisualStyleBackColor = false;
            this.show_btn.Click += new System.EventHandler(this.show_btn_Click);
            // 
            // del_btn
            // 
            this.del_btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.del_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.del_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.del_btn.Location = new System.Drawing.Point(152, 382);
            this.del_btn.Name = "del_btn";
            this.del_btn.Size = new System.Drawing.Size(129, 56);
            this.del_btn.TabIndex = 13;
            this.del_btn.Text = "Удалить произведение";
            this.del_btn.UseVisualStyleBackColor = false;
            this.del_btn.Visible = false;
            this.del_btn.Click += new System.EventHandler(this.del_btn_Click);
            // 
            // updt_btn
            // 
            this.updt_btn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.updt_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.updt_btn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Bold);
            this.updt_btn.Location = new System.Drawing.Point(17, 382);
            this.updt_btn.Name = "updt_btn";
            this.updt_btn.Size = new System.Drawing.Size(129, 56);
            this.updt_btn.TabIndex = 14;
            this.updt_btn.Text = "Изменить произведение";
            this.updt_btn.UseVisualStyleBackColor = false;
            this.updt_btn.Visible = false;
            this.updt_btn.Click += new System.EventHandler(this.updt_btn_Click);
            // 
            // id_user_lb
            // 
            this.id_user_lb.AutoSize = true;
            this.id_user_lb.Location = new System.Drawing.Point(662, 15);
            this.id_user_lb.Name = "id_user_lb";
            this.id_user_lb.Size = new System.Drawing.Size(35, 13);
            this.id_user_lb.TabIndex = 15;
            this.id_user_lb.Text = "label5";
            this.id_user_lb.Visible = false;
            // 
            // cre_lb
            // 
            this.cre_lb.AutoSize = true;
            this.cre_lb.Location = new System.Drawing.Point(729, 11);
            this.cre_lb.Name = "cre_lb";
            this.cre_lb.Size = new System.Drawing.Size(35, 13);
            this.cre_lb.TabIndex = 16;
            this.cre_lb.Text = "label5";
            this.cre_lb.Visible = false;
            // 
            // creator_lb
            // 
            this.creator_lb.AutoSize = true;
            this.creator_lb.Location = new System.Drawing.Point(771, 10);
            this.creator_lb.Name = "creator_lb";
            this.creator_lb.Size = new System.Drawing.Size(35, 13);
            this.creator_lb.TabIndex = 17;
            this.creator_lb.Text = "label5";
            this.creator_lb.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Ревью.Properties.Resources.upd;
            this.pictureBox1.Location = new System.Drawing.Point(914, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 29);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(245)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(959, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.creator_lb);
            this.Controls.Add(this.cre_lb);
            this.Controls.Add(this.id_user_lb);
            this.Controls.Add(this.updt_btn);
            this.Controls.Add(this.del_btn);
            this.Controls.Add(this.show_btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.desc_Tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.filtr_Cb);
            this.Controls.Add(this.cat_Cb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.search_tb);
            this.Controls.Add(this.id_lb);
            this.Controls.Add(this.review_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.list_DGV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "List";
            this.Text = "List";
            this.Load += new System.EventHandler(this.List_Load);
            ((System.ComponentModel.ISupportInitialize)(this.list_DGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView list_DGV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button review_btn;
        private System.Windows.Forms.Label id_lb;
        private System.Windows.Forms.TextBox search_tb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cat_Cb;
        private System.Windows.Forms.ComboBox filtr_Cb;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox desc_Tb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button show_btn;
        private System.Windows.Forms.Button del_btn;
        private System.Windows.Forms.Button updt_btn;
        private System.Windows.Forms.Label id_user_lb;
        private System.Windows.Forms.Label cre_lb;
        private System.Windows.Forms.Label creator_lb;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}