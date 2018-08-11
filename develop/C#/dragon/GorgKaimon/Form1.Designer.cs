namespace GorgKaimon
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.start_button = new System.Windows.Forms.Button();
            this.add_but = new System.Windows.Forms.Button();
            this.remov_but = new System.Windows.Forms.Button();
            this.tcp_enable = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.build_but = new System.Windows.Forms.Button();
            this.console_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(107, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(207, 293);
            this.panel1.TabIndex = 0;
            // 
            // start_button
            // 
            this.start_button.Location = new System.Drawing.Point(1, 9);
            this.start_button.Name = "start_button";
            this.start_button.Size = new System.Drawing.Size(54, 23);
            this.start_button.TabIndex = 1;
            this.start_button.Text = "Start";
            this.start_button.UseVisualStyleBackColor = true;
            // 
            // add_but
            // 
            this.add_but.Location = new System.Drawing.Point(1, 38);
            this.add_but.Name = "add_but";
            this.add_but.Size = new System.Drawing.Size(54, 23);
            this.add_but.TabIndex = 2;
            this.add_but.Text = "Add";
            this.add_but.UseVisualStyleBackColor = true;
            // 
            // remov_but
            // 
            this.remov_but.Location = new System.Drawing.Point(1, 95);
            this.remov_but.Name = "remov_but";
            this.remov_but.Size = new System.Drawing.Size(54, 23);
            this.remov_but.TabIndex = 3;
            this.remov_but.Text = "Remove";
            this.remov_but.UseVisualStyleBackColor = true;
            // 
            // tcp_enable
            // 
            this.tcp_enable.AutoSize = true;
            this.tcp_enable.Location = new System.Drawing.Point(1, 136);
            this.tcp_enable.Name = "tcp_enable";
            this.tcp_enable.Size = new System.Drawing.Size(47, 17);
            this.tcp_enable.TabIndex = 4;
            this.tcp_enable.Text = "TCP";
            this.tcp_enable.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 5;
            // 
            // build_but
            // 
            this.build_but.Location = new System.Drawing.Point(1, 237);
            this.build_but.Name = "build_but";
            this.build_but.Size = new System.Drawing.Size(54, 23);
            this.build_but.TabIndex = 6;
            this.build_but.Text = "Build";
            this.build_but.UseVisualStyleBackColor = true;
            this.build_but.Click += new System.EventHandler(this.build_but_Click);
            // 
            // console_button
            // 
            this.console_button.Location = new System.Drawing.Point(1, 208);
            this.console_button.Name = "console_button";
            this.console_button.Size = new System.Drawing.Size(54, 23);
            this.console_button.TabIndex = 7;
            this.console_button.Text = "Console";
            this.console_button.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(313, 291);
            this.Controls.Add(this.console_button);
            this.Controls.Add(this.build_but);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.tcp_enable);
            this.Controls.Add(this.remov_but);
            this.Controls.Add(this.add_but);
            this.Controls.Add(this.start_button);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button start_button;
        private System.Windows.Forms.Button add_but;
        private System.Windows.Forms.Button remov_but;
        private System.Windows.Forms.CheckBox tcp_enable;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button build_but;
        private System.Windows.Forms.Button console_button;
    }
}

