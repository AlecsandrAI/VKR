﻿namespace LDEditor
{
    partial class Main
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
            this.button1 = new System.Windows.Forms.Button();
            this.LDlabel1 = new System.Windows.Forms.Label();
            this.CHKok1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 33);
            this.button1.TabIndex = 0;
            this.button1.Text = "Файл";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LDlabel1
            // 
            this.LDlabel1.AutoSize = true;
            this.LDlabel1.Location = new System.Drawing.Point(245, 113);
            this.LDlabel1.Name = "LDlabel1";
            this.LDlabel1.Size = new System.Drawing.Size(25, 13);
            this.LDlabel1.TabIndex = 1;
            this.LDlabel1.Text = "GIT";
            this.LDlabel1.Click += new System.EventHandler(this.LDlabel1_Click);
            // 
            // CHKok1
            // 
            this.CHKok1.AutoSize = true;
            this.CHKok1.Location = new System.Drawing.Point(421, 138);
            this.CHKok1.Name = "CHKok1";
            this.CHKok1.Size = new System.Drawing.Size(64, 17);
            this.CHKok1.TabIndex = 2;
            this.CHKok1.Text = "Готово!";
            this.CHKok1.UseVisualStyleBackColor = false;
            this.CHKok1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CHKok1);
            this.Controls.Add(this.LDlabel1);
            this.Controls.Add(this.button1);
            this.Name = "Main";
            this.Text = "LDEditor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label LDlabel1;
        private System.Windows.Forms.CheckBox CHKok1;
    }
}

