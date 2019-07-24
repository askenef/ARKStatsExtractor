﻿namespace ARKBreedingStats.uiControls
{
    partial class ModValuesManager
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
            this.lbModList = new System.Windows.Forms.ListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btRemoveMod = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbAvailableModFiles = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbAvailableForDownload = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.llbSteamPage = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.lbModId = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbModTag = new System.Windows.Forms.Label();
            this.lbModName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btMoveDown = new System.Windows.Forms.Button();
            this.btMoveUp = new System.Windows.Forms.Button();
            this.btRemoveModFile = new System.Windows.Forms.Button();
            this.btLoadModFile = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btAddMod = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbModList
            // 
            this.lbModList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbModList.FormattingEnabled = true;
            this.lbModList.Location = new System.Drawing.Point(3, 16);
            this.lbModList.Margin = new System.Windows.Forms.Padding(6);
            this.lbModList.Name = "lbModList";
            this.lbModList.Size = new System.Drawing.Size(231, 467);
            this.lbModList.TabIndex = 0;
            this.lbModList.SelectedIndexChanged += new System.EventHandler(this.LbModList_SelectedIndexChanged);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.btRemoveMod, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.groupBox3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.btClose, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.btAddMod, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(927, 492);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // btRemoveMod
            // 
            this.btRemoveMod.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btRemoveMod.Location = new System.Drawing.Point(246, 231);
            this.btRemoveMod.Name = "btRemoveMod";
            this.btRemoveMod.Size = new System.Drawing.Size(34, 23);
            this.btRemoveMod.TabIndex = 11;
            this.btRemoveMod.Text = "<";
            this.btRemoveMod.UseVisualStyleBackColor = true;
            this.btRemoveMod.Click += new System.EventHandler(this.BtRemoveMod_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbAvailableModFiles);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 3);
            this.groupBox3.Name = "groupBox3";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox3, 3);
            this.groupBox3.Size = new System.Drawing.Size(237, 486);
            this.groupBox3.TabIndex = 9;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Available mod files";
            // 
            // lbAvailableModFiles
            // 
            this.lbAvailableModFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbAvailableModFiles.FormattingEnabled = true;
            this.lbAvailableModFiles.Location = new System.Drawing.Point(3, 16);
            this.lbAvailableModFiles.Margin = new System.Windows.Forms.Padding(6);
            this.lbAvailableModFiles.Name = "lbAvailableModFiles";
            this.lbAvailableModFiles.Size = new System.Drawing.Size(231, 467);
            this.lbAvailableModFiles.TabIndex = 0;
            this.lbAvailableModFiles.SelectedIndexChanged += new System.EventHandler(this.LbAvailableModFiles_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbAvailableForDownload);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.llbSteamPage);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbModId);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.lbModTag);
            this.groupBox1.Controls.Add(this.lbModName);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(529, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 222);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Mod info";
            // 
            // lbAvailableForDownload
            // 
            this.lbAvailableForDownload.AutoSize = true;
            this.lbAvailableForDownload.Location = new System.Drawing.Point(6, 185);
            this.lbAvailableForDownload.Name = "lbAvailableForDownload";
            this.lbAvailableForDownload.Size = new System.Drawing.Size(219, 13);
            this.lbAvailableForDownload.TabIndex = 7;
            this.lbAvailableForDownload.Text = "(DL) value-file will be downloaded if selected.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mod-name";
            // 
            // llbSteamPage
            // 
            this.llbSteamPage.AutoSize = true;
            this.llbSteamPage.Location = new System.Drawing.Point(6, 79);
            this.llbSteamPage.Name = "llbSteamPage";
            this.llbSteamPage.Size = new System.Drawing.Size(88, 13);
            this.llbSteamPage.TabIndex = 6;
            this.llbSteamPage.TabStop = true;
            this.llbSteamPage.Text = "Mod Steam page";
            this.llbSteamPage.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LlbSteamPage_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mod id";
            // 
            // lbModId
            // 
            this.lbModId.AutoSize = true;
            this.lbModId.Location = new System.Drawing.Point(106, 61);
            this.lbModId.Name = "lbModId";
            this.lbModId.Size = new System.Drawing.Size(15, 13);
            this.lbModId.TabIndex = 5;
            this.lbModId.Text = "id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mod tag";
            // 
            // lbModTag
            // 
            this.lbModTag.AutoSize = true;
            this.lbModTag.Location = new System.Drawing.Point(106, 43);
            this.lbModTag.Name = "lbModTag";
            this.lbModTag.Size = new System.Drawing.Size(22, 13);
            this.lbModTag.TabIndex = 4;
            this.lbModTag.Text = "tag";
            // 
            // lbModName
            // 
            this.lbModName.AutoSize = true;
            this.lbModName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbModName.Location = new System.Drawing.Point(106, 25);
            this.lbModName.Name = "lbModName";
            this.lbModName.Size = new System.Drawing.Size(46, 16);
            this.lbModName.TabIndex = 3;
            this.lbModName.Text = "name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btMoveDown);
            this.panel1.Controls.Add(this.btMoveUp);
            this.panel1.Controls.Add(this.btRemoveModFile);
            this.panel1.Controls.Add(this.btLoadModFile);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(529, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(395, 222);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(59, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 52);
            this.label1.TabIndex = 4;
            this.label1.Text = "Mod values are loaded from top to bottom. If multiple mods change the same value," +
    " the value of the mod lower in the list will be used.";
            // 
            // btMoveDown
            // 
            this.btMoveDown.Location = new System.Drawing.Point(3, 96);
            this.btMoveDown.Name = "btMoveDown";
            this.btMoveDown.Size = new System.Drawing.Size(50, 23);
            this.btMoveDown.TabIndex = 3;
            this.btMoveDown.Text = "▼";
            this.btMoveDown.UseVisualStyleBackColor = true;
            this.btMoveDown.Click += new System.EventHandler(this.BtMoveDown_Click);
            // 
            // btMoveUp
            // 
            this.btMoveUp.Location = new System.Drawing.Point(3, 67);
            this.btMoveUp.Name = "btMoveUp";
            this.btMoveUp.Size = new System.Drawing.Size(50, 23);
            this.btMoveUp.TabIndex = 2;
            this.btMoveUp.Text = "▲";
            this.btMoveUp.UseVisualStyleBackColor = true;
            this.btMoveUp.Click += new System.EventHandler(this.BtMoveUp_Click);
            // 
            // btRemoveModFile
            // 
            this.btRemoveModFile.Location = new System.Drawing.Point(3, 38);
            this.btRemoveModFile.Name = "btRemoveModFile";
            this.btRemoveModFile.Size = new System.Drawing.Size(145, 23);
            this.btRemoveModFile.TabIndex = 1;
            this.btRemoveModFile.Text = "Remove selected Mod-file";
            this.btRemoveModFile.UseVisualStyleBackColor = true;
            this.btRemoveModFile.Click += new System.EventHandler(this.BtRemoveModFile_Click);
            // 
            // btLoadModFile
            // 
            this.btLoadModFile.Location = new System.Drawing.Point(3, 9);
            this.btLoadModFile.Name = "btLoadModFile";
            this.btLoadModFile.Size = new System.Drawing.Size(145, 23);
            this.btLoadModFile.TabIndex = 0;
            this.btLoadModFile.Text = "Load Mod-Values file";
            this.btLoadModFile.UseVisualStyleBackColor = true;
            this.btLoadModFile.Click += new System.EventHandler(this.BtLoadModFile_Click);
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btClose.Location = new System.Drawing.Point(830, 466);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(94, 23);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbModList);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(286, 3);
            this.groupBox2.Name = "groupBox2";
            this.tableLayoutPanel1.SetRowSpan(this.groupBox2, 3);
            this.groupBox2.Size = new System.Drawing.Size(237, 486);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mods loaded in library";
            // 
            // btAddMod
            // 
            this.btAddMod.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btAddMod.Location = new System.Drawing.Point(246, 202);
            this.btAddMod.Name = "btAddMod";
            this.btAddMod.Size = new System.Drawing.Size(34, 23);
            this.btAddMod.TabIndex = 10;
            this.btAddMod.Text = ">";
            this.btAddMod.UseVisualStyleBackColor = true;
            this.btAddMod.Click += new System.EventHandler(this.BtAddMod_Click);
            // 
            // ModValuesManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 492);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ModValuesManager";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Mod Values Manager";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbModList;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMoveDown;
        private System.Windows.Forms.Button btMoveUp;
        private System.Windows.Forms.Button btRemoveModFile;
        private System.Windows.Forms.Button btLoadModFile;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.LinkLabel llbSteamPage;
        private System.Windows.Forms.Label lbModId;
        private System.Windows.Forms.Label lbModTag;
        private System.Windows.Forms.Label lbModName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btRemoveMod;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox lbAvailableModFiles;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btAddMod;
        private System.Windows.Forms.Label lbAvailableForDownload;
    }
}