namespace Ревью
{
    partial class Auth0
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Auth0));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bck_lb = new System.Windows.Forms.Label();
            this.reg_lb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 261);
            this.panel1.TabIndex = 0;
            // 
            // bck_lb
            // 
            this.bck_lb.AutoSize = true;
            this.bck_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.bck_lb.ForeColor = System.Drawing.Color.Blue;
            this.bck_lb.Location = new System.Drawing.Point(166, 284);
            this.bck_lb.Name = "bck_lb";
            this.bck_lb.Size = new System.Drawing.Size(93, 13);
            this.bck_lb.TabIndex = 19;
            this.bck_lb.Text = "Вернуться назад";
            this.bck_lb.Visible = false;
            this.bck_lb.Click += new System.EventHandler(this.bck_lb_Click);
            // 
            // reg_lb
            // 
            this.reg_lb.AutoSize = true;
            this.reg_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.reg_lb.ForeColor = System.Drawing.Color.Blue;
            this.reg_lb.Location = new System.Drawing.Point(200, 284);
            this.reg_lb.Name = "reg_lb";
            this.reg_lb.Size = new System.Drawing.Size(109, 13);
            this.reg_lb.TabIndex = 18;
            this.reg_lb.Text = "Зарегистрируйтесь!";
            this.reg_lb.Click += new System.EventHandler(this.reg_lb_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(112, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Нет аккаунта?";
            // 
            // Auth0
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(213)))), ((int)(((byte)(245)))), ((int)(((byte)(209)))));
            this.ClientSize = new System.Drawing.Size(434, 315);
            this.Controls.Add(this.bck_lb);
            this.Controls.Add(this.reg_lb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(450, 354);
            this.MinimumSize = new System.Drawing.Size(450, 354);
            this.Name = "Auth0";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Auth0_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bck_lb;
        private System.Windows.Forms.Label reg_lb;
        private System.Windows.Forms.Label label3;
    }
}

