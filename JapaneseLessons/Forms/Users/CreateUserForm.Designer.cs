
namespace JapaneseLessons.Forms.Users
{
    partial class CreateUserForm
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
            this.createUserButton = new System.Windows.Forms.Button();
            this.createdUserTexBox = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // createUserButton
            // 
            this.createUserButton.Location = new System.Drawing.Point(154, 74);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(75, 23);
            this.createUserButton.TabIndex = 0;
            this.createUserButton.Text = "Create";
            this.createUserButton.UseVisualStyleBackColor = true;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // createdUserTexBox
            // 
            this.createdUserTexBox.Location = new System.Drawing.Point(12, 33);
            this.createdUserTexBox.Name = "createdUserTexBox";
            this.createdUserTexBox.Size = new System.Drawing.Size(217, 23);
            this.createdUserTexBox.TabIndex = 1;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Location = new System.Drawing.Point(12, 9);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(66, 15);
            this.userNameLabel.TabIndex = 2;
            this.userNameLabel.Text = "User name:";
            // 
            // CreateUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 107);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.createdUserTexBox);
            this.Controls.Add(this.createUserButton);
            this.MaximumSize = new System.Drawing.Size(269, 146);
            this.MinimumSize = new System.Drawing.Size(269, 146);
            this.Name = "CreateUserForm";
            this.Text = "Create new user";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.TextBox createdUserTexBox;
        private System.Windows.Forms.Label userNameLabel;
    }
}