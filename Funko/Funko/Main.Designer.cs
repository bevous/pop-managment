namespace Funko
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
            this.PopDataGridView = new System.Windows.Forms.DataGridView();
            this.DeliminatorTextBox = new System.Windows.Forms.TextBox();
            this.AddEditButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PopDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // PopDataGridView
            // 
            this.PopDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PopDataGridView.Location = new System.Drawing.Point(0, 0);
            this.PopDataGridView.Name = "PopDataGridView";
            this.PopDataGridView.RowTemplate.Height = 28;
            this.PopDataGridView.Size = new System.Drawing.Size(240, 161);
            this.PopDataGridView.TabIndex = 0;
            // 
            // DeliminatorTextBox
            // 
            this.DeliminatorTextBox.Location = new System.Drawing.Point(246, 12);
            this.DeliminatorTextBox.Name = "DeliminatorTextBox";
            this.DeliminatorTextBox.Size = new System.Drawing.Size(100, 26);
            this.DeliminatorTextBox.TabIndex = 1;
            this.DeliminatorTextBox.Text = ",";
            // 
            // AddEditButton
            // 
            this.AddEditButton.Location = new System.Drawing.Point(246, 81);
            this.AddEditButton.Name = "AddEditButton";
            this.AddEditButton.Size = new System.Drawing.Size(100, 80);
            this.AddEditButton.TabIndex = 3;
            this.AddEditButton.Text = "Add / Edit";
            this.AddEditButton.UseVisualStyleBackColor = true;
            // 
            // LoadButton
            // 
            this.LoadButton.Location = new System.Drawing.Point(246, 44);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(100, 31);
            this.LoadButton.TabIndex = 4;
            this.LoadButton.Text = "Load";
            this.LoadButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 170);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.AddEditButton);
            this.Controls.Add(this.DeliminatorTextBox);
            this.Controls.Add(this.PopDataGridView);
            this.Name = "MainForm";
            this.Text = "Pop Manager";
            ((System.ComponentModel.ISupportInitialize)(this.PopDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PopDataGridView;
        private System.Windows.Forms.TextBox DeliminatorTextBox;
        private System.Windows.Forms.Button AddEditButton;
        private System.Windows.Forms.Button LoadButton;
    }
}

