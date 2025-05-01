namespace WrennFinalProject
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
            this.partyNameLabel = new System.Windows.Forms.Label();
            this.addItemButton = new System.Windows.Forms.Button();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.editItemButton = new System.Windows.Forms.Button();
            this.clearListButton = new System.Windows.Forms.Button();
            this.ppTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.label6 = new System.Windows.Forms.Label();
            this.allTab = new System.Windows.Forms.TabPage();
            this.allListView = new System.Windows.Forms.ListView();
            this.itemNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemQuantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemTypeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.itemRarityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.attunementColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.treasureListTabControl = new System.Windows.Forms.TabControl();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.addPartyMemberButton = new System.Windows.Forms.Button();
            this.removePartyMemberButton = new System.Windows.Forms.Button();
            this.portraitBox = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.allTab.SuspendLayout();
            this.treasureListTabControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.portraitBox)).BeginInit();
            this.SuspendLayout();
            // 
            // partyNameLabel
            // 
            this.partyNameLabel.BackColor = System.Drawing.SystemColors.ControlDark;
            this.partyNameLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partyNameLabel.Font = new System.Drawing.Font("Book Antiqua", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partyNameLabel.Location = new System.Drawing.Point(12, 12);
            this.partyNameLabel.Name = "partyNameLabel";
            this.partyNameLabel.Size = new System.Drawing.Size(498, 40);
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
            this.addItemButton.Location = new System.Drawing.Point(48, 416);
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
            this.deleteItemButton.Location = new System.Drawing.Point(220, 416);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(80, 25);
            this.deleteItemButton.TabIndex = 3;
            this.deleteItemButton.Text = "Delete Item";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.deleteItemButton_Click);
            // 
            // editItemButton
            // 
            this.editItemButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.editItemButton.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editItemButton.Location = new System.Drawing.Point(134, 416);
            this.editItemButton.Name = "editItemButton";
            this.editItemButton.Size = new System.Drawing.Size(80, 25);
            this.editItemButton.TabIndex = 4;
            this.editItemButton.Text = "Edit Item";
            this.editItemButton.UseVisualStyleBackColor = true;
            this.editItemButton.Click += new System.EventHandler(this.editItemButton_Click);
            // 
            // clearListButton
            // 
            this.clearListButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.clearListButton.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearListButton.Location = new System.Drawing.Point(306, 416);
            this.clearListButton.Name = "clearListButton";
            this.clearListButton.Size = new System.Drawing.Size(80, 25);
            this.clearListButton.TabIndex = 5;
            this.clearListButton.Text = "Clear List";
            this.clearListButton.UseVisualStyleBackColor = true;
            this.clearListButton.Click += new System.EventHandler(this.clearListButton_Click);
            // 
            // ppTextBox
            // 
            this.ppTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ppTextBox.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ppTextBox.Location = new System.Drawing.Point(520, 359);
            this.ppTextBox.Name = "ppTextBox";
            this.ppTextBox.Size = new System.Drawing.Size(49, 21);
            this.ppTextBox.TabIndex = 6;
            this.ppTextBox.Text = "0";
            this.ppTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.ppTextBox, "Platinum Pieces");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(575, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "PP";
            this.toolTip1.SetToolTip(this.label1, "Platinum Pieces");
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(575, 385);
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
            this.gpTextBox.Location = new System.Drawing.Point(520, 385);
            this.gpTextBox.Name = "gpTextBox";
            this.gpTextBox.Size = new System.Drawing.Size(49, 21);
            this.gpTextBox.TabIndex = 8;
            this.gpTextBox.Text = "0";
            this.gpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.gpTextBox, "Gold Pieces");
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(659, 359);
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
            this.spTextBox.Location = new System.Drawing.Point(604, 359);
            this.spTextBox.Name = "spTextBox";
            this.spTextBox.Size = new System.Drawing.Size(49, 21);
            this.spTextBox.TabIndex = 10;
            this.spTextBox.Text = "0";
            this.spTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.spTextBox, "Silver Pieces");
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(659, 385);
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
            this.cpTextBox.Location = new System.Drawing.Point(604, 385);
            this.cpTextBox.Name = "cpTextBox";
            this.cpTextBox.Size = new System.Drawing.Size(49, 21);
            this.cpTextBox.TabIndex = 12;
            this.cpTextBox.Text = "0";
            this.cpTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.cpTextBox, "Copper Pieces");
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(565, 434);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 18);
            this.label5.TabIndex = 16;
            this.label5.Text = "v0.2 | Andrew Wrenn";
            // 
            // saveListButton
            // 
            this.saveListButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.saveListButton.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveListButton.Location = new System.Drawing.Point(520, 274);
            this.saveListButton.Name = "saveListButton";
            this.saveListButton.Size = new System.Drawing.Size(161, 25);
            this.saveListButton.TabIndex = 17;
            this.saveListButton.Text = "Save Treasure List";
            this.saveListButton.UseVisualStyleBackColor = true;
            this.saveListButton.Click += new System.EventHandler(this.saveListButton_Click);
            // 
            // loadListButton
            // 
            this.loadListButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.loadListButton.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadListButton.Location = new System.Drawing.Point(520, 305);
            this.loadListButton.Name = "loadListButton";
            this.loadListButton.Size = new System.Drawing.Size(161, 25);
            this.loadListButton.TabIndex = 18;
            this.loadListButton.Text = "Load Treasure List";
            this.loadListButton.UseVisualStyleBackColor = true;
            this.loadListButton.Click += new System.EventHandler(this.loadListButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.exitButton.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(392, 416);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(80, 25);
            this.exitButton.TabIndex = 19;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(520, 338);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 18);
            this.label6.TabIndex = 21;
            this.label6.Text = "Coinage";
            // 
            // allTab
            // 
            this.allTab.Controls.Add(this.allListView);
            this.allTab.Location = new System.Drawing.Point(4, 24);
            this.allTab.Name = "allTab";
            this.allTab.Padding = new System.Windows.Forms.Padding(3);
            this.allTab.Size = new System.Drawing.Size(494, 318);
            this.allTab.TabIndex = 1;
            this.allTab.Text = "All";
            this.allTab.UseVisualStyleBackColor = true;
            // 
            // allListView
            // 
            this.allListView.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.allListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.allListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.itemNameColumn,
            this.itemQuantityColumn,
            this.itemTypeColumn,
            this.itemRarityColumn,
            this.attunementColumn});
            this.allListView.FullRowSelect = true;
            this.allListView.GridLines = true;
            this.allListView.HideSelection = false;
            this.allListView.Location = new System.Drawing.Point(0, 0);
            this.allListView.MultiSelect = false;
            this.allListView.Name = "allListView";
            this.allListView.ShowItemToolTips = true;
            this.allListView.Size = new System.Drawing.Size(491, 315);
            this.allListView.TabIndex = 0;
            this.allListView.UseCompatibleStateImageBehavior = false;
            this.allListView.View = System.Windows.Forms.View.Details;
            // 
            // itemNameColumn
            // 
            this.itemNameColumn.Text = "Item Name";
            this.itemNameColumn.Width = 175;
            // 
            // itemQuantityColumn
            // 
            this.itemQuantityColumn.Text = "Quantity";
            // 
            // itemTypeColumn
            // 
            this.itemTypeColumn.Text = "Type";
            this.itemTypeColumn.Width = 105;
            // 
            // itemRarityColumn
            // 
            this.itemRarityColumn.Text = "Rarity";
            this.itemRarityColumn.Width = 72;
            // 
            // attunementColumn
            // 
            this.attunementColumn.Text = "Attunement";
            this.attunementColumn.Width = 75;
            // 
            // treasureListTabControl
            // 
            this.treasureListTabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treasureListTabControl.Controls.Add(this.allTab);
            this.treasureListTabControl.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treasureListTabControl.Location = new System.Drawing.Point(12, 64);
            this.treasureListTabControl.Name = "treasureListTabControl";
            this.treasureListTabControl.SelectedIndex = 0;
            this.treasureListTabControl.Size = new System.Drawing.Size(502, 346);
            this.treasureListTabControl.TabIndex = 20;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "txt";
            // 
            // addPartyMemberButton
            // 
            this.addPartyMemberButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.addPartyMemberButton.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartyMemberButton.Location = new System.Drawing.Point(520, 212);
            this.addPartyMemberButton.Name = "addPartyMemberButton";
            this.addPartyMemberButton.Size = new System.Drawing.Size(161, 25);
            this.addPartyMemberButton.TabIndex = 22;
            this.addPartyMemberButton.Text = "Add Adventurer";
            this.addPartyMemberButton.UseVisualStyleBackColor = true;
            this.addPartyMemberButton.Click += new System.EventHandler(this.addPartyMemberButton_Click);
            // 
            // removePartyMemberButton
            // 
            this.removePartyMemberButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.removePartyMemberButton.Font = new System.Drawing.Font("Book Antiqua", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removePartyMemberButton.Location = new System.Drawing.Point(520, 243);
            this.removePartyMemberButton.Name = "removePartyMemberButton";
            this.removePartyMemberButton.Size = new System.Drawing.Size(161, 25);
            this.removePartyMemberButton.TabIndex = 23;
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
            this.portraitBox.Location = new System.Drawing.Point(520, 12);
            this.portraitBox.Name = "portraitBox";
            this.portraitBox.Size = new System.Drawing.Size(160, 160);
            this.portraitBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.portraitBox.TabIndex = 24;
            this.portraitBox.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Book Antiqua", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(541, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Click to change portrait";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(704, 461);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.portraitBox);
            this.Controls.Add(this.removePartyMemberButton);
            this.Controls.Add(this.addPartyMemberButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.treasureListTabControl);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.loadListButton);
            this.Controls.Add(this.saveListButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cpTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.spTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gpTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ppTextBox);
            this.Controls.Add(this.clearListButton);
            this.Controls.Add(this.editItemButton);
            this.Controls.Add(this.deleteItemButton);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.partyNameLabel);
            this.MinimumSize = new System.Drawing.Size(720, 500);
            this.Name = "MainForm";
            this.Text = "D&D 5e Treasure Tracker";
            this.allTab.ResumeLayout(false);
            this.treasureListTabControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.portraitBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label partyNameLabel;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Button editItemButton;
        private System.Windows.Forms.Button clearListButton;
        private System.Windows.Forms.TextBox ppTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gpTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox spTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox cpTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button saveListButton;
        private System.Windows.Forms.Button loadListButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ColumnHeader itemNameColumn;
        public System.Windows.Forms.ColumnHeader itemTypeColumn;
        public System.Windows.Forms.ColumnHeader itemRarityColumn;
        public System.Windows.Forms.ColumnHeader attunementColumn;
        public System.Windows.Forms.ColumnHeader itemQuantityColumn;
        public System.Windows.Forms.TabPage allTab;
        public System.Windows.Forms.ListView allListView;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button addPartyMemberButton;
        private System.Windows.Forms.Button removePartyMemberButton;
        public System.Windows.Forms.TabControl treasureListTabControl;
        private System.Windows.Forms.PictureBox portraitBox;
        private System.Windows.Forms.Label label7;
    }
}

