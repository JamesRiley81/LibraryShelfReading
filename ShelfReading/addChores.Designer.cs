namespace ShelfReading
{
    partial class addChores
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
            this.descriptionPrompt = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.additionalPrompt = new System.Windows.Forms.Label();
            this.notesTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.addedItemsPrompt = new System.Windows.Forms.Label();
            this.allListBox = new System.Windows.Forms.TextBox();
            this.materialsListPrompt = new System.Windows.Forms.Label();
            this.requiredListBox = new System.Windows.Forms.TextBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // descriptionPrompt
            // 
            this.descriptionPrompt.AutoSize = true;
            this.descriptionPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionPrompt.Location = new System.Drawing.Point(68, 19);
            this.descriptionPrompt.Name = "descriptionPrompt";
            this.descriptionPrompt.Size = new System.Drawing.Size(134, 18);
            this.descriptionPrompt.TabIndex = 2;
            this.descriptionPrompt.Text = "Task descrption:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(61, 53);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(149, 20);
            this.descriptionTextBox.TabIndex = 3;
            // 
            // additionalPrompt
            // 
            this.additionalPrompt.AutoSize = true;
            this.additionalPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalPrompt.Location = new System.Drawing.Point(68, 107);
            this.additionalPrompt.Name = "additionalPrompt";
            this.additionalPrompt.Size = new System.Drawing.Size(136, 18);
            this.additionalPrompt.TabIndex = 4;
            this.additionalPrompt.Text = "Additional Notes:";
            // 
            // notesTextBox
            // 
            this.notesTextBox.Location = new System.Drawing.Point(30, 131);
            this.notesTextBox.Multiline = true;
            this.notesTextBox.Name = "notesTextBox";
            this.notesTextBox.Size = new System.Drawing.Size(213, 106);
            this.notesTextBox.TabIndex = 5;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.saveButton.Location = new System.Drawing.Point(25, 630);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(75, 36);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.exitButton.Location = new System.Drawing.Point(168, 630);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 36);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit Button";
            this.exitButton.UseVisualStyleBackColor = false;
            // 
            // addedItemsPrompt
            // 
            this.addedItemsPrompt.AutoSize = true;
            this.addedItemsPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addedItemsPrompt.Location = new System.Drawing.Point(149, 262);
            this.addedItemsPrompt.Name = "addedItemsPrompt";
            this.addedItemsPrompt.Size = new System.Drawing.Size(149, 18);
            this.addedItemsPrompt.TabIndex = 10;
            this.addedItemsPrompt.Text = "Required Materials";
            // 
            // allListBox
            // 
            this.allListBox.Location = new System.Drawing.Point(6, 306);
            this.allListBox.Multiline = true;
            this.allListBox.Name = "allListBox";
            this.allListBox.Size = new System.Drawing.Size(99, 106);
            this.allListBox.TabIndex = 11;
            // 
            // materialsListPrompt
            // 
            this.materialsListPrompt.AutoSize = true;
            this.materialsListPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialsListPrompt.Location = new System.Drawing.Point(5, 262);
            this.materialsListPrompt.Name = "materialsListPrompt";
            this.materialsListPrompt.Size = new System.Drawing.Size(100, 18);
            this.materialsListPrompt.TabIndex = 12;
            this.materialsListPrompt.Text = "All Materials";
            // 
            // requiredListBox
            // 
            this.requiredListBox.Location = new System.Drawing.Point(163, 306);
            this.requiredListBox.Multiline = true;
            this.requiredListBox.Name = "requiredListBox";
            this.requiredListBox.Size = new System.Drawing.Size(99, 106);
            this.requiredListBox.TabIndex = 13;
            // 
            // removeButton
            // 
            this.removeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.removeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.removeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.removeButton.Location = new System.Drawing.Point(163, 435);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(94, 36);
            this.removeButton.TabIndex = 14;
            this.removeButton.Text = "Remove Item";
            this.removeButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.addButton.Location = new System.Drawing.Point(6, 435);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(94, 36);
            this.addButton.TabIndex = 15;
            this.addButton.Text = "Add Item";
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // addChores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 678);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.requiredListBox);
            this.Controls.Add(this.materialsListPrompt);
            this.Controls.Add(this.allListBox);
            this.Controls.Add(this.addedItemsPrompt);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.notesTextBox);
            this.Controls.Add(this.additionalPrompt);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(this.descriptionPrompt);
            this.Name = "addChores";
            this.Text = "addChores";
            this.Load += new System.EventHandler(this.addChores_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label descriptionPrompt;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label additionalPrompt;
        private System.Windows.Forms.TextBox notesTextBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label addedItemsPrompt;
        private System.Windows.Forms.TextBox allListBox;
        private System.Windows.Forms.Label materialsListPrompt;
        private System.Windows.Forms.TextBox requiredListBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.Button addButton;
    }
}