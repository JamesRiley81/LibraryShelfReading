namespace ShelfReading
{
    partial class TaskForm
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
            this.taskPromptLabel = new System.Windows.Forms.Label();
            this.readingButton = new System.Windows.Forms.Button();
            this.miscButton = new System.Windows.Forms.Button();
            this.adminButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // taskPromptLabel
            // 
            this.taskPromptLabel.AutoSize = true;
            this.taskPromptLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.taskPromptLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.taskPromptLabel.Location = new System.Drawing.Point(62, 41);
            this.taskPromptLabel.Name = "taskPromptLabel";
            this.taskPromptLabel.Size = new System.Drawing.Size(224, 18);
            this.taskPromptLabel.TabIndex = 0;
            this.taskPromptLabel.Text = "Please select a task to start:";
            // 
            // readingButton
            // 
            this.readingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.readingButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.readingButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.readingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.readingButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.readingButton.Location = new System.Drawing.Point(12, 109);
            this.readingButton.Name = "readingButton";
            this.readingButton.Size = new System.Drawing.Size(131, 39);
            this.readingButton.TabIndex = 1;
            this.readingButton.Text = "Shelf Reading";
            this.readingButton.UseVisualStyleBackColor = false;
            this.readingButton.Click += new System.EventHandler(this.readingButton_Click);
            // 
            // miscButton
            // 
            this.miscButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.miscButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.miscButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.miscButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.miscButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.miscButton.Location = new System.Drawing.Point(197, 109);
            this.miscButton.Name = "miscButton";
            this.miscButton.Size = new System.Drawing.Size(133, 39);
            this.miscButton.TabIndex = 2;
            this.miscButton.Text = "Miscellaneous";
            this.miscButton.UseVisualStyleBackColor = false;
            this.miscButton.Click += new System.EventHandler(this.miscButton_Click);
            // 
            // adminButton
            // 
            this.adminButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(160)))), ((int)(((byte)(0)))));
            this.adminButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButton.ForeColor = System.Drawing.Color.DarkBlue;
            this.adminButton.Location = new System.Drawing.Point(100, 209);
            this.adminButton.Name = "adminButton";
            this.adminButton.Size = new System.Drawing.Size(141, 38);
            this.adminButton.TabIndex = 3;
            this.adminButton.Text = "Admin Tools";
            this.adminButton.UseVisualStyleBackColor = false;
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 307);
            this.Controls.Add(this.adminButton);
            this.Controls.Add(this.miscButton);
            this.Controls.Add(this.readingButton);
            this.Controls.Add(this.taskPromptLabel);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            this.Load += new System.EventHandler(this.TaskForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label taskPromptLabel;
        private System.Windows.Forms.Button readingButton;
        private System.Windows.Forms.Button miscButton;
        private System.Windows.Forms.Button adminButton;
    }
}