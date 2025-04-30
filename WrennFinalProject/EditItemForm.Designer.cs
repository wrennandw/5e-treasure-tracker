namespace WrennFinalProject
{
    partial class EditItemForm
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
            this.cancelButton = new System.Windows.Forms.Button();
            this.updateItemButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.rarityComboBox = new System.Windows.Forms.ComboBox();
            this.attunementCheckbox = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.quantityBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.itemNameBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(180, 177);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 25;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // updateItemButton
            // 
            this.updateItemButton.Location = new System.Drawing.Point(99, 177);
            this.updateItemButton.Name = "updateItemButton";
            this.updateItemButton.Size = new System.Drawing.Size(75, 23);
            this.updateItemButton.TabIndex = 24;
            this.updateItemButton.Text = "Update Item";
            this.updateItemButton.UseVisualStyleBackColor = true;
            this.updateItemButton.Click += new System.EventHandler(this.updateItemButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 15);
            this.label5.TabIndex = 22;
            this.label5.Text = "Rarity";
            // 
            // rarityComboBox
            // 
            this.rarityComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rarityComboBox.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rarityComboBox.FormattingEnabled = true;
            this.rarityComboBox.Items.AddRange(new object[] {
            "None",
            "Common",
            "Uncommon",
            "Rare",
            "Very Rare",
            "Legendary"});
            this.rarityComboBox.Location = new System.Drawing.Point(76, 137);
            this.rarityComboBox.Name = "rarityComboBox";
            this.rarityComboBox.Size = new System.Drawing.Size(121, 23);
            this.rarityComboBox.TabIndex = 21;
            // 
            // attunementCheckbox
            // 
            this.attunementCheckbox.AutoSize = true;
            this.attunementCheckbox.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.attunementCheckbox.Location = new System.Drawing.Point(206, 103);
            this.attunementCheckbox.Name = "attunementCheckbox";
            this.attunementCheckbox.Size = new System.Drawing.Size(136, 19);
            this.attunementCheckbox.TabIndex = 20;
            this.attunementCheckbox.Text = "Requires Attunement?";
            this.attunementCheckbox.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(203, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 15);
            this.label4.TabIndex = 19;
            this.label4.Text = "Quantity";
            // 
            // quantityBox
            // 
            this.quantityBox.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityBox.Location = new System.Drawing.Point(255, 137);
            this.quantityBox.Name = "quantityBox";
            this.quantityBox.Size = new System.Drawing.Size(31, 21);
            this.quantityBox.TabIndex = 18;
            this.quantityBox.Text = "1";
            this.quantityBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "Type";
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Weapon",
            "Armor",
            "Adventuring Gear",
            "Wondrous Item",
            "Consumable",
            "Valuable"});
            this.typeComboBox.Location = new System.Drawing.Point(76, 100);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 23);
            this.typeComboBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Item Name";
            // 
            // itemNameBox
            // 
            this.itemNameBox.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemNameBox.Location = new System.Drawing.Point(76, 65);
            this.itemNameBox.Name = "itemNameBox";
            this.itemNameBox.Size = new System.Drawing.Size(261, 21);
            this.itemNameBox.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Book Antiqua", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 30);
            this.label1.TabIndex = 13;
            this.label1.Text = "Make any needed changes and then \r\nclick Update Item to apply them.\r\n";
            // 
            // EditItemForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 217);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.updateItemButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rarityComboBox);
            this.Controls.Add(this.attunementCheckbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.quantityBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.itemNameBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "EditItemForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditItemForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button updateItemButton;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.ComboBox rarityComboBox;
        public System.Windows.Forms.CheckBox attunementCheckbox;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox quantityBox;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox itemNameBox;
        private System.Windows.Forms.Label label1;
    }
}