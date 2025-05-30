﻿namespace WrennFinalProject
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.partyNameLabel = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.editItemButton = new System.Windows.Forms.Button();
            this.clearListButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.gpTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.spTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cpTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.saveListButton = new System.Windows.Forms.Button();
            this.loadListButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.treasureListTabControl = new System.Windows.Forms.TabControl();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.addPartyMemberButton = new System.Windows.Forms.Button();
            this.removePartyMemberButton = new System.Windows.Forms.Button();
            this.portraitBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.renameButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.portraitBox)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // partyNameLabel
            // 
            this.partyNameLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.partyNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partyNameLabel.Font = new System.Drawing.Font("Book Antiqua", 24F);
            this.partyNameLabel.Location = new System.Drawing.Point(12, 12);
            this.partyNameLabel.Name = "partyNameLabel";
            this.partyNameLabel.Size = new System.Drawing.Size(517, 40);
            this.partyNameLabel.TabIndex = 0;
            this.partyNameLabel.Text = "Click to Name Your Party";
            this.partyNameLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.toolTip1.SetToolTip(this.partyNameLabel, "Click to rename your party");
            this.partyNameLabel.Click += new System.EventHandler(this.partyNameLabel_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.addItemButton.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItemButton.Location = new System.Drawing.Point(55, 416);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(80, 25);
            this.addItemButton.TabIndex = 2;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.addItemButton_Click);
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.deleteItemButton.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteItemButton.Location = new System.Drawing.Point(227, 416);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(80, 25);
            this.deleteItemButton.TabIndex = 4;
            this.deleteItemButton.Text = "Delete Item";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.deleteItemButton_Click);
            // 
            // editItemButton
            // 
            this.editItemButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.editItemButton.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editItemButton.Location = new System.Drawing.Point(141, 416);
            this.editItemButton.Name = "editItemButton";
            this.editItemButton.Size = new System.Drawing.Size(80, 25);
            this.editItemButton.TabIndex = 3;
            this.editItemButton.Text = "Edit Item";
            this.editItemButton.UseVisualStyleBackColor = true;
            this.editItemButton.Click += new System.EventHandler(this.editItemButton_Click);
            // 
            // clearListButton
            // 
            this.clearListButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clearListButton.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearListButton.Location = new System.Drawing.Point(313, 416);
            this.clearListButton.Name = "clearListButton";
            this.clearListButton.Size = new System.Drawing.Size(80, 25);
            this.clearListButton.TabIndex = 5;
            this.clearListButton.Text = "Clear List";
            this.clearListButton.UseVisualStyleBackColor = true;
            this.clearListButton.Click += new System.EventHandler(this.clearListButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(101, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "GP";
            this.toolTip1.SetToolTip(this.label2, "Gold Pieces");
            // 
            // gpTextBox
            // 
            this.gpTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.gpTextBox.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpTextBox.Location = new System.Drawing.Point(48, 23);
            this.gpTextBox.Name = "gpTextBox";
            this.gpTextBox.Size = new System.Drawing.Size(49, 21);
            this.gpTextBox.TabIndex = 12;
            this.gpTextBox.Text = "0";
            this.gpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.gpTextBox, "Gold Pieces");
            this.gpTextBox.TextChanged += new System.EventHandler(this.gpTextBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(101, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "SP";
            this.toolTip1.SetToolTip(this.label3, "Silver Pieces");
            // 
            // spTextBox
            // 
            this.spTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.spTextBox.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spTextBox.Location = new System.Drawing.Point(48, 50);
            this.spTextBox.Name = "spTextBox";
            this.spTextBox.Size = new System.Drawing.Size(49, 21);
            this.spTextBox.TabIndex = 13;
            this.spTextBox.Text = "0";
            this.spTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.spTextBox, "Silver Pieces");
            this.spTextBox.TextChanged += new System.EventHandler(this.spTextBox_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(101, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "CP";
            this.toolTip1.SetToolTip(this.label4, "Copper Pieces");
            // 
            // cpTextBox
            // 
            this.cpTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cpTextBox.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpTextBox.Location = new System.Drawing.Point(48, 76);
            this.cpTextBox.Name = "cpTextBox";
            this.cpTextBox.Size = new System.Drawing.Size(49, 21);
            this.cpTextBox.TabIndex = 14;
            this.cpTextBox.Text = "0";
            this.cpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.cpTextBox, "Copper Pieces");
            this.cpTextBox.TextChanged += new System.EventHandler(this.cpTextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(580, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "v1.0 | Andrew Wrenn";
            // 
            // saveListButton
            // 
            this.saveListButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveListButton.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveListButton.Location = new System.Drawing.Point(541, 288);
            this.saveListButton.Name = "saveListButton";
            this.saveListButton.Size = new System.Drawing.Size(70, 25);
            this.saveListButton.TabIndex = 10;
            this.saveListButton.Text = "Save";
            this.saveListButton.UseVisualStyleBackColor = true;
            this.saveListButton.Click += new System.EventHandler(this.saveListButton_Click);
            // 
            // loadListButton
            // 
            this.loadListButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.loadListButton.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadListButton.Location = new System.Drawing.Point(619, 288);
            this.loadListButton.Name = "loadListButton";
            this.loadListButton.Size = new System.Drawing.Size(70, 25);
            this.loadListButton.TabIndex = 11;
            this.loadListButton.Text = "Load";
            this.loadListButton.UseVisualStyleBackColor = true;
            this.loadListButton.Click += new System.EventHandler(this.loadListButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.exitButton.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(399, 416);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 25);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // treasureListTabControl
            // 
            this.treasureListTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treasureListTabControl.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treasureListTabControl.Location = new System.Drawing.Point(12, 64);
            this.treasureListTabControl.Name = "treasureListTabControl";
            this.treasureListTabControl.SelectedIndex = 0;
            this.treasureListTabControl.Size = new System.Drawing.Size(517, 346);
            this.treasureListTabControl.TabIndex = 1;
            this.treasureListTabControl.SelectedIndexChanged += new System.EventHandler(this.treasureListTabControl_SelectedIndexChanged);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "json";
            this.saveFileDialog.FileName = "Party.json";
            this.saveFileDialog.Filter = "JSON Files |*.json; *.JSON";
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            // 
            // addPartyMemberButton
            // 
            this.addPartyMemberButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addPartyMemberButton.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartyMemberButton.Location = new System.Drawing.Point(535, 195);
            this.addPartyMemberButton.Name = "addPartyMemberButton";
            this.addPartyMemberButton.Size = new System.Drawing.Size(160, 25);
            this.addPartyMemberButton.TabIndex = 7;
            this.addPartyMemberButton.Text = "Add Adventurer";
            this.addPartyMemberButton.UseVisualStyleBackColor = true;
            this.addPartyMemberButton.Click += new System.EventHandler(this.addPartyMemberButton_Click);
            // 
            // removePartyMemberButton
            // 
            this.removePartyMemberButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.removePartyMemberButton.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removePartyMemberButton.Location = new System.Drawing.Point(535, 257);
            this.removePartyMemberButton.Name = "removePartyMemberButton";
            this.removePartyMemberButton.Size = new System.Drawing.Size(160, 25);
            this.removePartyMemberButton.TabIndex = 9;
            this.removePartyMemberButton.Text = "Remove Adventurer";
            this.removePartyMemberButton.UseVisualStyleBackColor = true;
            this.removePartyMemberButton.Click += new System.EventHandler(this.removePartyMemberButton_Click);
            // 
            // portraitBox
            // 
            this.portraitBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.portraitBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.portraitBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.portraitBox.InitialImage = null;
            this.portraitBox.Location = new System.Drawing.Point(535, 12);
            this.portraitBox.Name = "portraitBox";
            this.portraitBox.Size = new System.Drawing.Size(160, 160);
            this.portraitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portraitBox.TabIndex = 24;
            this.portraitBox.TabStop = false;
            this.portraitBox.Click += new System.EventHandler(this.portraitBox_Click);
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(556, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Click to change portrait";
            // 
            // renameButton
            // 
            this.renameButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.renameButton.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renameButton.Location = new System.Drawing.Point(535, 226);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(160, 25);
            this.renameButton.TabIndex = 8;
            this.renameButton.Text = "Rename Adventurer";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.pictureBox3);
            this.groupBox1.Controls.Add(this.pictureBox2);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.gpTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.spTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cpTextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(535, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 112);
            this.groupBox1.TabIndex = 28;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Party Coinage";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(22, 76);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(22, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 23);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(20, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(719, 461);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.portraitBox);
            this.Controls.Add(this.removePartyMemberButton);
            this.Controls.Add(this.addPartyMemberButton);
            this.Controls.Add(this.treasureListTabControl);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loadListButton);
            this.Controls.Add(this.saveListButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.clearListButton);
            this.Controls.Add(this.editItemButton);
            this.Controls.Add(this.deleteItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.partyNameLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(735, 500);
            this.Name = "MainForm";
            this.Text = "D&D 5e Treasure Tracker";
            ((System.ComponentModel.ISupportInitialize)(this.portraitBox)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label partyNameLabel;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Button editItemButton;
        private System.Windows.Forms.Button clearListButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button saveListButton;
        private System.Windows.Forms.Button loadListButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button addPartyMemberButton;
        private System.Windows.Forms.Button removePartyMemberButton;
        public System.Windows.Forms.TabControl treasureListTabControl;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.PictureBox portraitBox;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox gpTextBox;
        public System.Windows.Forms.TextBox spTextBox;
        public System.Windows.Forms.TextBox cpTextBox;
    }
}

