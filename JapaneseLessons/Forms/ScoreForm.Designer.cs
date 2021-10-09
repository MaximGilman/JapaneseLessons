
namespace JapaneseLessons.Forms
{
    partial class ScoreForm
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
            this.userComboBox = new System.Windows.Forms.ComboBox();
            this.userLabel = new System.Windows.Forms.Label();
            this.triesDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.triesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // userComboBox
            // 
            this.userComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.userComboBox.FormattingEnabled = true;
            this.userComboBox.Location = new System.Drawing.Point(385, 12);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Size = new System.Drawing.Size(225, 23);
            this.userComboBox.TabIndex = 0;
            this.userComboBox.SelectedIndexChanged += new System.EventHandler(this.userComboBox_SelectedIndexChanged);
            // 
            // userLabel
            // 
            this.userLabel.AutoSize = true;
            this.userLabel.Location = new System.Drawing.Point(346, 15);
            this.userLabel.Name = "userLabel";
            this.userLabel.Size = new System.Drawing.Size(33, 15);
            this.userLabel.TabIndex = 1;
            this.userLabel.Text = "User:";
            // 
            // triesDataGrid
            // 
            this.triesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.triesDataGrid.Location = new System.Drawing.Point(12, 41);
            this.triesDataGrid.Name = "triesDataGrid";
            this.triesDataGrid.RowTemplate.Height = 25;
            this.triesDataGrid.Size = new System.Drawing.Size(602, 272);
            this.triesDataGrid.TabIndex = 2;
            // 
            // ScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 325);
            this.Controls.Add(this.triesDataGrid);
            this.Controls.Add(this.userLabel);
            this.Controls.Add(this.userComboBox);
            this.MaximumSize = new System.Drawing.Size(642, 364);
            this.MinimumSize = new System.Drawing.Size(642, 364);
            this.Name = "ScoreForm";
            this.Text = "ScoreForm";
            ((System.ComponentModel.ISupportInitialize)(this.triesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox userComboBox;
        private System.Windows.Forms.Label userLabel;
        private System.Windows.Forms.DataGridView triesDataGrid;
    }
}