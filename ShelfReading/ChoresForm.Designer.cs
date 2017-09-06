namespace ShelfReading
{
    partial class ChoresForm
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
            this.choresListBox = new System.Windows.Forms.ListBox();
            this.choreSelectPrompt = new System.Windows.Forms.Label();
            this.directionsTextBox = new System.Windows.Forms.TextBox();
            this.instructionsPromptLabel = new System.Windows.Forms.Label();
            this.materialButton = new System.Windows.Forms.Label();
            this.materialsTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // choresListBox
            // 
            this.choresListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.choresListBox.FormattingEnabled = true;
            this.choresListBox.Location = new System.Drawing.Point(119, 61);
            this.choresListBox.Name = "choresListBox";
            this.choresListBox.Size = new System.Drawing.Size(241, 95);
            this.choresListBox.TabIndex = 0;
            this.choresListBox.SelectedIndexChanged += new System.EventHandler(this.choresListBox_SelectedIndexChanged);
            // 
            // choreSelectPrompt
            // 
            this.choreSelectPrompt.AutoSize = true;
            this.choreSelectPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choreSelectPrompt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.choreSelectPrompt.Location = new System.Drawing.Point(60, 30);
            this.choreSelectPrompt.Name = "choreSelectPrompt";
            this.choreSelectPrompt.Size = new System.Drawing.Size(365, 18);
            this.choreSelectPrompt.TabIndex = 1;
            this.choreSelectPrompt.Text = "Please Select A Chore From The Listbox Below";
            // 
            // directionsTextBox
            // 
            this.directionsTextBox.Location = new System.Drawing.Point(12, 201);
            this.directionsTextBox.Multiline = true;
            this.directionsTextBox.Name = "directionsTextBox";
            this.directionsTextBox.ReadOnly = true;
            this.directionsTextBox.Size = new System.Drawing.Size(250, 201);
            this.directionsTextBox.TabIndex = 2;
            this.directionsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // instructionsPromptLabel
            // 
            this.instructionsPromptLabel.AutoSize = true;
            this.instructionsPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsPromptLabel.ForeColor = System.Drawing.Color.MidnightBlue;
            this.instructionsPromptLabel.Location = new System.Drawing.Point(97, 169);
            this.instructionsPromptLabel.Name = "instructionsPromptLabel";
            this.instructionsPromptLabel.Size = new System.Drawing.Size(101, 18);
            this.instructionsPromptLabel.TabIndex = 4;
            this.instructionsPromptLabel.Text = "Instructions:";
            // 
            // materialButton
            // 
            this.materialButton.AutoSize = true;
            this.materialButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialButton.ForeColor = System.Drawing.Color.MidnightBlue;
            this.materialButton.Location = new System.Drawing.Point(343, 169);
            this.materialButton.Name = "materialButton";
            this.materialButton.Size = new System.Drawing.Size(82, 18);
            this.materialButton.TabIndex = 5;
            this.materialButton.Text = "Materials:";
            // 
            // materialsTextBox
            // 
            this.materialsTextBox.Location = new System.Drawing.Point(296, 201);
            this.materialsTextBox.Multiline = true;
            this.materialsTextBox.Name = "materialsTextBox";
            this.materialsTextBox.Size = new System.Drawing.Size(162, 201);
            this.materialsTextBox.TabIndex = 6;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(119, 436);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // ChoresForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 493);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.materialsTextBox);
            this.Controls.Add(this.materialButton);
            this.Controls.Add(this.instructionsPromptLabel);
            this.Controls.Add(this.directionsTextBox);
            this.Controls.Add(this.choreSelectPrompt);
            this.Controls.Add(this.choresListBox);
            this.Name = "ChoresForm";
            this.Text = "Chores";
            this.Load += new System.EventHandler(this.Chores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox choresListBox;
        private System.Windows.Forms.Label choreSelectPrompt;
        private System.Windows.Forms.TextBox directionsTextBox;
        private System.Windows.Forms.Label instructionsPromptLabel;
        private System.Windows.Forms.Label materialButton;
        private System.Windows.Forms.TextBox materialsTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}