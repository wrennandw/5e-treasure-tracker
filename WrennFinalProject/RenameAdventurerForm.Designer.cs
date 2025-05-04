namespace WrennFinalProject
{
    partial class RenameAdventurerForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.renameButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.adventurerNameTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.closeButton.Location = new System.Drawing.Point(135, 72);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // renameButton
            // 
            this.renameButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.renameButton.Location = new System.Drawing.Point(54, 72);
            this.renameButton.Name = "renameButton";
            this.renameButton.Size = new System.Drawing.Size(75, 23);
            this.renameButton.TabIndex = 6;
            this.renameButton.Text = "Rename";
            this.renameButton.UseVisualStyleBackColor = true;
            this.renameButton.Click += new System.EventHandler(this.renameButton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter your adventurer\'s name:";
            // 
            // adventurerNameTextbox
            // 
            this.adventurerNameTextbox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adventurerNameTextbox.Location = new System.Drawing.Point(72, 37);
            this.adventurerNameTextbox.Name = "adventurerNameTextbox";
            this.adventurerNameTextbox.Size = new System.Drawing.Size(117, 20);
            this.adventurerNameTextbox.TabIndex = 5;
            // 
            // RenameAdventurerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 107);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.renameButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.adventurerNameTextbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "RenameAdventurerForm";
            this.Text = "RenameAdventurerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button renameButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox adventurerNameTextbox;
    }
}