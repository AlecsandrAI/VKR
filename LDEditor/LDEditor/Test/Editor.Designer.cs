using System;
using System.Drawing;
using System.Windows.Forms;

namespace LDEditor
{
    
    partial class frmEditor
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
            this.sPEditor = new System.Windows.Forms.SplitContainer();
            this.dgvVarible = new System.Windows.Forms.DataGridView();
            this.workspace = new WFControlLibrary.Workspace();
            this.network1 = new WFControlLibrary.Network();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.sPEditor)).BeginInit();
            this.sPEditor.Panel1.SuspendLayout();
            this.sPEditor.Panel2.SuspendLayout();
            this.sPEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarible)).BeginInit();
            this.SuspendLayout();
            // 
            // sPEditor
            // 
            this.sPEditor.AllowDrop = true;
            this.sPEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sPEditor.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sPEditor.Location = new System.Drawing.Point(0, 0);
            this.sPEditor.Margin = new System.Windows.Forms.Padding(0);
            this.sPEditor.Name = "sPEditor";
            this.sPEditor.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sPEditor.Panel1
            // 
            this.sPEditor.Panel1.AllowDrop = true;
            this.sPEditor.Panel1.AutoScroll = true;
            this.sPEditor.Panel1.Controls.Add(this.dgvVarible);
            // 
            // sPEditor.Panel2
            // 
            this.sPEditor.Panel2.AllowDrop = true;
            this.sPEditor.Panel2.AutoScroll = true;
            this.sPEditor.Panel2.Controls.Add(this.button2);
            this.sPEditor.Panel2.Controls.Add(this.button1);
            this.sPEditor.Panel2.Controls.Add(this.workspace);
            this.sPEditor.Size = new System.Drawing.Size(1021, 455);
            this.sPEditor.SplitterDistance = 144;
            this.sPEditor.SplitterWidth = 8;
            this.sPEditor.TabIndex = 0;
            // 
            // dgvVarible
            // 
            this.dgvVarible.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVarible.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVarible.Location = new System.Drawing.Point(0, 0);
            this.dgvVarible.Name = "dgvVarible";
            this.dgvVarible.Size = new System.Drawing.Size(1021, 144);
            this.dgvVarible.TabIndex = 0;
            // 
            // workspace
            // 
            this.workspace.AllowDrop = true;
            this.workspace.AutoScroll = true;
            this.workspace.AutoSize = true;
            this.workspace.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.workspace.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.workspace.Dock = System.Windows.Forms.DockStyle.Top;
            this.workspace.Location = new System.Drawing.Point(0, 0);
            this.workspace.Margin = new System.Windows.Forms.Padding(0);
            this.workspace.MinimumSize = new System.Drawing.Size(200, 100);
            this.workspace.Name = "workspace";
            this.workspace.Size = new System.Drawing.Size(1021, 152);
            this.workspace.TabIndex = 0;
            // 
            // network1
            // 
            this.network1.AllowDrop = true;
            this.network1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.network1.Location = new System.Drawing.Point(3, 3);
            this.network1.Margin = new System.Windows.Forms.Padding(0);
            this.network1.Name = "network1";
            this.network1.Size = new System.Drawing.Size(1000, 50);
            this.network1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(49, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(190, 257);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // frmEditor
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1021, 455);
            this.Controls.Add(this.sPEditor);
            this.Name = "frmEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmEditor_FormClosing);
            this.Load += new System.EventHandler(this.frmEditor_Load);
            this.sPEditor.Panel1.ResumeLayout(false);
            this.sPEditor.Panel2.ResumeLayout(false);
            this.sPEditor.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sPEditor)).EndInit();
            this.sPEditor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarible)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public WFControlLibrary.Network network1;
        public SplitContainer sPEditor;
        private DataGridView dgvVarible;
        private Button button1;
        public WFControlLibrary.Workspace workspace;
        private Button button2;
    }
}