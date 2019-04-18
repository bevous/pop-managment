namespace FileIO
{
    partial class AddEditForm
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
            this.IdLabel = new System.Windows.Forms.Label();
            this.IdTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.GpaTextBox = new System.Windows.Forms.TextBox();
            this.GpaLabel = new System.Windows.Forms.Label();
            this.AddEditGroupBox = new System.Windows.Forms.GroupBox();
            this.SubmitButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddEditGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(39, 34);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(18, 13);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "ID";
            // 
            // IdTextBox
            // 
            this.IdTextBox.Location = new System.Drawing.Point(102, 31);
            this.IdTextBox.Name = "IdTextBox";
            this.IdTextBox.Size = new System.Drawing.Size(100, 20);
            this.IdTextBox.TabIndex = 1;
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.Location = new System.Drawing.Point(102, 57);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.FirstNameTextBox.TabIndex = 3;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Location = new System.Drawing.Point(39, 60);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(57, 13);
            this.FirstNameLabel.TabIndex = 2;
            this.FirstNameLabel.Text = "First Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.Location = new System.Drawing.Point(102, 83);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.LastNameTextBox.TabIndex = 5;
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Location = new System.Drawing.Point(39, 86);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(58, 13);
            this.LastNameLabel.TabIndex = 4;
            this.LastNameLabel.Text = "Last Name";
            // 
            // GpaTextBox
            // 
            this.GpaTextBox.Location = new System.Drawing.Point(102, 109);
            this.GpaTextBox.Name = "GpaTextBox";
            this.GpaTextBox.Size = new System.Drawing.Size(100, 20);
            this.GpaTextBox.TabIndex = 7;
            // 
            // GpaLabel
            // 
            this.GpaLabel.AutoSize = true;
            this.GpaLabel.Location = new System.Drawing.Point(39, 112);
            this.GpaLabel.Name = "GpaLabel";
            this.GpaLabel.Size = new System.Drawing.Size(29, 13);
            this.GpaLabel.TabIndex = 6;
            this.GpaLabel.Text = "GPA";
            // 
            // AddEditGroupBox
            // 
            this.AddEditGroupBox.Controls.Add(this.IdLabel);
            this.AddEditGroupBox.Controls.Add(this.GpaTextBox);
            this.AddEditGroupBox.Controls.Add(this.IdTextBox);
            this.AddEditGroupBox.Controls.Add(this.GpaLabel);
            this.AddEditGroupBox.Controls.Add(this.FirstNameLabel);
            this.AddEditGroupBox.Controls.Add(this.LastNameTextBox);
            this.AddEditGroupBox.Controls.Add(this.FirstNameTextBox);
            this.AddEditGroupBox.Controls.Add(this.LastNameLabel);
            this.AddEditGroupBox.Location = new System.Drawing.Point(12, 12);
            this.AddEditGroupBox.Name = "AddEditGroupBox";
            this.AddEditGroupBox.Size = new System.Drawing.Size(232, 158);
            this.AddEditGroupBox.TabIndex = 8;
            this.AddEditGroupBox.TabStop = false;
            this.AddEditGroupBox.Text = "Add / Edit Student";
            // 
            // SubmitButton
            // 
            this.SubmitButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SubmitButton.Location = new System.Drawing.Point(12, 176);
            this.SubmitButton.Name = "SubmitButton";
            this.SubmitButton.Size = new System.Drawing.Size(75, 23);
            this.SubmitButton.TabIndex = 9;
            this.SubmitButton.Text = "Submit";
            this.SubmitButton.UseVisualStyleBackColor = true;
            this.SubmitButton.Click += new System.EventHandler(this.SubmitButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Location = new System.Drawing.Point(169, 176);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 10;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // AddEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 213);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SubmitButton);
            this.Controls.Add(this.AddEditGroupBox);
            this.Name = "AddEditForm";
            this.Text = "EditUpdateForm";
            this.Load += new System.EventHandler(this.AddEditForm_Load);
            this.AddEditGroupBox.ResumeLayout(false);
            this.AddEditGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.TextBox IdTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox GpaTextBox;
        private System.Windows.Forms.Label GpaLabel;
        private System.Windows.Forms.GroupBox AddEditGroupBox;
        private System.Windows.Forms.Button SubmitButton;
        private System.Windows.Forms.Button CancelButton;
    }
}