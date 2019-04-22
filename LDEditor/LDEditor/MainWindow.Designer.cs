using System;
using System.Drawing;
using System.Windows.Forms;

namespace LDEditor
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("POU");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("LDprog");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Программа", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10});
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Устройство", new System.Windows.Forms.TreeNode[] {
            treeNode11});
            this.menuStdLD = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.проектToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.открытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитькакToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.предварительныйпросмотрToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменадействияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменадействияToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.выделитьвсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.масштабToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.настройкиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметрыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.содержаниеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.индексToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.опрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.модельToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стартToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.стопToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.паузаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.создатьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.открытьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.сохранитьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.печатьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.вырезатьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.копироватьToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.вставкаToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.справкаToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.propertyGrid1 = new System.Windows.Forms.PropertyGrid();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numVarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameVarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeVarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.commentVarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataVaribleBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataVaribleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataVarible = new LDEditor.DataVarible();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.newNetwork20 = new WFControlLibrary.NewNetwork();
            this.newNetwork19 = new WFControlLibrary.NewNetwork();
            this.newNetwork18 = new WFControlLibrary.NewNetwork();
            this.newNetwork17 = new WFControlLibrary.NewNetwork();
            this.newNetwork16 = new WFControlLibrary.NewNetwork();
            this.newNetwork15 = new WFControlLibrary.NewNetwork();
            this.newNetwork14 = new WFControlLibrary.NewNetwork();
            this.newNetwork13 = new WFControlLibrary.NewNetwork();
            this.newNetwork12 = new WFControlLibrary.NewNetwork();
            this.newNetwork11 = new WFControlLibrary.NewNetwork();
            this.newNetwork10 = new WFControlLibrary.NewNetwork();
            this.newNetwork9 = new WFControlLibrary.NewNetwork();
            this.newNetwork8 = new WFControlLibrary.NewNetwork();
            this.newNetwork6 = new WFControlLibrary.NewNetwork();
            this.newNetwork5 = new WFControlLibrary.NewNetwork();
            this.newNetwork4 = new WFControlLibrary.NewNetwork();
            this.newNetwork3 = new WFControlLibrary.NewNetwork();
            this.newNetwork2 = new WFControlLibrary.NewNetwork();
            this.newNetwork1 = new WFControlLibrary.NewNetwork();
            this.newNetwork7 = new WFControlLibrary.NewNetwork();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton8 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton9 = new System.Windows.Forms.ToolStripButton();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataVaribleBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.mainBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStdLD.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVaribleBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVaribleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVarible)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.Panel1.SuspendLayout();
            this.splitContainer4.Panel2.SuspendLayout();
            this.splitContainer4.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVaribleBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStdLD
            // 
            this.menuStdLD.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.видToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.справкаToolStripMenuItem,
            this.модельToolStripMenuItem});
            this.menuStdLD.Location = new System.Drawing.Point(0, 0);
            this.menuStdLD.Name = "menuStdLD";
            this.menuStdLD.Size = new System.Drawing.Size(1060, 24);
            this.menuStdLD.TabIndex = 5;
            this.menuStdLD.Text = "menuStrip1";
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
            this.печатьToolStripMenuItem,
            this.предварительныйпросмотрToolStripMenuItem,
            this.toolStripSeparator2,
            this.выходToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "&Файл";
            // 
            // создатьToolStripMenuItem
            // 
            this.создатьToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.проектToolStripMenuItem});
            this.создатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("создатьToolStripMenuItem.Image")));
            this.создатьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.создатьToolStripMenuItem.Name = "создатьToolStripMenuItem";
            this.создатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.создатьToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.создатьToolStripMenuItem.Text = "&Создать";
            // 
            // проектToolStripMenuItem
            // 
            this.проектToolStripMenuItem.Name = "проектToolStripMenuItem";
            this.проектToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.проектToolStripMenuItem.Text = "Проект";
            this.проектToolStripMenuItem.Click += new System.EventHandler(this.проектToolStripMenuItem_Click);
            // 
            // открытьToolStripMenuItem
            // 
            this.открытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("открытьToolStripMenuItem.Image")));
            this.открытьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.открытьToolStripMenuItem.Name = "открытьToolStripMenuItem";
            this.открытьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.открытьToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.открытьToolStripMenuItem.Text = "&Открыть";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(230, 6);
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("сохранитьToolStripMenuItem.Image")));
            this.сохранитьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.сохранитьToolStripMenuItem.Text = "&Сохранить";
            // 
            // сохранитькакToolStripMenuItem
            // 
            this.сохранитькакToolStripMenuItem.Name = "сохранитькакToolStripMenuItem";
            this.сохранитькакToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.сохранитькакToolStripMenuItem.Text = "Сохранить &как";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(230, 6);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("печатьToolStripMenuItem.Image")));
            this.печатьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.печатьToolStripMenuItem.Text = "&Печать";
            // 
            // предварительныйпросмотрToolStripMenuItem
            // 
            this.предварительныйпросмотрToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("предварительныйпросмотрToolStripMenuItem.Image")));
            this.предварительныйпросмотрToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.предварительныйпросмотрToolStripMenuItem.Name = "предварительныйпросмотрToolStripMenuItem";
            this.предварительныйпросмотрToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.предварительныйпросмотрToolStripMenuItem.Text = "Предварительный про&смотр";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(230, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.выходToolStripMenuItem.Text = "Вы&ход";
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменадействияToolStripMenuItem,
            this.отменадействияToolStripMenuItem1,
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
            // отменадействияToolStripMenuItem
            // 
            this.отменадействияToolStripMenuItem.Name = "отменадействияToolStripMenuItem";
            this.отменадействияToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.отменадействияToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.отменадействияToolStripMenuItem.Text = "&Отмена действия";
            // 
            // отменадействияToolStripMenuItem1
            // 
            this.отменадействияToolStripMenuItem1.Name = "отменадействияToolStripMenuItem1";
            this.отменадействияToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.отменадействияToolStripMenuItem1.Size = new System.Drawing.Size(209, 22);
            this.отменадействияToolStripMenuItem1.Text = "&Отмена действия";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(206, 6);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вырезатьToolStripMenuItem.Image")));
            this.вырезатьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.вырезатьToolStripMenuItem.Text = "Вырезат&ь";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("копироватьToolStripMenuItem.Image")));
            this.копироватьToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.копироватьToolStripMenuItem.Text = "&Копировать";
            // 
            // вставкаToolStripMenuItem
            // 
            this.вставкаToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("вставкаToolStripMenuItem.Image")));
            this.вставкаToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.вставкаToolStripMenuItem.Name = "вставкаToolStripMenuItem";
            this.вставкаToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.вставкаToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.вставкаToolStripMenuItem.Text = "Вст&авка";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(206, 6);
            // 
            // выделитьвсеToolStripMenuItem
            // 
            this.выделитьвсеToolStripMenuItem.Name = "выделитьвсеToolStripMenuItem";
            this.выделитьвсеToolStripMenuItem.Size = new System.Drawing.Size(209, 22);
            this.выделитьвсеToolStripMenuItem.Text = "Выделить &все";
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.масштабToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // масштабToolStripMenuItem
            // 
            this.масштабToolStripMenuItem.Name = "масштабToolStripMenuItem";
            this.масштабToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.масштабToolStripMenuItem.Text = "Масштаб";
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.настройкиToolStripMenuItem,
            this.параметрыToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сервисToolStripMenuItem.Text = "&Сервис";
            // 
            // настройкиToolStripMenuItem
            // 
            this.настройкиToolStripMenuItem.Name = "настройкиToolStripMenuItem";
            this.настройкиToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.настройкиToolStripMenuItem.Text = "&Настройки";
            // 
            // параметрыToolStripMenuItem
            // 
            this.параметрыToolStripMenuItem.Name = "параметрыToolStripMenuItem";
            this.параметрыToolStripMenuItem.Size = new System.Drawing.Size(138, 22);
            this.параметрыToolStripMenuItem.Text = "&Параметры";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.содержаниеToolStripMenuItem,
            this.индексToolStripMenuItem,
            this.поискToolStripMenuItem,
            this.toolStripSeparator5,
            this.опрограммеToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Спра&вка";
            // 
            // содержаниеToolStripMenuItem
            // 
            this.содержаниеToolStripMenuItem.Name = "содержаниеToolStripMenuItem";
            this.содержаниеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.содержаниеToolStripMenuItem.Text = "&Содержание";
            // 
            // индексToolStripMenuItem
            // 
            this.индексToolStripMenuItem.Name = "индексToolStripMenuItem";
            this.индексToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.индексToolStripMenuItem.Text = "&Индекс";
            // 
            // поискToolStripMenuItem
            // 
            this.поискToolStripMenuItem.Name = "поискToolStripMenuItem";
            this.поискToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.поискToolStripMenuItem.Text = "&Поиск";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(155, 6);
            // 
            // опрограммеToolStripMenuItem
            // 
            this.опрограммеToolStripMenuItem.Name = "опрограммеToolStripMenuItem";
            this.опрограммеToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.опрограммеToolStripMenuItem.Text = "&О программе...";
            // 
            // модельToolStripMenuItem
            // 
            this.модельToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.стартToolStripMenuItem,
            this.стопToolStripMenuItem,
            this.паузаToolStripMenuItem});
            this.модельToolStripMenuItem.Name = "модельToolStripMenuItem";
            this.модельToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.модельToolStripMenuItem.Text = "Модель";
            // 
            // стартToolStripMenuItem
            // 
            this.стартToolStripMenuItem.Name = "стартToolStripMenuItem";
            this.стартToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.стартToolStripMenuItem.Text = "Старт";
            // 
            // стопToolStripMenuItem
            // 
            this.стопToolStripMenuItem.Name = "стопToolStripMenuItem";
            this.стопToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.стопToolStripMenuItem.Text = "Стоп";
            // 
            // паузаToolStripMenuItem
            // 
            this.паузаToolStripMenuItem.Name = "паузаToolStripMenuItem";
            this.паузаToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.паузаToolStripMenuItem.Text = "Пауза";
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
            // печатьToolStripButton
            // 
            this.печатьToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.печатьToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("печатьToolStripButton.Image")));
            this.печатьToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.печатьToolStripButton.Name = "печатьToolStripButton";
            this.печатьToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.печатьToolStripButton.Text = "&Печать";
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
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.создатьToolStripButton,
            this.открытьToolStripButton,
            this.сохранитьToolStripButton,
            this.печатьToolStripButton,
            this.toolStripSeparator6,
            this.вырезатьToolStripButton,
            this.копироватьToolStripButton,
            this.вставкаToolStripButton,
            this.toolStripSeparator7,
            this.справкаToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1060, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 644);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1060, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Enabled = false;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(82, 17);
            this.toolStripStatusLabel1.Text = "СИМУЛЯЦИЯ";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Enabled = false;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(53, 17);
            this.toolStripStatusLabel2.Text = "РАБОТА";
            // 
            // splitContainer3
            // 
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 0);
            this.splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer3.Size = new System.Drawing.Size(1060, 565);
            this.splitContainer3.SplitterDistance = 292;
            this.splitContainer3.TabIndex = 9;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(292, 565);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.treeView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(284, 539);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Обозреватель решений";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            treeNode9.Name = "POU";
            treeNode9.Text = "POU";
            treeNode10.Name = "LDprog";
            treeNode10.Text = "LDprog";
            treeNode11.Name = "Программа";
            treeNode11.Text = "Программа";
            treeNode12.Name = "Устройство";
            treeNode12.Text = "Устройство";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(278, 533);
            this.treeView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.propertyGrid1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(284, 539);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Свойства";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // propertyGrid1
            // 
            this.propertyGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.propertyGrid1.Location = new System.Drawing.Point(3, 3);
            this.propertyGrid1.Name = "propertyGrid1";
            this.propertyGrid1.Size = new System.Drawing.Size(278, 533);
            this.propertyGrid1.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.listBox1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(284, 539);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "NetworkList";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 3);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(278, 533);
            this.listBox1.TabIndex = 0;
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
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AllowDrop = true;
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(764, 565);
            this.splitContainer1.SplitterDistance = 101;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numVarDataGridViewTextBoxColumn,
            this.nameVarDataGridViewTextBoxColumn,
            this.typeVarDataGridViewTextBoxColumn,
            this.commentVarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.dataVaribleBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(764, 101);
            this.dataGridView1.TabIndex = 0;
            // 
            // numVarDataGridViewTextBoxColumn
            // 
            this.numVarDataGridViewTextBoxColumn.DataPropertyName = "NumVar";
            this.numVarDataGridViewTextBoxColumn.HeaderText = "NumVar";
            this.numVarDataGridViewTextBoxColumn.Name = "numVarDataGridViewTextBoxColumn";
            // 
            // nameVarDataGridViewTextBoxColumn
            // 
            this.nameVarDataGridViewTextBoxColumn.DataPropertyName = "NameVar";
            this.nameVarDataGridViewTextBoxColumn.HeaderText = "NameVar";
            this.nameVarDataGridViewTextBoxColumn.Name = "nameVarDataGridViewTextBoxColumn";
            // 
            // typeVarDataGridViewTextBoxColumn
            // 
            this.typeVarDataGridViewTextBoxColumn.DataPropertyName = "TypeVar";
            this.typeVarDataGridViewTextBoxColumn.HeaderText = "TypeVar";
            this.typeVarDataGridViewTextBoxColumn.Name = "typeVarDataGridViewTextBoxColumn";
            // 
            // commentVarDataGridViewTextBoxColumn
            // 
            this.commentVarDataGridViewTextBoxColumn.DataPropertyName = "CommentVar";
            this.commentVarDataGridViewTextBoxColumn.HeaderText = "CommentVar";
            this.commentVarDataGridViewTextBoxColumn.Name = "commentVarDataGridViewTextBoxColumn";
            // 
            // dataVaribleBindingSource1
            // 
            this.dataVaribleBindingSource1.DataMember = "DataVarible";
            this.dataVaribleBindingSource1.DataSource = this.dataVaribleBindingSource;
            // 
            // dataVaribleBindingSource
            // 
            this.dataVaribleBindingSource.DataSource = this.dataVarible;
            this.dataVaribleBindingSource.Position = 0;
            // 
            // dataVarible
            // 
            this.dataVarible.DataSetName = "DataVarible";
            this.dataVarible.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.newNetwork20, 0, 19);
            this.tableLayoutPanel1.Controls.Add(this.newNetwork19, 0, 18);
            this.tableLayoutPanel1.Controls.Add(this.newNetwork18, 0, 17);
            this.tableLayoutPanel1.Controls.Add(this.newNetwork17, 0, 16);
            this.tableLayoutPanel1.Controls.Add(this.newNetwork16, 0, 15);
            this.tableLayoutPanel1.Controls.Add(this.newNetwork15, 0, 14);
            this.tableLayoutPanel1.Controls.Add(this.newNetwork14, 0, 13);
            this.tableLayoutPanel1.Controls.Add(this.newNetwork13, 0, 12);
            this.tableLayoutPanel1.Controls.Add(this.newNetwork12, 0, 11);
            this.tableLayoutPanel1.Controls.Add(this.newNetwork11, 0, 10);
            this.tableLayoutPanel1.Controls.Add(this.newNetwork10, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.newNetwork9, 0, 8);
            this.tableLayoutPanel1.Controls.Add(this.newNetwork8, 0, 7);
            this.tableLayoutPanel1.Controls.Add(this.newNetwork6, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.newNetwork5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.newNetwork4, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.newNetwork3, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.newNetwork2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.newNetwork1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.newNetwork7, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 20;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(764, 460);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Layout += new System.Windows.Forms.LayoutEventHandler(this.tableLayoutPanel1_Layout);
            // 
            // newNetwork20
            // 
            this.newNetwork20.AllowDrop = true;
            this.newNetwork20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newNetwork20.Location = new System.Drawing.Point(0, 950);
            this.newNetwork20.Margin = new System.Windows.Forms.Padding(0);
            this.newNetwork20.Name = "newNetwork20";
            this.newNetwork20.Size = new System.Drawing.Size(764, 50);
            this.newNetwork20.TabIndex = 19;
            // 
            // newNetwork19
            // 
            this.newNetwork19.AllowDrop = true;
            this.newNetwork19.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newNetwork19.Location = new System.Drawing.Point(0, 900);
            this.newNetwork19.Margin = new System.Windows.Forms.Padding(0);
            this.newNetwork19.Name = "newNetwork19";
            this.newNetwork19.Size = new System.Drawing.Size(764, 50);
            this.newNetwork19.TabIndex = 18;
            // 
            // newNetwork18
            // 
            this.newNetwork18.AllowDrop = true;
            this.newNetwork18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newNetwork18.Location = new System.Drawing.Point(0, 850);
            this.newNetwork18.Margin = new System.Windows.Forms.Padding(0);
            this.newNetwork18.Name = "newNetwork18";
            this.newNetwork18.Size = new System.Drawing.Size(764, 50);
            this.newNetwork18.TabIndex = 17;
            // 
            // newNetwork17
            // 
            this.newNetwork17.AllowDrop = true;
            this.newNetwork17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newNetwork17.Location = new System.Drawing.Point(0, 800);
            this.newNetwork17.Margin = new System.Windows.Forms.Padding(0);
            this.newNetwork17.Name = "newNetwork17";
            this.newNetwork17.Size = new System.Drawing.Size(764, 50);
            this.newNetwork17.TabIndex = 16;
            // 
            // newNetwork16
            // 
            this.newNetwork16.AllowDrop = true;
            this.newNetwork16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newNetwork16.Location = new System.Drawing.Point(0, 750);
            this.newNetwork16.Margin = new System.Windows.Forms.Padding(0);
            this.newNetwork16.Name = "newNetwork16";
            this.newNetwork16.Size = new System.Drawing.Size(764, 50);
            this.newNetwork16.TabIndex = 15;
            // 
            // newNetwork15
            // 
            this.newNetwork15.AllowDrop = true;
            this.newNetwork15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newNetwork15.Location = new System.Drawing.Point(0, 700);
            this.newNetwork15.Margin = new System.Windows.Forms.Padding(0);
            this.newNetwork15.Name = "newNetwork15";
            this.newNetwork15.Size = new System.Drawing.Size(764, 50);
            this.newNetwork15.TabIndex = 14;
            // 
            // newNetwork14
            // 
            this.newNetwork14.AllowDrop = true;
            this.newNetwork14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newNetwork14.Location = new System.Drawing.Point(0, 650);
            this.newNetwork14.Margin = new System.Windows.Forms.Padding(0);
            this.newNetwork14.Name = "newNetwork14";
            this.newNetwork14.Size = new System.Drawing.Size(764, 50);
            this.newNetwork14.TabIndex = 13;
            // 
            // newNetwork13
            // 
            this.newNetwork13.AllowDrop = true;
            this.newNetwork13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newNetwork13.Location = new System.Drawing.Point(0, 600);
            this.newNetwork13.Margin = new System.Windows.Forms.Padding(0);
            this.newNetwork13.Name = "newNetwork13";
            this.newNetwork13.Size = new System.Drawing.Size(764, 50);
            this.newNetwork13.TabIndex = 12;
            // 
            // newNetwork12
            // 
            this.newNetwork12.AllowDrop = true;
            this.newNetwork12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newNetwork12.Location = new System.Drawing.Point(0, 550);
            this.newNetwork12.Margin = new System.Windows.Forms.Padding(0);
            this.newNetwork12.Name = "newNetwork12";
            this.newNetwork12.Size = new System.Drawing.Size(764, 50);
            this.newNetwork12.TabIndex = 11;
            // 
            // newNetwork11
            // 
            this.newNetwork11.AllowDrop = true;
            this.newNetwork11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newNetwork11.Location = new System.Drawing.Point(0, 500);
            this.newNetwork11.Margin = new System.Windows.Forms.Padding(0);
            this.newNetwork11.Name = "newNetwork11";
            this.newNetwork11.Size = new System.Drawing.Size(764, 50);
            this.newNetwork11.TabIndex = 10;
            // 
            // newNetwork10
            // 
            this.newNetwork10.AllowDrop = true;
            this.newNetwork10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newNetwork10.Location = new System.Drawing.Point(0, 450);
            this.newNetwork10.Margin = new System.Windows.Forms.Padding(0);
            this.newNetwork10.Name = "newNetwork10";
            this.newNetwork10.Size = new System.Drawing.Size(764, 50);
            this.newNetwork10.TabIndex = 9;
            // 
            // newNetwork9
            // 
            this.newNetwork9.AllowDrop = true;
            this.newNetwork9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newNetwork9.Location = new System.Drawing.Point(0, 400);
            this.newNetwork9.Margin = new System.Windows.Forms.Padding(0);
            this.newNetwork9.Name = "newNetwork9";
            this.newNetwork9.Size = new System.Drawing.Size(764, 50);
            this.newNetwork9.TabIndex = 8;
            // 
            // newNetwork8
            // 
            this.newNetwork8.AllowDrop = true;
            this.newNetwork8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newNetwork8.Location = new System.Drawing.Point(0, 350);
            this.newNetwork8.Margin = new System.Windows.Forms.Padding(0);
            this.newNetwork8.Name = "newNetwork8";
            this.newNetwork8.Size = new System.Drawing.Size(764, 50);
            this.newNetwork8.TabIndex = 7;
            // 
            // newNetwork6
            // 
            this.newNetwork6.AllowDrop = true;
            this.newNetwork6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newNetwork6.Location = new System.Drawing.Point(0, 250);
            this.newNetwork6.Margin = new System.Windows.Forms.Padding(0);
            this.newNetwork6.Name = "newNetwork6";
            this.newNetwork6.Size = new System.Drawing.Size(764, 50);
            this.newNetwork6.TabIndex = 5;
            // 
            // newNetwork5
            // 
            this.newNetwork5.AllowDrop = true;
            this.newNetwork5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newNetwork5.Location = new System.Drawing.Point(0, 200);
            this.newNetwork5.Margin = new System.Windows.Forms.Padding(0);
            this.newNetwork5.Name = "newNetwork5";
            this.newNetwork5.Size = new System.Drawing.Size(764, 50);
            this.newNetwork5.TabIndex = 4;
            // 
            // newNetwork4
            // 
            this.newNetwork4.AllowDrop = true;
            this.newNetwork4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newNetwork4.Location = new System.Drawing.Point(0, 150);
            this.newNetwork4.Margin = new System.Windows.Forms.Padding(0);
            this.newNetwork4.Name = "newNetwork4";
            this.newNetwork4.Size = new System.Drawing.Size(764, 50);
            this.newNetwork4.TabIndex = 3;
            // 
            // newNetwork3
            // 
            this.newNetwork3.AllowDrop = true;
            this.newNetwork3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newNetwork3.Location = new System.Drawing.Point(0, 100);
            this.newNetwork3.Margin = new System.Windows.Forms.Padding(0);
            this.newNetwork3.Name = "newNetwork3";
            this.newNetwork3.Size = new System.Drawing.Size(764, 50);
            this.newNetwork3.TabIndex = 2;
            // 
            // newNetwork2
            // 
            this.newNetwork2.AllowDrop = true;
            this.newNetwork2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newNetwork2.Location = new System.Drawing.Point(0, 50);
            this.newNetwork2.Margin = new System.Windows.Forms.Padding(0);
            this.newNetwork2.Name = "newNetwork2";
            this.newNetwork2.Size = new System.Drawing.Size(764, 50);
            this.newNetwork2.TabIndex = 1;
            // 
            // newNetwork1
            // 
            this.newNetwork1.AllowDrop = true;
            this.newNetwork1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newNetwork1.Location = new System.Drawing.Point(0, 0);
            this.newNetwork1.Margin = new System.Windows.Forms.Padding(0);
            this.newNetwork1.Name = "newNetwork1";
            this.newNetwork1.Size = new System.Drawing.Size(764, 50);
            this.newNetwork1.TabIndex = 0;
            this.newNetwork1.Load += new System.EventHandler(this.newNetwork1_Load);
            this.newNetwork1.Click += new System.EventHandler(this.newNetwork1_Click);
            // 
            // newNetwork7
            // 
            this.newNetwork7.AllowDrop = true;
            this.newNetwork7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newNetwork7.Location = new System.Drawing.Point(0, 300);
            this.newNetwork7.Margin = new System.Windows.Forms.Padding(0);
            this.newNetwork7.Name = "newNetwork7";
            this.newNetwork7.Size = new System.Drawing.Size(764, 50);
            this.newNetwork7.TabIndex = 6;
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
            this.splitContainer4.Panel1.Controls.Add(this.toolStrip2);
            // 
            // splitContainer4.Panel2
            // 
            this.splitContainer4.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer4.Size = new System.Drawing.Size(1060, 595);
            this.splitContainer4.SplitterDistance = 26;
            this.splitContainer4.TabIndex = 10;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripButton7,
            this.toolStripButton8,
            this.toolStripSeparator8,
            this.toolStripButton9});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(1060, 26);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 23);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 23);
            this.toolStripButton2.Text = "InversContact";
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(34, 23);
            this.toolStripButton3.Text = "Rele";
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(34, 23);
            this.toolStripButton4.Text = "InversRele";
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(34, 23);
            this.toolStripButton5.Text = "SetRele";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(34, 23);
            this.toolStripButton6.Text = "ResetRele";
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(34, 23);
            this.toolStripButton7.Text = "FP";
            // 
            // toolStripButton8
            // 
            this.toolStripButton8.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton8.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton8.Image")));
            this.toolStripButton8.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton8.Name = "toolStripButton8";
            this.toolStripButton8.Size = new System.Drawing.Size(34, 23);
            this.toolStripButton8.Text = "FN";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 26);
            // 
            // toolStripButton9
            // 
            this.toolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton9.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton9.Image")));
            this.toolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton9.Name = "toolStripButton9";
            this.toolStripButton9.Size = new System.Drawing.Size(34, 23);
            this.toolStripButton9.Text = "toolStripButton9";
            this.toolStripButton9.Click += new System.EventHandler(this.toolStripButton9_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // dataVaribleBindingSource2
            // 
            this.dataVaribleBindingSource2.DataSource = this.dataVarible;
            this.dataVaribleBindingSource2.Position = 0;
            // 
            // mainBindingSource
            // 
            this.mainBindingSource.DataSource = typeof(LDEditor.Main);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 666);
            this.Controls.Add(this.splitContainer4);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStdLD);
            this.Name = "Main";
            this.Text = "LDEditor";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStdLD.ResumeLayout(false);
            this.menuStdLD.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVaribleBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVaribleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVarible)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.splitContainer4.Panel1.ResumeLayout(false);
            this.splitContainer4.Panel1.PerformLayout();
            this.splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataVaribleBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.MenuStrip menuStdLD;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem создатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem открытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитькакToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem предварительныйпросмотрToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменадействияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отменадействияToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem вырезатьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem копироватьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem выделитьвсеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem настройкиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметрыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem содержаниеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem индексToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem опрограммеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem проектToolStripMenuItem;
        private ToolStripButton создатьToolStripButton;
        private ToolStripButton открытьToolStripButton;
        private ToolStripButton сохранитьToolStripButton;
        private ToolStripButton печатьToolStripButton;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripButton вырезатьToolStripButton;
        private ToolStripButton копироватьToolStripButton;
        private ToolStripButton вставкаToolStripButton;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripButton справкаToolStripButton;
        private ToolStrip toolStrip1;
        private ToolTip toolTip1;
        private StatusStrip statusStrip1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TreeView treeView1;
        private BindingSource bindingSource1;
        private ToolStrip toolStrip2;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem масштабToolStripMenuItem;
        private ToolStripMenuItem модельToolStripMenuItem;
        private ToolStripMenuItem стартToolStripMenuItem;
        private ToolStripMenuItem стопToolStripMenuItem;
        private ToolStripMenuItem паузаToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripStatusLabel toolStripStatusLabel2;
        private ToolStripButton toolStripButton1;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private ToolStripButton toolStripButton7;
        private ToolStripButton toolStripButton8;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripButton toolStripButton9;
        public SplitContainer splitContainer3;
        public SplitContainer splitContainer4;
        public DataGridView dataGridView1;
        public SplitContainer splitContainer1;
        private WFControlLibrary.NewNetwork newNetwork7;
        public WFControlLibrary.NewNetwork newNetwork6;
        public WFControlLibrary.NewNetwork newNetwork5;
        public WFControlLibrary.NewNetwork newNetwork4;
        public WFControlLibrary.NewNetwork newNetwork3;
        public WFControlLibrary.NewNetwork newNetwork2;
        public WFControlLibrary.NewNetwork newNetwork1;
        public WFControlLibrary.NewNetwork newNetwork20;
        public WFControlLibrary.NewNetwork newNetwork19;
        public WFControlLibrary.NewNetwork newNetwork18;
        public WFControlLibrary.NewNetwork newNetwork17;
        public WFControlLibrary.NewNetwork newNetwork16;
        public WFControlLibrary.NewNetwork newNetwork15;
        public WFControlLibrary.NewNetwork newNetwork14;
        public WFControlLibrary.NewNetwork newNetwork13;
        public WFControlLibrary.NewNetwork newNetwork12;
        public WFControlLibrary.NewNetwork newNetwork11;
        public WFControlLibrary.NewNetwork newNetwork10;
        public WFControlLibrary.NewNetwork newNetwork9;
        public WFControlLibrary.NewNetwork newNetwork8;
        public TableLayoutPanel tableLayoutPanel1;
        private BindingSource dataVaribleBindingSource;
        private DataVarible dataVarible;
        private DataGridViewTextBoxColumn numVarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn nameVarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeVarDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentVarDataGridViewTextBoxColumn;
        private BindingSource dataVaribleBindingSource1;
        private TabPage tabPage3;
        private ListBox listBox1;
        public TabControl tabControl1;
        private BindingSource dataVaribleBindingSource2;
        private BindingSource mainBindingSource;
        public PropertyGrid propertyGrid1;
    }
}
