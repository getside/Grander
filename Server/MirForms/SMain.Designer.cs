using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Server
{
    partial class SMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SMain));
            this.MainTabs = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DebugLogTextBox = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GlobalMessageButton = new System.Windows.Forms.Button();
            this.GlobalMessageTextBox = new System.Windows.Forms.TextBox();
            this.ChatLogTextBox = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.PlayersOnlineListView = new Server.ListViewNF();
            this.indexHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.levelHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.classHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.genderHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StatusBar = new System.Windows.Forms.StatusStrip();
            this.PlayersLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MonsterLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.ConnectionsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.CycleDelayLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.MainMenu = new System.Windows.Forms.MenuStrip();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rebootServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.closeServerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.databaseFormsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mapInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.itemInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monsterInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nPCInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.questInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.magicInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameshopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.serverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.balanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dragonSystemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guildsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fishingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.goodsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refiningToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relationshipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mentorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.conquestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.respawnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.monsterTunerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.InterfaceTimer = new System.Windows.Forms.Timer(this.components);
            this.MainTabs.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.StatusBar.SuspendLayout();
            this.MainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainTabs
            // 
            this.MainTabs.Controls.Add(this.tabPage1);
            this.MainTabs.Controls.Add(this.tabPage2);
            this.MainTabs.Controls.Add(this.tabPage3);
            this.MainTabs.Controls.Add(this.tabPage4);
            this.MainTabs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTabs.Location = new System.Drawing.Point(0, 24);
            this.MainTabs.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainTabs.Name = "MainTabs";
            this.MainTabs.SelectedIndex = 0;
            this.MainTabs.Size = new System.Drawing.Size(728, 407);
            this.MainTabs.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.LogTextBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(720, 379);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "서버기록";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // LogTextBox
            // 
            this.LogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogTextBox.Location = new System.Drawing.Point(3, 4);
            this.LogTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ReadOnly = true;
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.LogTextBox.Size = new System.Drawing.Size(714, 371);
            this.LogTextBox.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DebugLogTextBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(720, 379);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "디버그기록";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DebugLogTextBox
            // 
            this.DebugLogTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DebugLogTextBox.Location = new System.Drawing.Point(3, 4);
            this.DebugLogTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DebugLogTextBox.Multiline = true;
            this.DebugLogTextBox.Name = "DebugLogTextBox";
            this.DebugLogTextBox.ReadOnly = true;
            this.DebugLogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DebugLogTextBox.Size = new System.Drawing.Size(714, 371);
            this.DebugLogTextBox.TabIndex = 3;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox1);
            this.tabPage3.Controls.Add(this.ChatLogTextBox);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Size = new System.Drawing.Size(720, 379);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "채팅기록";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GlobalMessageButton);
            this.groupBox1.Controls.Add(this.GlobalMessageTextBox);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 323);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(714, 52);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "서버 메세지";
            // 
            // GlobalMessageButton
            // 
            this.GlobalMessageButton.Location = new System.Drawing.Point(611, 19);
            this.GlobalMessageButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GlobalMessageButton.Name = "GlobalMessageButton";
            this.GlobalMessageButton.Size = new System.Drawing.Size(97, 24);
            this.GlobalMessageButton.TabIndex = 0;
            this.GlobalMessageButton.Text = "전송";
            this.GlobalMessageButton.UseVisualStyleBackColor = true;
            this.GlobalMessageButton.Click += new System.EventHandler(this.GlobalMessageButton_Click);
            // 
            // GlobalMessageTextBox
            // 
            this.GlobalMessageTextBox.Location = new System.Drawing.Point(7, 20);
            this.GlobalMessageTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.GlobalMessageTextBox.Name = "GlobalMessageTextBox";
            this.GlobalMessageTextBox.Size = new System.Drawing.Size(598, 23);
            this.GlobalMessageTextBox.TabIndex = 0;
            // 
            // ChatLogTextBox
            // 
            this.ChatLogTextBox.Location = new System.Drawing.Point(3, 4);
            this.ChatLogTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ChatLogTextBox.Multiline = true;
            this.ChatLogTextBox.Name = "ChatLogTextBox";
            this.ChatLogTextBox.ReadOnly = true;
            this.ChatLogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ChatLogTextBox.Size = new System.Drawing.Size(714, 310);
            this.ChatLogTextBox.TabIndex = 4;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage4.Controls.Add(this.PlayersOnlineListView);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Size = new System.Drawing.Size(720, 379);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "플레이어 현황";
            // 
            // PlayersOnlineListView
            // 
            this.PlayersOnlineListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.PlayersOnlineListView.BackColor = System.Drawing.SystemColors.Window;
            this.PlayersOnlineListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.indexHeader,
            this.nameHeader,
            this.levelHeader,
            this.classHeader,
            this.genderHeader});
            this.PlayersOnlineListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlayersOnlineListView.FullRowSelect = true;
            this.PlayersOnlineListView.GridLines = true;
            this.PlayersOnlineListView.Location = new System.Drawing.Point(3, 4);
            this.PlayersOnlineListView.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.PlayersOnlineListView.Name = "PlayersOnlineListView";
            this.PlayersOnlineListView.Size = new System.Drawing.Size(714, 371);
            this.PlayersOnlineListView.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.PlayersOnlineListView.TabIndex = 0;
            this.PlayersOnlineListView.UseCompatibleStateImageBehavior = false;
            this.PlayersOnlineListView.View = System.Windows.Forms.View.Details;
            this.PlayersOnlineListView.ColumnWidthChanging += new System.Windows.Forms.ColumnWidthChangingEventHandler(this.PlayersOnlineListView_ColumnWidthChanging);
            this.PlayersOnlineListView.DoubleClick += new System.EventHandler(this.PlayersOnlineListView_DoubleClick);
            // 
            // indexHeader
            // 
            this.indexHeader.Text = "인덱스";
            this.indexHeader.Width = 71;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "플레이어명";
            this.nameHeader.Width = 93;
            // 
            // levelHeader
            // 
            this.levelHeader.Text = "레벨";
            this.levelHeader.Width = 90;
            // 
            // classHeader
            // 
            this.classHeader.Text = "직업";
            this.classHeader.Width = 100;
            // 
            // genderHeader
            // 
            this.genderHeader.Text = "성별";
            this.genderHeader.Width = 98;
            // 
            // StatusBar
            // 
            this.StatusBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PlayersLabel,
            this.MonsterLabel,
            this.ConnectionsLabel,
            this.CycleDelayLabel});
            this.StatusBar.Location = new System.Drawing.Point(0, 431);
            this.StatusBar.Name = "StatusBar";
            this.StatusBar.Padding = new System.Windows.Forms.Padding(1, 0, 16, 0);
            this.StatusBar.Size = new System.Drawing.Size(728, 24);
            this.StatusBar.SizingGrip = false;
            this.StatusBar.TabIndex = 4;
            this.StatusBar.Text = "statusStrip1";
            // 
            // PlayersLabel
            // 
            this.PlayersLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.PlayersLabel.Name = "PlayersLabel";
            this.PlayersLabel.Size = new System.Drawing.Size(62, 19);
            this.PlayersLabel.Text = "Players: 0";
            // 
            // MonsterLabel
            // 
            this.MonsterLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.MonsterLabel.Name = "MonsterLabel";
            this.MonsterLabel.Size = new System.Drawing.Size(74, 19);
            this.MonsterLabel.Text = "Monsters: 0";
            // 
            // ConnectionsLabel
            // 
            this.ConnectionsLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.ConnectionsLabel.Name = "ConnectionsLabel";
            this.ConnectionsLabel.Size = new System.Drawing.Size(92, 19);
            this.ConnectionsLabel.Text = "Connections: 0";
            // 
            // CycleDelayLabel
            // 
            this.CycleDelayLabel.BorderSides = ((System.Windows.Forms.ToolStripStatusLabelBorderSides)((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left | System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) 
            | System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom)));
            this.CycleDelayLabel.Name = "CycleDelayLabel";
            this.CycleDelayLabel.Size = new System.Drawing.Size(84, 19);
            this.CycleDelayLabel.Text = "CycleDelay: 0";
            // 
            // MainMenu
            // 
            this.MainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.controlToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.databaseFormsToolStripMenuItem,
            this.configToolStripMenuItem1});
            this.MainMenu.Location = new System.Drawing.Point(0, 0);
            this.MainMenu.Name = "MainMenu";
            this.MainMenu.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.MainMenu.Size = new System.Drawing.Size(728, 24);
            this.MainMenu.TabIndex = 3;
            this.MainMenu.Text = "menuStrip1";
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startServerToolStripMenuItem,
            this.stopServerToolStripMenuItem,
            this.rebootServerToolStripMenuItem,
            this.toolStripMenuItem1,
            this.closeServerToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.controlToolStripMenuItem.Text = "컨트롤";
            // 
            // startServerToolStripMenuItem
            // 
            this.startServerToolStripMenuItem.Name = "startServerToolStripMenuItem";
            this.startServerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.startServerToolStripMenuItem.Text = "서버 시작";
            this.startServerToolStripMenuItem.Click += new System.EventHandler(this.startServerToolStripMenuItem_Click);
            // 
            // stopServerToolStripMenuItem
            // 
            this.stopServerToolStripMenuItem.Name = "stopServerToolStripMenuItem";
            this.stopServerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.stopServerToolStripMenuItem.Text = "서버 정지";
            this.stopServerToolStripMenuItem.Click += new System.EventHandler(this.stopServerToolStripMenuItem_Click);
            // 
            // rebootServerToolStripMenuItem
            // 
            this.rebootServerToolStripMenuItem.Name = "rebootServerToolStripMenuItem";
            this.rebootServerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.rebootServerToolStripMenuItem.Text = "서버 재시작";
            this.rebootServerToolStripMenuItem.Click += new System.EventHandler(this.rebootServerToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(149, 6);
            // 
            // closeServerToolStripMenuItem
            // 
            this.closeServerToolStripMenuItem.Name = "closeServerToolStripMenuItem";
            this.closeServerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeServerToolStripMenuItem.Text = "서버 종료";
            this.closeServerToolStripMenuItem.Click += new System.EventHandler(this.closeServerToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.accountToolStripMenuItem.Text = "계정관리";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.accountToolStripMenuItem_Click);
            // 
            // databaseFormsToolStripMenuItem
            // 
            this.databaseFormsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mapInfoToolStripMenuItem,
            this.itemInfoToolStripMenuItem,
            this.monsterInfoToolStripMenuItem,
            this.nPCInfoToolStripMenuItem,
            this.questInfoToolStripMenuItem,
            this.magicInfoToolStripMenuItem,
            this.gameshopToolStripMenuItem});
            this.databaseFormsToolStripMenuItem.Name = "databaseFormsToolStripMenuItem";
            this.databaseFormsToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.databaseFormsToolStripMenuItem.Text = "데이터베이스";
            // 
            // mapInfoToolStripMenuItem
            // 
            this.mapInfoToolStripMenuItem.Name = "mapInfoToolStripMenuItem";
            this.mapInfoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.mapInfoToolStripMenuItem.Text = "지도 (Map)";
            this.mapInfoToolStripMenuItem.Click += new System.EventHandler(this.mapInfoToolStripMenuItem_Click);
            // 
            // itemInfoToolStripMenuItem
            // 
            this.itemInfoToolStripMenuItem.Name = "itemInfoToolStripMenuItem";
            this.itemInfoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.itemInfoToolStripMenuItem.Text = "아이템 (Item)";
            this.itemInfoToolStripMenuItem.Click += new System.EventHandler(this.itemInfoToolStripMenuItem_Click);
            // 
            // monsterInfoToolStripMenuItem
            // 
            this.monsterInfoToolStripMenuItem.Name = "monsterInfoToolStripMenuItem";
            this.monsterInfoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.monsterInfoToolStripMenuItem.Text = "몬스터 (Monster)";
            this.monsterInfoToolStripMenuItem.Click += new System.EventHandler(this.monsterInfoToolStripMenuItem_Click);
            // 
            // nPCInfoToolStripMenuItem
            // 
            this.nPCInfoToolStripMenuItem.Name = "nPCInfoToolStripMenuItem";
            this.nPCInfoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.nPCInfoToolStripMenuItem.Text = "엔피씨 (NPC)";
            this.nPCInfoToolStripMenuItem.Click += new System.EventHandler(this.nPCInfoToolStripMenuItem_Click);
            // 
            // questInfoToolStripMenuItem
            // 
            this.questInfoToolStripMenuItem.Name = "questInfoToolStripMenuItem";
            this.questInfoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.questInfoToolStripMenuItem.Text = "퀘스트 (Quest)";
            this.questInfoToolStripMenuItem.Click += new System.EventHandler(this.questInfoToolStripMenuItem_Click);
            // 
            // magicInfoToolStripMenuItem
            // 
            this.magicInfoToolStripMenuItem.Name = "magicInfoToolStripMenuItem";
            this.magicInfoToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.magicInfoToolStripMenuItem.Text = "무공 (Skill)";
            this.magicInfoToolStripMenuItem.Click += new System.EventHandler(this.magicInfoToolStripMenuItem_Click);
            // 
            // gameshopToolStripMenuItem
            // 
            this.gameshopToolStripMenuItem.Name = "gameshopToolStripMenuItem";
            this.gameshopToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.gameshopToolStripMenuItem.Text = "환상점 (Cashshop)";
            this.gameshopToolStripMenuItem.Click += new System.EventHandler(this.gameshopToolStripMenuItem_Click);
            // 
            // configToolStripMenuItem1
            // 
            this.configToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serverToolStripMenuItem,
            this.balanceToolStripMenuItem,
            this.systemToolStripMenuItem,
            this.monsterTunerToolStripMenuItem});
            this.configToolStripMenuItem1.Name = "configToolStripMenuItem1";
            this.configToolStripMenuItem1.Size = new System.Drawing.Size(43, 20);
            this.configToolStripMenuItem1.Text = "설정";
            // 
            // serverToolStripMenuItem
            // 
            this.serverToolStripMenuItem.Name = "serverToolStripMenuItem";
            this.serverToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.serverToolStripMenuItem.Text = "서버 설정";
            this.serverToolStripMenuItem.Click += new System.EventHandler(this.serverToolStripMenuItem_Click);
            // 
            // balanceToolStripMenuItem
            // 
            this.balanceToolStripMenuItem.Name = "balanceToolStripMenuItem";
            this.balanceToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.balanceToolStripMenuItem.Text = "밸런스 설정";
            this.balanceToolStripMenuItem.Click += new System.EventHandler(this.balanceToolStripMenuItem_Click);
            // 
            // systemToolStripMenuItem
            // 
            this.systemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dragonSystemToolStripMenuItem,
            this.miningToolStripMenuItem,
            this.guildsToolStripMenuItem,
            this.fishingToolStripMenuItem,
            this.mailToolStripMenuItem,
            this.goodsToolStripMenuItem,
            this.refiningToolStripMenuItem,
            this.relationshipToolStripMenuItem,
            this.mentorToolStripMenuItem,
            this.gemToolStripMenuItem,
            this.conquestToolStripMenuItem,
            this.respawnsToolStripMenuItem});
            this.systemToolStripMenuItem.Name = "systemToolStripMenuItem";
            this.systemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.systemToolStripMenuItem.Text = "컨텐츠 설정";
            // 
            // dragonSystemToolStripMenuItem
            // 
            this.dragonSystemToolStripMenuItem.Name = "dragonSystemToolStripMenuItem";
            this.dragonSystemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.dragonSystemToolStripMenuItem.Text = "파천마룡 관리";
            this.dragonSystemToolStripMenuItem.Click += new System.EventHandler(this.dragonSystemToolStripMenuItem_Click);
            // 
            // miningToolStripMenuItem
            // 
            this.miningToolStripMenuItem.Name = "miningToolStripMenuItem";
            this.miningToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.miningToolStripMenuItem.Text = "광산 시스템";
            this.miningToolStripMenuItem.Click += new System.EventHandler(this.miningToolStripMenuItem_Click);
            // 
            // guildsToolStripMenuItem
            // 
            this.guildsToolStripMenuItem.Name = "guildsToolStripMenuItem";
            this.guildsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guildsToolStripMenuItem.Text = "문파 시스템";
            this.guildsToolStripMenuItem.Click += new System.EventHandler(this.guildsToolStripMenuItem_Click);
            // 
            // fishingToolStripMenuItem
            // 
            this.fishingToolStripMenuItem.Name = "fishingToolStripMenuItem";
            this.fishingToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.fishingToolStripMenuItem.Text = "낚시 시스템";
            this.fishingToolStripMenuItem.Click += new System.EventHandler(this.fishingToolStripMenuItem_Click);
            // 
            // mailToolStripMenuItem
            // 
            this.mailToolStripMenuItem.Name = "mailToolStripMenuItem";
            this.mailToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mailToolStripMenuItem.Text = "우편 시스템";
            this.mailToolStripMenuItem.Click += new System.EventHandler(this.mailToolStripMenuItem_Click);
            // 
            // goodsToolStripMenuItem
            // 
            this.goodsToolStripMenuItem.Name = "goodsToolStripMenuItem";
            this.goodsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.goodsToolStripMenuItem.Text = "Goods";
            this.goodsToolStripMenuItem.Click += new System.EventHandler(this.goodsToolStripMenuItem_Click);
            // 
            // refiningToolStripMenuItem
            // 
            this.refiningToolStripMenuItem.Name = "refiningToolStripMenuItem";
            this.refiningToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.refiningToolStripMenuItem.Text = "제련 시스템";
            this.refiningToolStripMenuItem.Click += new System.EventHandler(this.refiningToolStripMenuItem_Click);
            // 
            // relationshipToolStripMenuItem
            // 
            this.relationshipToolStripMenuItem.Name = "relationshipToolStripMenuItem";
            this.relationshipToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.relationshipToolStripMenuItem.Text = "연인 시스템";
            this.relationshipToolStripMenuItem.Click += new System.EventHandler(this.relationshipToolStripMenuItem_Click);
            // 
            // mentorToolStripMenuItem
            // 
            this.mentorToolStripMenuItem.Name = "mentorToolStripMenuItem";
            this.mentorToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mentorToolStripMenuItem.Text = "사제 시스템";
            this.mentorToolStripMenuItem.Click += new System.EventHandler(this.mentorToolStripMenuItem_Click);
            // 
            // gemToolStripMenuItem
            // 
            this.gemToolStripMenuItem.Name = "gemToolStripMenuItem";
            this.gemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.gemToolStripMenuItem.Text = "강화 시스템";
            this.gemToolStripMenuItem.Click += new System.EventHandler(this.gemToolStripMenuItem_Click);
            // 
            // conquestToolStripMenuItem
            // 
            this.conquestToolStripMenuItem.Name = "conquestToolStripMenuItem";
            this.conquestToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.conquestToolStripMenuItem.Text = "공성 시스템";
            this.conquestToolStripMenuItem.Click += new System.EventHandler(this.conquestToolStripMenuItem_Click);
            // 
            // respawnsToolStripMenuItem
            // 
            this.respawnsToolStripMenuItem.Name = "respawnsToolStripMenuItem";
            this.respawnsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.respawnsToolStripMenuItem.Text = "SpawnTick";
            this.respawnsToolStripMenuItem.Click += new System.EventHandler(this.respawnsToolStripMenuItem_Click);
            // 
            // monsterTunerToolStripMenuItem
            // 
            this.monsterTunerToolStripMenuItem.Name = "monsterTunerToolStripMenuItem";
            this.monsterTunerToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.monsterTunerToolStripMenuItem.Text = "몬스터 튜너";
            this.monsterTunerToolStripMenuItem.Click += new System.EventHandler(this.monsterTunerToolStripMenuItem_Click);
            // 
            // InterfaceTimer
            // 
            this.InterfaceTimer.Enabled = true;
            this.InterfaceTimer.Tick += new System.EventHandler(this.InterfaceTimer_Tick);
            // 
            // SMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(728, 455);
            this.Controls.Add(this.MainTabs);
            this.Controls.Add(this.StatusBar);
            this.Controls.Add(this.MainMenu);
            this.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SMain";
            this.Text = "Global Mir 2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SMain_FormClosing);
            this.Load += new System.EventHandler(this.SMain_Load);
            this.MainTabs.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.StatusBar.ResumeLayout(false);
            this.StatusBar.PerformLayout();
            this.MainMenu.ResumeLayout(false);
            this.MainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TabControl MainTabs;
        private TabPage tabPage1;
        private TextBox LogTextBox;
        private StatusStrip StatusBar;
        private ToolStripStatusLabel PlayersLabel;
        private ToolStripStatusLabel MonsterLabel;
        private ToolStripStatusLabel ConnectionsLabel;
        private MenuStrip MainMenu;
        private ToolStripMenuItem controlToolStripMenuItem;
        private ToolStripMenuItem startServerToolStripMenuItem;
        private ToolStripMenuItem stopServerToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem closeServerToolStripMenuItem;
        private Timer InterfaceTimer;
        private TabPage tabPage2;
        private TextBox DebugLogTextBox;
        private TabPage tabPage3;
        private TextBox ChatLogTextBox;
        private ToolStripMenuItem accountToolStripMenuItem;
        private ToolStripMenuItem databaseFormsToolStripMenuItem;
        private ToolStripMenuItem mapInfoToolStripMenuItem;
        private ToolStripMenuItem itemInfoToolStripMenuItem;
        private ToolStripMenuItem monsterInfoToolStripMenuItem;
        private ToolStripMenuItem nPCInfoToolStripMenuItem;
        private ToolStripMenuItem questInfoToolStripMenuItem;
        private ToolStripMenuItem configToolStripMenuItem1;
        private ToolStripMenuItem serverToolStripMenuItem;
        private ToolStripMenuItem balanceToolStripMenuItem;
        private ToolStripMenuItem systemToolStripMenuItem;
        private ToolStripMenuItem dragonSystemToolStripMenuItem;
        private ToolStripMenuItem guildsToolStripMenuItem;
        private ToolStripMenuItem miningToolStripMenuItem;
        private ToolStripMenuItem fishingToolStripMenuItem;
        private TabPage tabPage4;
        private GroupBox groupBox1;
        private Button GlobalMessageButton;
        private TextBox GlobalMessageTextBox;
        private ListViewNF PlayersOnlineListView;
        private ColumnHeader nameHeader;
        private ColumnHeader levelHeader;
        private ColumnHeader classHeader;
        private ColumnHeader genderHeader;
        private ColumnHeader indexHeader;
        private ToolStripMenuItem mailToolStripMenuItem;
        private ToolStripMenuItem goodsToolStripMenuItem;
        private ToolStripStatusLabel CycleDelayLabel;
        private ToolStripMenuItem magicInfoToolStripMenuItem;
        private ToolStripMenuItem refiningToolStripMenuItem;
        private ToolStripMenuItem relationshipToolStripMenuItem;
        private ToolStripMenuItem mentorToolStripMenuItem;
        private ToolStripMenuItem gameshopToolStripMenuItem;
        private ToolStripMenuItem gemToolStripMenuItem;
        private ToolStripMenuItem conquestToolStripMenuItem;
        private ToolStripMenuItem rebootServerToolStripMenuItem;
        private ToolStripMenuItem respawnsToolStripMenuItem;
        private ToolStripMenuItem monsterTunerToolStripMenuItem;
    }
}

