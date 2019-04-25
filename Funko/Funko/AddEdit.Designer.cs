namespace Funko
{
    partial class AddEdit
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
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.SizeTextBox = new System.Windows.Forms.TextBox();
            this.TypeTextBox = new System.Windows.Forms.TextBox();
            this.DoneButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ExclusiveCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(11, 18);
            this.NameTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(162, 22);
            this.NameTextBox.TabIndex = 0;
            this.NameTextBox.Text = "Name";
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(11, 56);
            this.NumberTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(162, 22);
            this.NumberTextBox.TabIndex = 2;
            this.NumberTextBox.Text = "Number";
            // 
            // SizeTextBox
            // 
            this.SizeTextBox.Location = new System.Drawing.Point(11, 142);
            this.SizeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SizeTextBox.Name = "SizeTextBox";
            this.SizeTextBox.Size = new System.Drawing.Size(162, 22);
            this.SizeTextBox.TabIndex = 6;
            this.SizeTextBox.Text = "Size";
            // 
            // TypeTextBox
            // 
            this.TypeTextBox.Location = new System.Drawing.Point(11, 182);
            this.TypeTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TypeTextBox.Name = "TypeTextBox";
            this.TypeTextBox.Size = new System.Drawing.Size(162, 22);
            this.TypeTextBox.TabIndex = 8;
            this.TypeTextBox.Text = "Type";
            // 
            // DoneButton
            // 
            this.DoneButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.DoneButton.Location = new System.Drawing.Point(11, 222);
            this.DoneButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DoneButton.Name = "DoneButton";
            this.DoneButton.Size = new System.Drawing.Size(162, 27);
            this.DoneButton.TabIndex = 10;
            this.DoneButton.Text = "Done";
            this.DoneButton.UseVisualStyleBackColor = true;
            this.DoneButton.Click += new System.EventHandler(this.DoneButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(11, 262);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(162, 27);
            this.CancelButton.TabIndex = 11;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // ExclusiveCheckBox
            // 
            this.ExclusiveCheckBox.AutoSize = true;
            this.ExclusiveCheckBox.Location = new System.Drawing.Point(41, 101);
            this.ExclusiveCheckBox.Name = "ExclusiveCheckBox";
            this.ExclusiveCheckBox.Size = new System.Drawing.Size(88, 21);
            this.ExclusiveCheckBox.TabIndex = 12;
            this.ExclusiveCheckBox.Text = "Exclusive";
            this.ExclusiveCheckBox.UseVisualStyleBackColor = true;
            // 
            // AddEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(193, 299);
            this.ControlBox = false;
            this.Controls.Add(this.ExclusiveCheckBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.DoneButton);
            this.Controls.Add(this.TypeTextBox);
            this.Controls.Add(this.SizeTextBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddEdit";
            this.Text = "AddEdit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.TextBox SizeTextBox;
        private System.Windows.Forms.TextBox TypeTextBox;
        private System.Windows.Forms.Button DoneButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.CheckBox ExclusiveCheckBox;
    }
}