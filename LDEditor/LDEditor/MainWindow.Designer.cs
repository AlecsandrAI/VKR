using System;
using System.Drawing;
using System.Windows.Forms;

namespace LDEditor
{
    partial class frmMain
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Программа 1");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("POU", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.sc3 = new System.Windows.Forms.SplitContainer();
            this.tcPOU = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dgvVarTable = new System.Windows.Forms.DataGridView();
            this.NameVar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeVar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CommentVar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tLPEditor = new System.Windows.Forms.TableLayoutPanel();
            this.newNetwork1 = new WFControlLibrary.NewNetwork();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.tSPanelEdit = new System.Windows.Forms.ToolStrip();
            this.tbtnAddContact = new System.Windows.Forms.ToolStripButton();
            this.tbtnAddInvContact = new System.Windows.Forms.ToolStripButton();
            this.tbtnAddCoil = new System.Windows.Forms.ToolStripButton();
            this.tbtnAddInvCoil = new System.Windows.Forms.ToolStripButton();
            this.tbtnAddSetCoil = new System.Windows.Forms.ToolStripButton();
            this.tbtnAddResetCoil = new System.Windows.Forms.ToolStripButton();
            this.tbtnAddFPContact = new System.Windows.Forms.ToolStripButton();
            this.tbtnAddFNContact = new System.Windows.Forms.ToolStripButton();
            this.tsbAddLineVert = new System.Windows.Forms.ToolStripButton();
            this.btnAddLine = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tbtnAddNetwork = new System.Windows.Forms.ToolStripButton();
            this.tsiDelete = new System.Windows.Forms.ToolStripButton();
            this.tsbDeleteLineHoriz = new System.Windows.Forms.ToolStripButton();
            this.tsnDeleteLineVert = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbJump = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.создатьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.открытьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.сохранитьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.вырезатьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.копироватьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.вставкаToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.справкаToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton12 = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитькакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.выделитьвсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.масштабToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPOU = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.опрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStdLD = new System.Windows.Forms.MenuStrip();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc3)).BeginInit();
            this.sc3.Panel1.SuspendLayout();
            this.sc3.Panel2.SuspendLayout();
            this.sc3.SuspendLayout();
            this.tcPOU.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarTable)).BeginInit();
            this.tLPEditor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.tSPanelEdit.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.menuStdLD.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 644);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1060, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Enabled = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel2.Text = "СОСТОЯНИЕ";
            // 
            // sc3
            // 
            this.sc3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc3.Location = new System.Drawing.Point(0, 0);
            this.sc3.Name = "sc3";
            // 
            // sc3.Panel1
            // 
            this.sc3.Panel1.Controls.Add(this.tcPOU);
            // 
            // sc3.Panel2
            // 
            this.sc3.Panel2.Controls.Add(this.splitContainer1);
            this.sc3.Size = new System.Drawing.Size(1060, 566);
            this.sc3.SplitterDistance = 292;
            this.sc3.TabIndex = 9;
            // 
            // tcPOU
            // 
            this.tcPOU.Controls.Add(this.tabPage2);
            this.tcPOU.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcPOU.Location = new System.Drawing.Point(0, 0);
            this.tcPOU.Name = "tcPOU";
            this.tcPOU.SelectedIndex = 0;
            this.tcPOU.Size = new System.Drawing.Size(292, 566);
            this.tcPOU.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.treeView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(284, 540);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "POU";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Programm 1";
            treeNode1.Text = "Программа 1";
            treeNode2.Name = "POU";
            treeNode2.Text = "POU";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.treeView1.Size = new System.Drawing.Size(278, 534);
            this.treeView1.TabIndex = 0;
            // 
            // splitContainer1
            // 
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvVarTable);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AllowDrop = true;
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.tLPEditor);
            this.splitContainer1.Size = new System.Drawing.Size(764, 566);
            this.splitContainer1.SplitterDistance = 96;
            this.splitContainer1.TabIndex = 0;
            // 
            // dgvVarTable
            // 
            this.dgvVarTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVarTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVarTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameVar,
            this.TypeVar,
            this.CommentVar});
            this.dgvVarTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvVarTable.Location = new System.Drawing.Point(0, 0);
            this.dgvVarTable.Margin = new System.Windows.Forms.Padding(0);
            this.dgvVarTable.MultiSelect = false;
            this.dgvVarTable.Name = "dgvVarTable";
            this.dgvVarTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dgvVarTable.Size = new System.Drawing.Size(764, 96);
            this.dgvVarTable.StandardTab = true;
            this.dgvVarTable.TabIndex = 0;
            this.dgvVarTable.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvVarTable_RowsAdded);
            // 
            // NameVar
            // 
            this.NameVar.HeaderText = "Name";
            this.NameVar.Name = "NameVar";
            // 
            // TypeVar
            // 
            this.TypeVar.HeaderText = "Type";
            this.TypeVar.Name = "TypeVar";
            // 
            // CommentVar
            // 
            this.CommentVar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CommentVar.HeaderText = "Comment";
            this.CommentVar.Name = "CommentVar";
            // 
            // tLPEditor
            // 
            this.tLPEditor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tLPEditor.AutoScroll = true;
            this.tLPEditor.AutoSize = true;
            this.tLPEditor.ColumnCount = 1;
            this.tLPEditor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tLPEditor.Controls.Add(this.newNetwork1, 0, 0);
            this.tLPEditor.Location = new System.Drawing.Point(0, 0);
            this.tLPEditor.Margin = new System.Windows.Forms.Padding(0);
            this.tLPEditor.Name = "tLPEditor";
            this.tLPEditor.Padding = new System.Windows.Forms.Padding(4);
            this.tLPEditor.RowCount = 2;
            this.tLPEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tLPEditor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.tLPEditor.Size = new System.Drawing.Size(1096, 313);
            this.tLPEditor.TabIndex = 0;
            this.tLPEditor.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.tLPEditor_ControlAdded);
            this.tLPEditor.Paint += new System.Windows.Forms.PaintEventHandler(this.tLPEditor_Paint);
            // 
            // newNetwork1
            // 
            this.newNetwork1.AllowDrop = true;
            this.newNetwork1.AutoScroll = true;
            this.newNetwork1.AutoSize = true;
            this.newNetwork1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.newNetwork1.Dock = System.Windows.Forms.DockStyle.Top;
            this.newNetwork1.Location = new System.Drawing.Point(4, 4);
            this.newNetwork1.Margin = new System.Windows.Forms.Padding(0);
            this.newNetwork1.MinimumSize = new System.Drawing.Size(600, 50);
            this.newNetwork1.Name = "newNetwork1";
            this.newNetwork1.Size = new System.Drawing.Size(1088, 50);
            this.newNetwork1.TabIndex = 0;
            this.newNetwork1.Load += new System.EventHandler(this.newNetwork1_Load);
            this.newNetwork1.Click += new System.EventHandler(this.newNetwork1_Click);
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(0, 49);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            this.splitContainer4.Panel1.Controls.Add(this.tSPanelEdit);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.sc3);
            this.splitContainer4.Size = new System.Drawing.Size(1060, 595);
            this.splitContainer4.SplitterDistance = 25;
            this.splitContainer4.TabIndex = 10;
            // 
            // tSPanelEdit
            // 
            this.tSPanelEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tSPanelEdit.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.tSPanelEdit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnAddContact,
            this.tbtnAddInvContact,
            this.tbtnAddCoil,
            this.tbtnAddInvCoil,
            this.tbtnAddSetCoil,
            this.tbtnAddResetCoil,
            this.tbtnAddFPContact,
            this.tbtnAddFNContact,
            this.tsbAddLineVert,
            this.btnAddLine,
            this.toolStripButton2,
            this.toolStripSeparator8,
            this.tbtnAddNetwork,
            this.tsiDelete,
            this.tsbDeleteLineHoriz,
            this.tsnDeleteLineVert,
            this.toolStripSeparator2,
            this.tsbJump,
            this.toolStripButton1});
            this.tSPanelEdit.Location = new System.Drawing.Point(0, 0);
            this.tSPanelEdit.Name = "tSPanelEdit";
            this.tSPanelEdit.Size = new System.Drawing.Size(1060, 25);
            this.tSPanelEdit.TabIndex = 0;
            this.tSPanelEdit.Text = "toolStrip2";
            // 
            // tbtnAddContact
            // 
            this.tbtnAddContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAddContact.Image = ((System.Drawing.Image)(resources.GetObject("tbtnAddContact.Image")));
            this.tbtnAddContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAddContact.Margin = new System.Windows.Forms.Padding(0);
            this.tbtnAddContact.Name = "tbtnAddContact";
            this.tbtnAddContact.Size = new System.Drawing.Size(34, 25);
            this.tbtnAddContact.ToolTipText = "Добавить контакт";
            this.tbtnAddContact.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tbtnAddInvContact
            // 
            this.tbtnAddInvContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAddInvContact.Image = global::LDEditor.Properties.Resources.InvContact;
            this.tbtnAddInvContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAddInvContact.Margin = new System.Windows.Forms.Padding(0);
            this.tbtnAddInvContact.Name = "tbtnAddInvContact";
            this.tbtnAddInvContact.Size = new System.Drawing.Size(34, 25);
            this.tbtnAddInvContact.Text = "Вставить обратный контакт";
            this.tbtnAddInvContact.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // tbtnAddCoil
            // 
            this.tbtnAddCoil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAddCoil.Image = global::LDEditor.Properties.Resources.Coil;
            this.tbtnAddCoil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAddCoil.Margin = new System.Windows.Forms.Padding(0);
            this.tbtnAddCoil.Name = "tbtnAddCoil";
            this.tbtnAddCoil.Size = new System.Drawing.Size(34, 25);
            this.tbtnAddCoil.Text = "Вставить обмотку";
            this.tbtnAddCoil.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // tbtnAddInvCoil
            // 
            this.tbtnAddInvCoil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAddInvCoil.Image = global::LDEditor.Properties.Resources.InvCoil;
            this.tbtnAddInvCoil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAddInvCoil.Margin = new System.Windows.Forms.Padding(0);
            this.tbtnAddInvCoil.Name = "tbtnAddInvCoil";
            this.tbtnAddInvCoil.Size = new System.Drawing.Size(34, 25);
            this.tbtnAddInvCoil.Text = "Вставить обратную обмотку";
            // 
            // tbtnAddSetCoil
            // 
            this.tbtnAddSetCoil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAddSetCoil.Image = global::LDEditor.Properties.Resources.SetCoil;
            this.tbtnAddSetCoil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAddSetCoil.Margin = new System.Windows.Forms.Padding(0);
            this.tbtnAddSetCoil.Name = "tbtnAddSetCoil";
            this.tbtnAddSetCoil.Size = new System.Drawing.Size(34, 25);
            this.tbtnAddSetCoil.Text = "Вставить Set обмотку";
            // 
            // tbtnAddResetCoil
            // 
            this.tbtnAddResetCoil.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAddResetCoil.Image = global::LDEditor.Properties.Resources.ResetCoil;
            this.tbtnAddResetCoil.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAddResetCoil.Margin = new System.Windows.Forms.Padding(0);
            this.tbtnAddResetCoil.Name = "tbtnAddResetCoil";
            this.tbtnAddResetCoil.Size = new System.Drawing.Size(34, 25);
            this.tbtnAddResetCoil.Text = "Вставить Reset обмотку";
            // 
            // tbtnAddFPContact
            // 
            this.tbtnAddFPContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAddFPContact.Image = global::LDEditor.Properties.Resources.FP_contact;
            this.tbtnAddFPContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAddFPContact.Margin = new System.Windows.Forms.Padding(0);
            this.tbtnAddFPContact.Name = "tbtnAddFPContact";
            this.tbtnAddFPContact.Size = new System.Drawing.Size(34, 25);
            this.tbtnAddFPContact.Text = "Вставить FP контакт";
            // 
            // tbtnAddFNContact
            // 
            this.tbtnAddFNContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAddFNContact.Image = global::LDEditor.Properties.Resources.FN_contact;
            this.tbtnAddFNContact.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAddFNContact.Margin = new System.Windows.Forms.Padding(0);
            this.tbtnAddFNContact.Name = "tbtnAddFNContact";
            this.tbtnAddFNContact.Size = new System.Drawing.Size(34, 25);
            this.tbtnAddFNContact.Text = "Вставить FN контакт";
            // 
            // tsbAddLineVert
            // 
            this.tsbAddLineVert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbAddLineVert.Image = global::LDEditor.Properties.Resources.LineVert;
            this.tsbAddLineVert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAddLineVert.Margin = new System.Windows.Forms.Padding(0);
            this.tsbAddLineVert.Name = "tsbAddLineVert";
            this.tsbAddLineVert.Size = new System.Drawing.Size(34, 25);
            this.tsbAddLineVert.Text = "toolStripButton3";
            this.tsbAddLineVert.Click += new System.EventHandler(this.tsbAddLineVert_Click);
            // 
            // btnAddLine
            // 
            this.btnAddLine.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAddLine.Image = ((System.Drawing.Image)(resources.GetObject("btnAddLine.Image")));
            this.btnAddLine.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAddLine.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddLine.Name = "btnAddLine";
            this.btnAddLine.Size = new System.Drawing.Size(34, 25);
            this.btnAddLine.Text = "Вставить линию";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = global::LDEditor.Properties.Resources.Inv;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(0);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 25);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click_1);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.AutoSize = false;
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(15, 25);
            // 
            // tbtnAddNetwork
            // 
            this.tbtnAddNetwork.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tbtnAddNetwork.Image = global::LDEditor.Properties.Resources.AddNetwork;
            this.tbtnAddNetwork.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnAddNetwork.Margin = new System.Windows.Forms.Padding(0);
            this.tbtnAddNetwork.Name = "tbtnAddNetwork";
            this.tbtnAddNetwork.Size = new System.Drawing.Size(34, 25);
            this.tbtnAddNetwork.Text = "Вставить новую сеть";
            this.tbtnAddNetwork.ToolTipText = "Добавить сеть";
            this.tbtnAddNetwork.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // tsiDelete
            // 
            this.tsiDelete.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsiDelete.Image = global::LDEditor.Properties.Resources.delete;
            this.tsiDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsiDelete.Margin = new System.Windows.Forms.Padding(0);
            this.tsiDelete.Name = "tsiDelete";
            this.tsiDelete.Size = new System.Drawing.Size(34, 25);
            this.tsiDelete.ToolTipText = "Удалить";
            this.tsiDelete.Click += new System.EventHandler(this.toolStripButton11_Click);
            // 
            // tsbDeleteLineHoriz
            // 
            this.tsbDeleteLineHoriz.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbDeleteLineHoriz.Image = global::LDEditor.Properties.Resources.deleteHorzLine;
            this.tsbDeleteLineHoriz.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDeleteLineHoriz.Name = "tsbDeleteLineHoriz";
            this.tsbDeleteLineHoriz.Size = new System.Drawing.Size(34, 22);
            this.tsbDeleteLineHoriz.Text = "toolStripButton13";
            this.tsbDeleteLineHoriz.ToolTipText = "Удалить горизонтальную линию";
            this.tsbDeleteLineHoriz.Click += new System.EventHandler(this.toolStripButton13_Click);
            // 
            // tsnDeleteLineVert
            // 
            this.tsnDeleteLineVert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsnDeleteLineVert.Image = global::LDEditor.Properties.Resources.deleteVertLine;
            this.tsnDeleteLineVert.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsnDeleteLineVert.Name = "tsnDeleteLineVert";
            this.tsnDeleteLineVert.Size = new System.Drawing.Size(34, 22);
            this.tsnDeleteLineVert.ToolTipText = "Удалить вертикальную линию";
            this.tsnDeleteLineVert.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.AutoSize = false;
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(15, 25);
            // 
            // tsbJump
            // 
            this.tsbJump.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbJump.Image = global::LDEditor.Properties.Resources.Jump;
            this.tsbJump.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbJump.Name = "tsbJump";
            this.tsbJump.Size = new System.Drawing.Size(34, 22);
            this.tsbJump.Text = "toolStripButton1";
            this.tsbJump.ToolTipText = "Вставить переход";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::LDEditor.Properties.Resources.Return;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // создатьToolStripButton
            // 
            this.создатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.создатьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("создатьToolStripButton.Image")));
            this.создатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.создатьToolStripButton.Name = "создатьToolStripButton";
            this.создатьToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.создатьToolStripButton.Text = "&Создать";
            // 
            // открытьToolStripButton
            // 
            this.открытьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.открытьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripButton.Image")));
            this.открытьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolStripButton.Name = "открытьToolStripButton";
            this.открытьToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.открытьToolStripButton.Text = "&Открыть";
            // 
            // сохранитьToolStripButton
            // 
            this.сохранитьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сохранитьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripButton.Image")));
            this.сохранитьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripButton.Name = "сохранитьToolStripButton";
            this.сохранитьToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.сохранитьToolStripButton.Text = "&Сохранить";
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // вырезатьToolStripButton
            // 
            this.вырезатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.вырезатьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("вырезатьToolStripButton.Image")));
            this.вырезатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вырезатьToolStripButton.Name = "вырезатьToolStripButton";
            this.вырезатьToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.вырезатьToolStripButton.Text = "В&ырезать";
            // 
            // копироватьToolStripButton
            // 
            this.копироватьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.копироватьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("копироватьToolStripButton.Image")));
            this.копироватьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.копироватьToolStripButton.Name = "копироватьToolStripButton";
            this.копироватьToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.копироватьToolStripButton.Text = "&Копировать";
            // 
            // вставкаToolStripButton
            // 
            this.вставкаToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.вставкаToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("вставкаToolStripButton.Image")));
            this.вставкаToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вставкаToolStripButton.Name = "вставкаToolStripButton";
            this.вставкаToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.вставкаToolStripButton.Text = "Вст&авка";
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // справкаToolStripButton
            // 
            this.справкаToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.справкаToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("справкаToolStripButton.Image")));
            this.справкаToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.справкаToolStripButton.Name = "справкаToolStripButton";
            this.справкаToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.справкаToolStripButton.Text = "Спр&авка";
            // 
            // toolStripButton12
            // 
            this.toolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton12.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton12.Image")));
            this.toolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton12.Name = "toolStripButton12";
            this.toolStripButton12.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton12.Text = "toolStripButton12";
            this.toolStripButton12.ToolTipText = "Открыть тестовую форму";
            this.toolStripButton12.Click += new System.EventHandler(this.ToolStripButton12_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripButton,
            this.открытьToolStripButton,
            this.сохранитьToolStripButton,
            this.toolStripSeparator6,
            this.вырезатьToolStripButton,
            this.копироватьToolStripButton,
            this.вставкаToolStripButton,
            this.toolStripSeparator7,
            this.справкаToolStripButton,
            this.toolStripButton12});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1060, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripMenuItem,
            this.открытьToolStripMenuItem,
            this.toolStripSeparator,
            this.сохранитьToolStripMenuItem,
            this.сохранитькакToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("создатьToolStripMenuItem.Image")));
            this.создатьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.создатьToolStripMenuItem.Text = "&Создать";
            this.создатьToolStripMenuItem.Click += new System.EventHandler(this.создатьToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem.Image")));
            this.открытьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.открытьToolStripMenuItem.Text = "&Открыть";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(169, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.Image")));
            this.сохранитьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.сохранитьToolStripMenuItem.Text = "&Сохранить";
            // 
            // сохранитькакToolStripMenuItem
            // 
            this.сохранитькакToolStripMenuItem.Name = "сохранитькакToolStripMenuItem";
            this.сохранитькакToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.сохранитькакToolStripMenuItem.Text = "Сохранить &как";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.выходToolStripMenuItem.Text = "Вы&ход";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator3,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставкаToolStripMenuItem,
            this.toolStripSeparator4,
            this.выделитьвсеToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.правкаToolStripMenuItem.Text = "&Правка";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(178, 6);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вырезатьToolStripMenuItem.Image")));
            this.вырезатьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезат&ь";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("копироватьToolStripMenuItem.Image")));
            this.копироватьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.копироватьToolStripMenuItem.Text = "&Копировать";
            // 
            // вставкаToolStripMenuItem
            // 
            this.вставкаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вставкаToolStripMenuItem.Image")));
            this.вставкаToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вставкаToolStripMenuItem.Name = "вставкаToolStripMenuItem";
            this.вставкаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.вставкаToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.вставкаToolStripMenuItem.Text = "Вст&авка";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(178, 6);
            // 
            // выделитьвсеToolStripMenuItem
            // 
            this.выделитьвсеToolStripMenuItem.Name = "выделитьвсеToolStripMenuItem";
            this.выделитьвсеToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.выделитьвсеToolStripMenuItem.Text = "Выделить &все";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.масштабToolStripMenuItem,
            this.tsmiPOU});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // масштабToolStripMenuItem
            // 
            this.масштабToolStripMenuItem.Name = "масштабToolStripMenuItem";
            this.масштабToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.масштабToolStripMenuItem.Text = "&Масштаб";
            // 
            // tsmiPOU
            // 
            this.tsmiPOU.Checked = true;
            this.tsmiPOU.CheckOnClick = true;
            this.tsmiPOU.CheckState = System.Windows.Forms.CheckState.Checked;
            this.tsmiPOU.Name = "tsmiPOU";
            this.tsmiPOU.Size = new System.Drawing.Size(142, 22);
            this.tsmiPOU.Text = "&Панель POU";
            this.tsmiPOU.Click += new System.EventHandler(this.tsmiPOU_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.опрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Спра&вка";
            // 
            // опрограммеToolStripMenuItem
            // 
            this.опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            this.опрограммеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.опрограммеToolStripMenuItem.Text = "&О программе...";
            // 
            // menuStdLD
            // 
            this.menuStdLD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.видToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStdLD.Location = new System.Drawing.Point(0, 0);
            this.menuStdLD.Name = "menuStdLD";
            this.menuStdLD.Size = new System.Drawing.Size(1060, 24);
            this.menuStdLD.TabIndex = 5;
            this.menuStdLD.Text = "menuStrip1";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 666);
            this.Controls.Add(this.splitContainer4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStdLD);
            this.Name = "frmMain";
            this.Text = "LDEditor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Main_Click);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.sc3.Panel1.ResumeLayout(false);
            this.sc3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc3)).EndInit();
            this.sc3.ResumeLayout(false);
            this.tcPOU.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVarTable)).EndInit();
            this.tLPEditor.ResumeLayout(false);
            this.tLPEditor.PerformLayout();
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tSPanelEdit.ResumeLayout(false);
            this.tSPanelEdit.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.menuStdLD.ResumeLayout(false);
            this.menuStdLD.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private ToolTip toolTip1;
        private StatusStrip statusStrip1;
        private ToolStrip tSPanelEdit;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripButton tbtnAddContact;
        private ToolStripButton tbtnAddInvContact;
        private ToolStripButton tbtnAddCoil;
        private ToolStripButton tbtnAddInvCoil;
        private ToolStripButton tbtnAddSetCoil;
        private ToolStripButton tbtnAddResetCoil;
        private ToolStripButton tbtnAddFPContact;
        private ToolStripButton tbtnAddFNContact;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton tbtnAddNetwork;
        public SplitContainer sc3;
        public SplitContainer splitContainer4;
        public DataGridView dgvVarTable;
        public SplitContainer splitContainer1;
        public TableLayoutPanel tLPEditor;
        public WFControlLibrary.NewNetwork newNetwork1;
        private ToolStripButton tsiDelete;
        private ToolStripButton tsbDeleteLineHoriz;
        private ToolStripButton btnAddLine;
        private ToolStripButton tsnDeleteLineVert;
        public TabControl tcPOU;
        private TabPage tabPage2;
        private ToolStripButton создатьToolStripButton;
        private ToolStripButton открытьToolStripButton;
        private ToolStripButton сохранитьToolStripButton;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton вырезатьToolStripButton;
        private ToolStripButton копироватьToolStripButton;
        private ToolStripButton вставкаToolStripButton;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton справкаToolStripButton;
        private ToolStripButton toolStripButton12;
        private ToolStrip toolStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem создатьToolStripMenuItem;
        private ToolStripMenuItem открытьToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem сохранитькакToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem выходToolStripMenuItem;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вставкаToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator4;
        private ToolStripMenuItem выделитьвсеToolStripMenuItem;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem масштабToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private ToolStripMenuItem опрограммеToolStripMenuItem;
        private MenuStrip menuStdLD;
        private TreeView treeView1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton tsbAddLineVert;
        private DataGridViewTextBoxColumn NameVar;
        private DataGridViewTextBoxColumn TypeVar;
        private DataGridViewTextBoxColumn CommentVar;
        private ToolStripMenuItem tsmiPOU;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripButton tsbJump;
        private ToolStripButton toolStripButton1;
    }
}
