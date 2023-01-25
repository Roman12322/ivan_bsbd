namespace kostya
{
    partial class Form1
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
            this.sign_in = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.phone_box = new System.Windows.Forms.TextBox();
            this.passport_box = new System.Windows.Forms.TextBox();
            this.status_box = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // sign_in
            // 
            this.sign_in.Location = new System.Drawing.Point(170, 110);
            this.sign_in.Name = "sign_in";
            this.sign_in.Size = new System.Drawing.Size(75, 23);
            this.sign_in.TabIndex = 0;
            this.sign_in.Text = "sign in";
            this.sign_in.UseVisualStyleBackColor = true;
            this.sign_in.Click += new System.EventHandler(this.sign_in_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "phone";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "passport";
            // 
            // phone_box
            // 
            this.phone_box.Location = new System.Drawing.Point(89, 18);
            this.phone_box.Name = "phone_box";
            this.phone_box.Size = new System.Drawing.Size(156, 20);
            this.phone_box.TabIndex = 3;
            // 
            // passport_box
            // 
            this.passport_box.Location = new System.Drawing.Point(89, 65);
            this.passport_box.Name = "passport_box";
            this.passport_box.PasswordChar = '*';
            this.passport_box.Size = new System.Drawing.Size(156, 20);
            this.passport_box.TabIndex = 4;
            this.passport_box.UseSystemPasswordChar = true;
            // 
            // status_box
            // 
            this.status_box.FormattingEnabled = true;
            this.status_box.Items.AddRange(new object[] {
            "admin",
            "customer"});
            this.status_box.Location = new System.Drawing.Point(15, 112);
            this.status_box.Name = "status_box";
            this.status_box.Size = new System.Drawing.Size(121, 21);
            this.status_box.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(271, 153);
            this.Controls.Add(this.status_box);
            this.Controls.Add(this.passport_box);
            this.Controls.Add(this.phone_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.sign_in);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sign_in;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox phone_box;
        private System.Windows.Forms.TextBox passport_box;
        private System.Windows.Forms.ComboBox status_box;
    }
}

