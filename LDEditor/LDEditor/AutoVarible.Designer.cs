namespace LDEditor
{
    partial class AutoVarible
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
            this.labelNameVar = new System.Windows.Forms.Label();
            this.labelTypeVar = new System.Windows.Forms.Label();
            this.labelCommentVar = new System.Windows.Forms.Label();
            this.textBoxNameVar = new System.Windows.Forms.TextBox();
            this.textBoxCommentVar = new System.Windows.Forms.TextBox();
            this.cbTypeVar = new System.Windows.Forms.ComboBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNameVar
            // 
            this.labelNameVar.AutoSize = true;
            this.labelNameVar.Location = new System.Drawing.Point(34, 30);
            this.labelNameVar.Name = "labelNameVar";
            this.labelNameVar.Size = new System.Drawing.Size(94, 13);
            this.labelNameVar.TabIndex = 0;
            this.labelNameVar.Text = "Имя переменной";
            // 
            // labelTypeVar
            // 
            this.labelTypeVar.AutoSize = true;
            this.labelTypeVar.Location = new System.Drawing.Point(202, 30);
            this.labelTypeVar.Name = "labelTypeVar";
            this.labelTypeVar.Size = new System.Drawing.Size(91, 13);
            this.labelTypeVar.TabIndex = 1;
            this.labelTypeVar.Text = "Тип переменной";
            // 
            // labelCommentVar
            // 
            this.labelCommentVar.AutoSize = true;
            this.labelCommentVar.Location = new System.Drawing.Point(369, 30);
            this.labelCommentVar.Name = "labelCommentVar";
            this.labelCommentVar.Size = new System.Drawing.Size(83, 13);
            this.labelCommentVar.TabIndex = 2;
            this.labelCommentVar.Text = "Комментрарий";
            // 
            // textBoxNameVar
            // 
            this.textBoxNameVar.Location = new System.Drawing.Point(12, 54);
            this.textBoxNameVar.Name = "textBoxNameVar";
            this.textBoxNameVar.Size = new System.Drawing.Size(143, 20);
            this.textBoxNameVar.TabIndex = 3;
            this.textBoxNameVar.TextChanged += new System.EventHandler(this.textBoxNameVar_TextChanged);
            // 
            // textBoxCommentVar
            // 
            this.textBoxCommentVar.Location = new System.Drawing.Point(338, 54);
            this.textBoxCommentVar.Name = "textBoxCommentVar";
            this.textBoxCommentVar.Size = new System.Drawing.Size(143, 20);
            this.textBoxCommentVar.TabIndex = 5;
            // 
            // cbTypeVar
            // 
            this.cbTypeVar.FormattingEnabled = true;
            this.cbTypeVar.Items.AddRange(new object[] {
            "Bool",
            "String"});
            this.cbTypeVar.Location = new System.Drawing.Point(179, 53);
            this.cbTypeVar.Name = "cbTypeVar";
            this.cbTypeVar.Size = new System.Drawing.Size(136, 21);
            this.cbTypeVar.TabIndex = 6;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(372, 105);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(37, 105);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // AutoVarible
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 140);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.cbTypeVar);
            this.Controls.Add(this.textBoxCommentVar);
            this.Controls.Add(this.textBoxNameVar);
            this.Controls.Add(this.labelCommentVar);
            this.Controls.Add(this.labelTypeVar);
            this.Controls.Add(this.labelNameVar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AutoVarible";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AutoVarible";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelNameVar;
        private System.Windows.Forms.Label labelTypeVar;
        private System.Windows.Forms.Label labelCommentVar;
        private System.Windows.Forms.TextBox textBoxNameVar;
        private System.Windows.Forms.TextBox textBoxCommentVar;
        private System.Windows.Forms.ComboBox cbTypeVar;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}