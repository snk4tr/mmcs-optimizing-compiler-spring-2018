﻿namespace Compiler.IDE
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.mainBox = new System.Windows.Forms.GroupBox();
            this.removeDeadVarsCheckBox = new System.Windows.Forms.CheckBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.iterativeAlgoLabel = new System.Windows.Forms.Label();
            this.iterativeAlgoList = new System.Windows.Forms.CheckedListBox();
            this.optimizationsLabel = new System.Windows.Forms.Label();
            this.compileButton = new System.Windows.Forms.Button();
            this.runButton = new System.Windows.Forms.Button();
            this.toggleOptsButton = new System.Windows.Forms.Button();
            this.optsList = new System.Windows.Forms.CheckedListBox();
            this.outBox = new System.Windows.Forms.GroupBox();
            this.outTextBox = new System.Windows.Forms.TextBox();
            this.tabsControl = new System.Windows.Forms.TabControl();
            this.inputPage = new System.Windows.Forms.TabPage();
            this.inputTextBox = new System.Windows.Forms.RichTextBox();
            this.ILCodePage = new System.Windows.Forms.TabPage();
            this.ILCodeTextBox = new System.Windows.Forms.RichTextBox();
            this.threeAddrPage = new System.Windows.Forms.TabPage();
            this.threeAddrTextBox = new System.Windows.Forms.RichTextBox();
            this.CFGPage = new System.Windows.Forms.TabPage();
            this.cfgScalePanel = new System.Windows.Forms.Panel();
            this.cfgScaleBar = new System.Windows.Forms.TrackBar();
            this.cfgSaveButton = new System.Windows.Forms.Button();
            this.cfgPanel = new System.Windows.Forms.Panel();
            this.CFGPictureBox = new System.Windows.Forms.PictureBox();
            this.ASTPage = new System.Windows.Forms.TabPage();
            this.astPanel = new System.Windows.Forms.Panel();
            this.astTrackBar = new System.Windows.Forms.TrackBar();
            this.astSaveButton = new System.Windows.Forms.Button();
            this.astTabPanel = new System.Windows.Forms.Panel();
            this.ASTPictureBox = new System.Windows.Forms.PictureBox();
            this.iterativeAlgoPage = new System.Windows.Forms.TabPage();
            this.iterativeAlgoTextBox = new System.Windows.Forms.RichTextBox();
            this.CFGEdgeClassificationPage = new System.Windows.Forms.TabPage();
            this.CFGEdgeClassificationTextBox = new System.Windows.Forms.RichTextBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.menuStrip1.SuspendLayout();
            this.mainBox.SuspendLayout();
            this.outBox.SuspendLayout();
            this.tabsControl.SuspendLayout();
            this.inputPage.SuspendLayout();
            this.ILCodePage.SuspendLayout();
            this.threeAddrPage.SuspendLayout();
            this.CFGPage.SuspendLayout();
            this.cfgScalePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cfgScaleBar)).BeginInit();
            this.cfgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CFGPictureBox)).BeginInit();
            this.ASTPage.SuspendLayout();
            this.astPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.astTrackBar)).BeginInit();
            this.astTabPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ASTPictureBox)).BeginInit();
            this.iterativeAlgoPage.SuspendLayout();
            this.CFGEdgeClassificationPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(28, 28);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1507, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(83, 36);
            this.fileToolStripMenuItem.Text = "Файл";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(326, 38);
            this.openToolStripMenuItem.Text = "Открыть...";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(326, 38);
            this.saveToolStripMenuItem.Text = "Сохранить...";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(326, 38);
            this.exitToolStripMenuItem.Text = "Выход";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem1});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(119, 36);
            this.aboutToolStripMenuItem.Text = "Справка";
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(263, 38);
            this.aboutToolStripMenuItem1.Text = "О программе";
            // 
            // mainBox
            // 
            this.mainBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.mainBox.Controls.Add(this.removeDeadVarsCheckBox);
            this.mainBox.Controls.Add(this.stopButton);
            this.mainBox.Controls.Add(this.iterativeAlgoLabel);
            this.mainBox.Controls.Add(this.iterativeAlgoList);
            this.mainBox.Controls.Add(this.optimizationsLabel);
            this.mainBox.Controls.Add(this.compileButton);
            this.mainBox.Controls.Add(this.runButton);
            this.mainBox.Controls.Add(this.toggleOptsButton);
            this.mainBox.Controls.Add(this.optsList);
            this.mainBox.Location = new System.Drawing.Point(14, 42);
            this.mainBox.Margin = new System.Windows.Forms.Padding(4);
            this.mainBox.Name = "mainBox";
            this.mainBox.Padding = new System.Windows.Forms.Padding(4);
            this.mainBox.Size = new System.Drawing.Size(438, 822);
            this.mainBox.TabIndex = 1;
            this.mainBox.TabStop = false;
            this.mainBox.Text = "Панель управления";
            // 
            // removeDeadVarsCheckBox
            // 
            this.removeDeadVarsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeDeadVarsCheckBox.AutoSize = true;
            this.removeDeadVarsCheckBox.Location = new System.Drawing.Point(13, 365);
            this.removeDeadVarsCheckBox.Margin = new System.Windows.Forms.Padding(6);
            this.removeDeadVarsCheckBox.Name = "removeDeadVarsCheckBox";
            this.removeDeadVarsCheckBox.Size = new System.Drawing.Size(378, 29);
            this.removeDeadVarsCheckBox.TabIndex = 10;
            this.removeDeadVarsCheckBox.Text = "Удаление \"мертвых\" переменных";
            this.removeDeadVarsCheckBox.UseVisualStyleBackColor = true;
            // 
            // stopButton
            // 
            this.stopButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.stopButton.Location = new System.Drawing.Point(150, 772);
            this.stopButton.Margin = new System.Windows.Forms.Padding(4);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(134, 38);
            this.stopButton.TabIndex = 9;
            this.stopButton.Text = "Стоп";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // iterativeAlgoLabel
            // 
            this.iterativeAlgoLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iterativeAlgoLabel.AutoSize = true;
            this.iterativeAlgoLabel.Location = new System.Drawing.Point(8, 400);
            this.iterativeAlgoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.iterativeAlgoLabel.Name = "iterativeAlgoLabel";
            this.iterativeAlgoLabel.Size = new System.Drawing.Size(274, 25);
            this.iterativeAlgoLabel.TabIndex = 8;
            this.iterativeAlgoLabel.Text = "Итерационные алгоритмы";
            // 
            // iterativeAlgoList
            // 
            this.iterativeAlgoList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.iterativeAlgoList.CheckOnClick = true;
            this.iterativeAlgoList.FormattingEnabled = true;
            this.iterativeAlgoList.Location = new System.Drawing.Point(13, 443);
            this.iterativeAlgoList.Margin = new System.Windows.Forms.Padding(4);
            this.iterativeAlgoList.Name = "iterativeAlgoList";
            this.iterativeAlgoList.Size = new System.Drawing.Size(417, 316);
            this.iterativeAlgoList.TabIndex = 7;
            // 
            // optimizationsLabel
            // 
            this.optimizationsLabel.AutoSize = true;
            this.optimizationsLabel.Location = new System.Drawing.Point(8, 88);
            this.optimizationsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.optimizationsLabel.Name = "optimizationsLabel";
            this.optimizationsLabel.Size = new System.Drawing.Size(148, 25);
            this.optimizationsLabel.TabIndex = 6;
            this.optimizationsLabel.Text = "Оптимизации";
            // 
            // compileButton
            // 
            this.compileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.compileButton.Location = new System.Drawing.Point(6, 772);
            this.compileButton.Margin = new System.Windows.Forms.Padding(4);
            this.compileButton.Name = "compileButton";
            this.compileButton.Size = new System.Drawing.Size(134, 38);
            this.compileButton.TabIndex = 5;
            this.compileButton.Text = "Сборка";
            this.compileButton.UseVisualStyleBackColor = true;
            // 
            // runButton
            // 
            this.runButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.runButton.Enabled = false;
            this.runButton.Location = new System.Drawing.Point(294, 772);
            this.runButton.Margin = new System.Windows.Forms.Padding(4);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(134, 38);
            this.runButton.TabIndex = 4;
            this.runButton.Text = "Запуск";
            this.runButton.UseVisualStyleBackColor = true;
            // 
            // toggleOptsButton
            // 
            this.toggleOptsButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toggleOptsButton.Location = new System.Drawing.Point(13, 32);
            this.toggleOptsButton.Margin = new System.Windows.Forms.Padding(4);
            this.toggleOptsButton.Name = "toggleOptsButton";
            this.toggleOptsButton.Size = new System.Drawing.Size(417, 42);
            this.toggleOptsButton.TabIndex = 3;
            this.toggleOptsButton.Text = "Переключить все";
            this.toggleOptsButton.UseVisualStyleBackColor = true;
            // 
            // optsList
            // 
            this.optsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.optsList.CheckOnClick = true;
            this.optsList.FormattingEnabled = true;
            this.optsList.Location = new System.Drawing.Point(13, 117);
            this.optsList.Margin = new System.Windows.Forms.Padding(4);
            this.optsList.Name = "optsList";
            this.optsList.Size = new System.Drawing.Size(417, 238);
            this.optsList.TabIndex = 2;
            // 
            // outBox
            // 
            this.outBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outBox.Controls.Add(this.outTextBox);
            this.outBox.Location = new System.Drawing.Point(8, 15);
            this.outBox.Margin = new System.Windows.Forms.Padding(4);
            this.outBox.Name = "outBox";
            this.outBox.Padding = new System.Windows.Forms.Padding(4);
            this.outBox.Size = new System.Drawing.Size(1017, 168);
            this.outBox.TabIndex = 2;
            this.outBox.TabStop = false;
            this.outBox.Text = "Вывод";
            // 
            // outTextBox
            // 
            this.outTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.outTextBox.BackColor = System.Drawing.Color.White;
            this.outTextBox.Location = new System.Drawing.Point(6, 29);
            this.outTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.outTextBox.Multiline = true;
            this.outTextBox.Name = "outTextBox";
            this.outTextBox.ReadOnly = true;
            this.outTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.outTextBox.Size = new System.Drawing.Size(999, 127);
            this.outTextBox.TabIndex = 0;
            // 
            // tabsControl
            // 
            this.tabsControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabsControl.Controls.Add(this.inputPage);
            this.tabsControl.Controls.Add(this.ILCodePage);
            this.tabsControl.Controls.Add(this.threeAddrPage);
            this.tabsControl.Controls.Add(this.CFGPage);
            this.tabsControl.Controls.Add(this.ASTPage);
            this.tabsControl.Controls.Add(this.iterativeAlgoPage);
            this.tabsControl.Controls.Add(this.CFGEdgeClassificationPage);
            this.tabsControl.Location = new System.Drawing.Point(4, 4);
            this.tabsControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabsControl.Name = "tabsControl";
            this.tabsControl.SelectedIndex = 0;
            this.tabsControl.Size = new System.Drawing.Size(1027, 631);
            this.tabsControl.TabIndex = 3;
            // 
            // inputPage
            // 
            this.inputPage.Controls.Add(this.inputTextBox);
            this.inputPage.Location = new System.Drawing.Point(8, 39);
            this.inputPage.Margin = new System.Windows.Forms.Padding(4);
            this.inputPage.Name = "inputPage";
            this.inputPage.Padding = new System.Windows.Forms.Padding(4);
            this.inputPage.Size = new System.Drawing.Size(1011, 584);
            this.inputPage.TabIndex = 0;
            this.inputPage.Text = "Исходный код";
            this.inputPage.UseVisualStyleBackColor = true;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputTextBox.Location = new System.Drawing.Point(4, 4);
            this.inputTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(1003, 576);
            this.inputTextBox.TabIndex = 0;
            this.inputTextBox.Text = "";
            // 
            // ILCodePage
            // 
            this.ILCodePage.Controls.Add(this.ILCodeTextBox);
            this.ILCodePage.Location = new System.Drawing.Point(8, 39);
            this.ILCodePage.Margin = new System.Windows.Forms.Padding(4);
            this.ILCodePage.Name = "ILCodePage";
            this.ILCodePage.Padding = new System.Windows.Forms.Padding(8);
            this.ILCodePage.Size = new System.Drawing.Size(1011, 584);
            this.ILCodePage.TabIndex = 1;
            this.ILCodePage.Text = "IL-код";
            this.ILCodePage.UseVisualStyleBackColor = true;
            // 
            // ILCodeTextBox
            // 
            this.ILCodeTextBox.BackColor = System.Drawing.Color.White;
            this.ILCodeTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ILCodeTextBox.Location = new System.Drawing.Point(8, 8);
            this.ILCodeTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.ILCodeTextBox.Name = "ILCodeTextBox";
            this.ILCodeTextBox.ReadOnly = true;
            this.ILCodeTextBox.Size = new System.Drawing.Size(995, 568);
            this.ILCodeTextBox.TabIndex = 0;
            this.ILCodeTextBox.Text = "";
            // 
            // threeAddrPage
            // 
            this.threeAddrPage.Controls.Add(this.threeAddrTextBox);
            this.threeAddrPage.Location = new System.Drawing.Point(8, 39);
            this.threeAddrPage.Margin = new System.Windows.Forms.Padding(4);
            this.threeAddrPage.Name = "threeAddrPage";
            this.threeAddrPage.Padding = new System.Windows.Forms.Padding(8);
            this.threeAddrPage.Size = new System.Drawing.Size(1011, 584);
            this.threeAddrPage.TabIndex = 2;
            this.threeAddrPage.Text = "Трехадресный код";
            this.threeAddrPage.UseVisualStyleBackColor = true;
            // 
            // threeAddrTextBox
            // 
            this.threeAddrTextBox.BackColor = System.Drawing.Color.White;
            this.threeAddrTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.threeAddrTextBox.Location = new System.Drawing.Point(8, 8);
            this.threeAddrTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.threeAddrTextBox.Name = "threeAddrTextBox";
            this.threeAddrTextBox.ReadOnly = true;
            this.threeAddrTextBox.Size = new System.Drawing.Size(995, 568);
            this.threeAddrTextBox.TabIndex = 0;
            this.threeAddrTextBox.Text = "";
            // 
            // CFGPage
            // 
            this.CFGPage.Controls.Add(this.cfgScalePanel);
            this.CFGPage.Controls.Add(this.cfgSaveButton);
            this.CFGPage.Controls.Add(this.cfgPanel);
            this.CFGPage.Location = new System.Drawing.Point(8, 39);
            this.CFGPage.Margin = new System.Windows.Forms.Padding(4);
            this.CFGPage.Name = "CFGPage";
            this.CFGPage.Padding = new System.Windows.Forms.Padding(8);
            this.CFGPage.Size = new System.Drawing.Size(1011, 584);
            this.CFGPage.TabIndex = 3;
            this.CFGPage.Text = "CFG";
            this.CFGPage.UseVisualStyleBackColor = true;
            // 
            // cfgScalePanel
            // 
            this.cfgScalePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cfgScalePanel.Controls.Add(this.cfgScaleBar);
            this.cfgScalePanel.Location = new System.Drawing.Point(10, 528);
            this.cfgScalePanel.Margin = new System.Windows.Forms.Padding(12);
            this.cfgScalePanel.Name = "cfgScalePanel";
            this.cfgScalePanel.Size = new System.Drawing.Size(817, 44);
            this.cfgScalePanel.TabIndex = 5;
            // 
            // cfgScaleBar
            // 
            this.cfgScaleBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cfgScaleBar.BackColor = System.Drawing.Color.White;
            this.cfgScaleBar.Enabled = false;
            this.cfgScaleBar.Location = new System.Drawing.Point(6, 3);
            this.cfgScaleBar.Margin = new System.Windows.Forms.Padding(6);
            this.cfgScaleBar.Maximum = 100;
            this.cfgScaleBar.Name = "cfgScaleBar";
            this.cfgScaleBar.Size = new System.Drawing.Size(805, 90);
            this.cfgScaleBar.TabIndex = 2;
            this.cfgScaleBar.TickFrequency = 10;
            this.cfgScaleBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.cfgScaleBar.Value = 100;
            // 
            // cfgSaveButton
            // 
            this.cfgSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cfgSaveButton.Enabled = false;
            this.cfgSaveButton.Location = new System.Drawing.Point(851, 528);
            this.cfgSaveButton.Margin = new System.Windows.Forms.Padding(12);
            this.cfgSaveButton.Name = "cfgSaveButton";
            this.cfgSaveButton.Size = new System.Drawing.Size(150, 44);
            this.cfgSaveButton.TabIndex = 4;
            this.cfgSaveButton.Text = "Save";
            this.cfgSaveButton.UseVisualStyleBackColor = true;
            // 
            // cfgPanel
            // 
            this.cfgPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cfgPanel.AutoScroll = true;
            this.cfgPanel.Controls.Add(this.CFGPictureBox);
            this.cfgPanel.Location = new System.Drawing.Point(10, 10);
            this.cfgPanel.Margin = new System.Windows.Forms.Padding(6);
            this.cfgPanel.Name = "cfgPanel";
            this.cfgPanel.Size = new System.Drawing.Size(987, 500);
            this.cfgPanel.TabIndex = 1;
            // 
            // CFGPictureBox
            // 
            this.CFGPictureBox.Location = new System.Drawing.Point(6, 6);
            this.CFGPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.CFGPictureBox.Name = "CFGPictureBox";
            this.CFGPictureBox.Size = new System.Drawing.Size(140, 72);
            this.CFGPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.CFGPictureBox.TabIndex = 0;
            this.CFGPictureBox.TabStop = false;
            // 
            // ASTPage
            // 
            this.ASTPage.Controls.Add(this.astPanel);
            this.ASTPage.Controls.Add(this.astSaveButton);
            this.ASTPage.Controls.Add(this.astTabPanel);
            this.ASTPage.Location = new System.Drawing.Point(8, 39);
            this.ASTPage.Margin = new System.Windows.Forms.Padding(4);
            this.ASTPage.Name = "ASTPage";
            this.ASTPage.Padding = new System.Windows.Forms.Padding(8);
            this.ASTPage.Size = new System.Drawing.Size(1011, 584);
            this.ASTPage.TabIndex = 4;
            this.ASTPage.Text = "AST";
            this.ASTPage.UseVisualStyleBackColor = true;
            // 
            // astPanel
            // 
            this.astPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.astPanel.Controls.Add(this.astTrackBar);
            this.astPanel.Location = new System.Drawing.Point(10, 528);
            this.astPanel.Margin = new System.Windows.Forms.Padding(12);
            this.astPanel.Name = "astPanel";
            this.astPanel.Size = new System.Drawing.Size(817, 44);
            this.astPanel.TabIndex = 5;
            // 
            // astTrackBar
            // 
            this.astTrackBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.astTrackBar.BackColor = System.Drawing.Color.White;
            this.astTrackBar.Enabled = false;
            this.astTrackBar.Location = new System.Drawing.Point(6, 3);
            this.astTrackBar.Margin = new System.Windows.Forms.Padding(6);
            this.astTrackBar.Maximum = 100;
            this.astTrackBar.Name = "astTrackBar";
            this.astTrackBar.Size = new System.Drawing.Size(805, 90);
            this.astTrackBar.TabIndex = 2;
            this.astTrackBar.TickFrequency = 10;
            this.astTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.astTrackBar.Value = 100;
            // 
            // astSaveButton
            // 
            this.astSaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.astSaveButton.Enabled = false;
            this.astSaveButton.Location = new System.Drawing.Point(851, 528);
            this.astSaveButton.Margin = new System.Windows.Forms.Padding(12);
            this.astSaveButton.Name = "astSaveButton";
            this.astSaveButton.Size = new System.Drawing.Size(150, 44);
            this.astSaveButton.TabIndex = 4;
            this.astSaveButton.Text = "Save";
            this.astSaveButton.UseVisualStyleBackColor = true;
            // 
            // astTabPanel
            // 
            this.astTabPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.astTabPanel.AutoScroll = true;
            this.astTabPanel.Controls.Add(this.ASTPictureBox);
            this.astTabPanel.Location = new System.Drawing.Point(10, 10);
            this.astTabPanel.Margin = new System.Windows.Forms.Padding(6);
            this.astTabPanel.Name = "astTabPanel";
            this.astTabPanel.Size = new System.Drawing.Size(987, 500);
            this.astTabPanel.TabIndex = 1;
            // 
            // ASTPictureBox
            // 
            this.ASTPictureBox.Location = new System.Drawing.Point(6, 6);
            this.ASTPictureBox.Margin = new System.Windows.Forms.Padding(6);
            this.ASTPictureBox.Name = "ASTPictureBox";
            this.ASTPictureBox.Size = new System.Drawing.Size(140, 72);
            this.ASTPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ASTPictureBox.TabIndex = 0;
            this.ASTPictureBox.TabStop = false;
            // 
            // iterativeAlgoPage
            // 
            this.iterativeAlgoPage.Controls.Add(this.iterativeAlgoTextBox);
            this.iterativeAlgoPage.Location = new System.Drawing.Point(8, 39);
            this.iterativeAlgoPage.Margin = new System.Windows.Forms.Padding(6);
            this.iterativeAlgoPage.Name = "iterativeAlgoPage";
            this.iterativeAlgoPage.Padding = new System.Windows.Forms.Padding(12);
            this.iterativeAlgoPage.Size = new System.Drawing.Size(1011, 584);
            this.iterativeAlgoPage.TabIndex = 5;
            this.iterativeAlgoPage.Text = "Итер. алгоритм";
            this.iterativeAlgoPage.UseVisualStyleBackColor = true;
            // 
            // iterativeAlgoTextBox
            // 
            this.iterativeAlgoTextBox.BackColor = System.Drawing.Color.White;
            this.iterativeAlgoTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.iterativeAlgoTextBox.Location = new System.Drawing.Point(12, 12);
            this.iterativeAlgoTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.iterativeAlgoTextBox.Name = "iterativeAlgoTextBox";
            this.iterativeAlgoTextBox.ReadOnly = true;
            this.iterativeAlgoTextBox.Size = new System.Drawing.Size(987, 560);
            this.iterativeAlgoTextBox.TabIndex = 1;
            this.iterativeAlgoTextBox.Text = "";
            // 
            // CFGEdgeClassificationPage
            // 
            this.CFGEdgeClassificationPage.Controls.Add(this.CFGEdgeClassificationTextBox);
            this.CFGEdgeClassificationPage.Location = new System.Drawing.Point(8, 39);
            this.CFGEdgeClassificationPage.Margin = new System.Windows.Forms.Padding(6);
            this.CFGEdgeClassificationPage.Name = "CFGEdgeClassificationPage";
            this.CFGEdgeClassificationPage.Padding = new System.Windows.Forms.Padding(12);
            this.CFGEdgeClassificationPage.Size = new System.Drawing.Size(1011, 584);
            this.CFGEdgeClassificationPage.TabIndex = 6;
            this.CFGEdgeClassificationPage.Text = "Классификация рёбер CFG";
            this.CFGEdgeClassificationPage.UseVisualStyleBackColor = true;
            // 
            // CFGEdgeClassificationTextBox
            // 
            this.CFGEdgeClassificationTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CFGEdgeClassificationTextBox.Location = new System.Drawing.Point(12, 12);
            this.CFGEdgeClassificationTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.CFGEdgeClassificationTextBox.Name = "CFGEdgeClassificationTextBox";
            this.CFGEdgeClassificationTextBox.Size = new System.Drawing.Size(987, 560);
            this.CFGEdgeClassificationTextBox.TabIndex = 0;
            this.CFGEdgeClassificationTextBox.Text = "";
            // 
            // splitContainer
            // 
            this.splitContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer.Location = new System.Drawing.Point(460, 42);
            this.splitContainer.Margin = new System.Windows.Forms.Padding(4);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.tabsControl);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.outBox);
            this.splitContainer.Size = new System.Drawing.Size(1035, 823);
            this.splitContainer.SplitterDistance = 635;
            this.splitContainer.TabIndex = 4;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1507, 869);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.mainBox);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "MainWindow";
            this.Text = "Среда разработки";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainBox.ResumeLayout(false);
            this.mainBox.PerformLayout();
            this.outBox.ResumeLayout(false);
            this.outBox.PerformLayout();
            this.tabsControl.ResumeLayout(false);
            this.inputPage.ResumeLayout(false);
            this.ILCodePage.ResumeLayout(false);
            this.threeAddrPage.ResumeLayout(false);
            this.CFGPage.ResumeLayout(false);
            this.cfgScalePanel.ResumeLayout(false);
            this.cfgScalePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cfgScaleBar)).EndInit();
            this.cfgPanel.ResumeLayout(false);
            this.cfgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CFGPictureBox)).EndInit();
            this.ASTPage.ResumeLayout(false);
            this.astPanel.ResumeLayout(false);
            this.astPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.astTrackBar)).EndInit();
            this.astTabPanel.ResumeLayout(false);
            this.astTabPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ASTPictureBox)).EndInit();
            this.iterativeAlgoPage.ResumeLayout(false);
            this.CFGEdgeClassificationPage.ResumeLayout(false);
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.GroupBox mainBox;
        private System.Windows.Forms.Button toggleOptsButton;
        private System.Windows.Forms.CheckedListBox optsList;
        private System.Windows.Forms.GroupBox outBox;
        private System.Windows.Forms.TextBox outTextBox;
        private System.Windows.Forms.TabControl tabsControl;
        private System.Windows.Forms.TabPage inputPage;
        private System.Windows.Forms.TabPage ILCodePage;
        private System.Windows.Forms.TabPage threeAddrPage;
        private System.Windows.Forms.TabPage CFGPage;
        private System.Windows.Forms.SplitContainer splitContainer;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Button compileButton;
        private System.Windows.Forms.Label optimizationsLabel;
        private System.Windows.Forms.RichTextBox inputTextBox;
        private System.Windows.Forms.RichTextBox ILCodeTextBox;
        private System.Windows.Forms.RichTextBox threeAddrTextBox;
        private System.Windows.Forms.PictureBox CFGPictureBox;
        private System.Windows.Forms.Button cfgSaveButton;
        private System.Windows.Forms.TrackBar cfgScaleBar;
        private System.Windows.Forms.Panel cfgPanel;
        private System.Windows.Forms.Panel cfgScalePanel;
        private System.Windows.Forms.TabPage ASTPage;
        private System.Windows.Forms.Panel astPanel;
        private System.Windows.Forms.TrackBar astTrackBar;
        private System.Windows.Forms.Button astSaveButton;
        private System.Windows.Forms.Panel astTabPanel;
        private System.Windows.Forms.PictureBox ASTPictureBox;
        private System.Windows.Forms.TabPage iterativeAlgoPage;
        private System.Windows.Forms.RichTextBox iterativeAlgoTextBox;
        private System.Windows.Forms.Label iterativeAlgoLabel;
        private System.Windows.Forms.CheckedListBox iterativeAlgoList;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.CheckBox removeDeadVarsCheckBox;
        private System.Windows.Forms.TabPage CFGEdgeClassificationPage;
        private System.Windows.Forms.RichTextBox CFGEdgeClassificationTextBox;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}