
namespace JapaneseLessons
{
    partial class AddWordForm
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
            this.usersComboBox = new System.Windows.Forms.ComboBox();
            this.applyUserButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usersComboBox
            // 
            this.usersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usersComboBox.FormattingEnabled = true;
            this.usersComboBox.Location = new System.Drawing.Point(12, 12);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(352, 23);
            this.usersComboBox.TabIndex = 0;
            // 
            // applyUserButton
            // 
            this.applyUserButton.Location = new System.Drawing.Point(120, 41);
            this.applyUserButton.Name = "applyUserButton";
            this.applyUserButton.Size = new System.Drawing.Size(125, 23);
            this.applyUserButton.TabIndex = 1;
            this.applyUserButton.Text = "Подтвердить";
            this.applyUserButton.UseVisualStyleBackColor = true;
            this.applyUserButton.Click += new System.EventHandler(this.applyUserButton_Click);
            // 
            // AddWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 75);
            this.Controls.Add(this.applyUserButton);
            this.Controls.Add(this.usersComboBox);
            this.Name = "AddWordForm";
            this.Text = "AddWordForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox usersComboBox;
        private System.Windows.Forms.Button applyUserButton;
    }
}