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
            this.MainFormMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.PopDataGridView)).BeginInit();
            this.MainFormMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // PopDataGridView
            // 
            this.PopDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PopDataGridView.Location = new System.Drawing.Point(-2, 39);
            this.PopDataGridView.Name = "PopDataGridView";
            this.PopDataGridView.RowTemplate.Height = 28;
            this.PopDataGridView.Size = new System.Drawing.Size(240, 161);
            this.PopDataGridView.TabIndex = 0;
            // 
            // DeliminatorTextBox
            // 
            this.DeliminatorTextBox.Location = new System.Drawing.Point(244, 51);
            this.DeliminatorTextBox.Name = "DeliminatorTextBox";
            this.DeliminatorTextBox.Size = new System.Drawing.Size(100, 26);
            this.DeliminatorTextBox.TabIndex = 1;
            this.DeliminatorTextBox.Text = ",";
            // 
            // AddEditButton
            // 
            this.AddEditButton.Location = new System.Drawing.Point(244, 120);
            this.AddEditButton.Name = "AddEditButton";
            this.AddEditButton.Size = new System.Drawing.Size(100, 80);
            this.AddEditButton.TabIndex = 3;
            this.AddEditButton.Text = "Add / Edit";
            this.AddEditButton.UseVisualStyleBackColor = true;
            this.AddEditButton.Click += new System.EventHandler(this.AddEditButton_Click);
            // 
            // MainFormMenuStrip
            // 
            this.MainFormMenuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.MainFormMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.MainFormMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MainFormMenuStrip.Name = "MainFormMenuStrip";
            this.MainFormMenuStrip.Size = new System.Drawing.Size(347, 33);
            this.MainFormMenuStrip.TabIndex = 5;
            this.MainFormMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(252, 30);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 200);
            this.Controls.Add(this.AddEditButton);
            this.Controls.Add(this.DeliminatorTextBox);
            this.Controls.Add(this.PopDataGridView);
            this.Controls.Add(this.MainFormMenuStrip);
            this.MainMenuStrip = this.MainFormMenuStrip;
            this.Name = "MainForm";
            this.Text = "Pop Manager";
            ((System.ComponentModel.ISupportInitialize)(this.PopDataGridView)).EndInit();
            this.MainFormMenuStrip.ResumeLayout(false);
            this.MainFormMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView PopDataGridView;
        private System.Windows.Forms.TextBox DeliminatorTextBox;
        private System.Windows.Forms.Button AddEditButton;
        private System.Windows.Forms.MenuStrip MainFormMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
    }
}

