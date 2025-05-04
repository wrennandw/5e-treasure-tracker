namespace WrennFinalProject
{
    partial class AddAdventurerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddAdventurerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.adventurerNameTextbox = new System.Windows.Forms.TextBox();
            this.classSelectDropdown = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.defaultGearCheckbox = new System.Windows.Forms.CheckBox();
            this.createAdventurerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adventurer Name";
            // 
            // adventurerNameTextbox
            // 
            this.adventurerNameTextbox.Location = new System.Drawing.Point(108, 29);
            this.adventurerNameTextbox.MaxLength = 64;
            this.adventurerNameTextbox.Name = "adventurerNameTextbox";
            this.adventurerNameTextbox.Size = new System.Drawing.Size(191, 20);
            this.adventurerNameTextbox.TabIndex = 1;
            // 
            // classSelectDropdown
            // 
            this.classSelectDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.classSelectDropdown.FormattingEnabled = true;
            this.classSelectDropdown.Items.AddRange(new object[] {
            "Barbarian",
            "Bard",
            "Cleric",
            "Druid",
            "Fighter",
            "Monk",
            "Paladin",
            "Ranger",
            "Rogue",
            "Sorceror",
            "Warlock",
            "Wizard"});
            this.classSelectDropdown.Location = new System.Drawing.Point(51, 64);
            this.classSelectDropdown.Name = "classSelectDropdown";
            this.classSelectDropdown.Size = new System.Drawing.Size(121, 21);
            this.classSelectDropdown.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Class";
            // 
            // defaultGearCheckbox
            // 
            this.defaultGearCheckbox.AutoSize = true;
            this.defaultGearCheckbox.Checked = true;
            this.defaultGearCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.defaultGearCheckbox.Location = new System.Drawing.Point(189, 66);
            this.defaultGearCheckbox.Name = "defaultGearCheckbox";
            this.defaultGearCheckbox.Size = new System.Drawing.Size(110, 17);
            this.defaultGearCheckbox.TabIndex = 3;
            this.defaultGearCheckbox.Text = "Add default gear?";
            this.toolTip1.SetToolTip(this.defaultGearCheckbox, "Default gear assumes the quickstart options for the character as listed in the Pl" +
        "ayer\'s Handbook");
            this.defaultGearCheckbox.UseVisualStyleBackColor = true;
            // 
            // createAdventurerButton
            // 
            this.createAdventurerButton.Location = new System.Drawing.Point(43, 101);
            this.createAdventurerButton.Name = "createAdventurerButton";
            this.createAdventurerButton.Size = new System.Drawing.Size(111, 25);
            this.createAdventurerButton.TabIndex = 4;
            this.createAdventurerButton.Text = "Create Adventurer";
            this.createAdventurerButton.UseVisualStyleBackColor = true;
            this.createAdventurerButton.Click += new System.EventHandler(this.createAdventurerButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(160, 101);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(111, 25);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // AddAdventurerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 138);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.createAdventurerButton);
            this.Controls.Add(this.defaultGearCheckbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.classSelectDropdown);
            this.Controls.Add(this.adventurerNameTextbox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddAdventurerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add Adventurer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox adventurerNameTextbox;
        public System.Windows.Forms.ComboBox classSelectDropdown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox defaultGearCheckbox;
        private System.Windows.Forms.Button createAdventurerButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}