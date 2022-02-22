﻿namespace ContractSniper.UI
{
    partial class ContractSniper
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cmb_Mint = new System.Windows.Forms.ComboBox();
            this.cmb_IsLive = new System.Windows.Forms.ComboBox();
            this.btn_LoadABI = new System.Windows.Forms.Button();
            this.btn_StopWatching = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_mintCost = new System.Windows.Forms.TextBox();
            this.lbl_NoToMint = new System.Windows.Forms.Label();
            this.txt_NoToMint = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_contractABI = new System.Windows.Forms.RichTextBox();
            this.btn_StartWatching = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_contractAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_privatekey = new System.Windows.Forms.TextBox();
            this.txt_log = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_MoreGas = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.HSplit;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label7);
            this.splitContainer1.Panel1.Controls.Add(this.txt_MoreGas);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_Mint);
            this.splitContainer1.Panel1.Controls.Add(this.cmb_IsLive);
            this.splitContainer1.Panel1.Controls.Add(this.btn_LoadABI);
            this.splitContainer1.Panel1.Controls.Add(this.btn_StopWatching);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.txt_mintCost);
            this.splitContainer1.Panel1.Controls.Add(this.lbl_NoToMint);
            this.splitContainer1.Panel1.Controls.Add(this.txt_NoToMint);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.txt_contractABI);
            this.splitContainer1.Panel1.Controls.Add(this.btn_StartWatching);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.txt_contractAddress);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txt_privatekey);
            this.splitContainer1.Panel1.Cursor = System.Windows.Forms.Cursors.Default;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txt_log);
            this.splitContainer1.Size = new System.Drawing.Size(1101, 623);
            this.splitContainer1.SplitterDistance = 425;
            this.splitContainer1.TabIndex = 1;
            // 
            // cmb_Mint
            // 
            this.cmb_Mint.FormattingEnabled = true;
            this.cmb_Mint.Location = new System.Drawing.Point(669, 239);
            this.cmb_Mint.Name = "cmb_Mint";
            this.cmb_Mint.Size = new System.Drawing.Size(226, 23);
            this.cmb_Mint.TabIndex = 18;
            // 
            // cmb_IsLive
            // 
            this.cmb_IsLive.FormattingEnabled = true;
            this.cmb_IsLive.Location = new System.Drawing.Point(314, 239);
            this.cmb_IsLive.Name = "cmb_IsLive";
            this.cmb_IsLive.Size = new System.Drawing.Size(226, 23);
            this.cmb_IsLive.TabIndex = 17;
            // 
            // btn_LoadABI
            // 
            this.btn_LoadABI.Location = new System.Drawing.Point(901, 168);
            this.btn_LoadABI.Name = "btn_LoadABI";
            this.btn_LoadABI.Size = new System.Drawing.Size(90, 23);
            this.btn_LoadABI.TabIndex = 16;
            this.btn_LoadABI.Text = "Load ABI Data";
            this.btn_LoadABI.UseVisualStyleBackColor = true;
            this.btn_LoadABI.Click += new System.EventHandler(this.btn_LoadABI_Click);
            // 
            // btn_StopWatching
            // 
            this.btn_StopWatching.Enabled = false;
            this.btn_StopWatching.Location = new System.Drawing.Point(537, 373);
            this.btn_StopWatching.Name = "btn_StopWatching";
            this.btn_StopWatching.Size = new System.Drawing.Size(114, 31);
            this.btn_StopWatching.TabIndex = 15;
            this.btn_StopWatching.Text = "Stop";
            this.btn_StopWatching.UseVisualStyleBackColor = true;
            this.btn_StopWatching.Click += new System.EventHandler(this.btn_StopWatching_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(485, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Mint Cost (ETH)";
            // 
            // txt_mintCost
            // 
            this.txt_mintCost.Location = new System.Drawing.Point(581, 280);
            this.txt_mintCost.Name = "txt_mintCost";
            this.txt_mintCost.Size = new System.Drawing.Size(58, 23);
            this.txt_mintCost.TabIndex = 13;
            // 
            // lbl_NoToMint
            // 
            this.lbl_NoToMint.AutoSize = true;
            this.lbl_NoToMint.Location = new System.Drawing.Point(302, 283);
            this.lbl_NoToMint.Name = "lbl_NoToMint";
            this.lbl_NoToMint.Size = new System.Drawing.Size(93, 15);
            this.lbl_NoToMint.TabIndex = 12;
            this.lbl_NoToMint.Text = "Number to Mint";
            // 
            // txt_NoToMint
            // 
            this.txt_NoToMint.Location = new System.Drawing.Point(401, 280);
            this.txt_NoToMint.Name = "txt_NoToMint";
            this.txt_NoToMint.Size = new System.Drawing.Size(58, 23);
            this.txt_NoToMint.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(581, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mint Function";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 172);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Contract ABI";
            // 
            // txt_contractABI
            // 
            this.txt_contractABI.Location = new System.Drawing.Point(221, 140);
            this.txt_contractABI.Name = "txt_contractABI";
            this.txt_contractABI.Size = new System.Drawing.Size(674, 78);
            this.txt_contractABI.TabIndex = 7;
            this.txt_contractABI.Text = "";
            // 
            // btn_StartWatching
            // 
            this.btn_StartWatching.Location = new System.Drawing.Point(375, 373);
            this.btn_StartWatching.Name = "btn_StartWatching";
            this.btn_StartWatching.Size = new System.Drawing.Size(114, 31);
            this.btn_StartWatching.TabIndex = 6;
            this.btn_StartWatching.Text = "Start Watching";
            this.btn_StartWatching.UseVisualStyleBackColor = true;
            this.btn_StartWatching.Click += new System.EventHandler(this.btn_StartWatching_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Is Live Property";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(117, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contract Address";
            // 
            // txt_contractAddress
            // 
            this.txt_contractAddress.Location = new System.Drawing.Point(221, 98);
            this.txt_contractAddress.Name = "txt_contractAddress";
            this.txt_contractAddress.Size = new System.Drawing.Size(674, 23);
            this.txt_contractAddress.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(150, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Private Key";
            // 
            // txt_privatekey
            // 
            this.txt_privatekey.Location = new System.Drawing.Point(221, 43);
            this.txt_privatekey.Name = "txt_privatekey";
            this.txt_privatekey.PasswordChar = '*';
            this.txt_privatekey.Size = new System.Drawing.Size(674, 23);
            this.txt_privatekey.TabIndex = 0;
            // 
            // txt_log
            // 
            this.txt_log.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_log.Location = new System.Drawing.Point(0, 0);
            this.txt_log.Name = "txt_log";
            this.txt_log.ReadOnly = true;
            this.txt_log.Size = new System.Drawing.Size(1101, 194);
            this.txt_log.TabIndex = 0;
            this.txt_log.Text = "";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(666, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 15);
            this.label7.TabIndex = 20;
            this.label7.Text = "% More Gas Price";
            // 
            // txt_MoreGas
            // 
            this.txt_MoreGas.Location = new System.Drawing.Point(771, 280);
            this.txt_MoreGas.Name = "txt_MoreGas";
            this.txt_MoreGas.Size = new System.Drawing.Size(42, 23);
            this.txt_MoreGas.TabIndex = 19;
            this.txt_MoreGas.Text = "0";
            // 
            // ContractSniper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 623);
            this.Controls.Add(this.splitContainer1);
            this.Name = "ContractSniper";
            this.Text = "Contract Sniper";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private SplitContainer splitContainer1;
        private RichTextBox txt_log;
        private Label label1;
        private TextBox txt_privatekey;
        private Label label2;
        private TextBox txt_contractAddress;
        private Label label3;
        private Button btn_StartWatching;
        private Label label4;
        private RichTextBox txt_contractABI;
        private Label lbl_NoToMint;
        private TextBox txt_NoToMint;
        private Label label5;
        private Label label6;
        private TextBox txt_mintCost;
        private Button btn_StopWatching;
        private Button btn_LoadABI;
        private ComboBox cmb_Mint;
        private ComboBox cmb_IsLive;
        private Label label7;
        private TextBox txt_MoreGas;
    }
}