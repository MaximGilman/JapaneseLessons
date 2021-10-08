
namespace JapaneseLessons.Forms
{
    partial class SelectCurrentUserForm
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
            this.selectUserBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.добавитьНовогоПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setUserDefaultCheckBox = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // usersComboBox
            // 
            this.usersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.usersComboBox.FormattingEnabled = true;
            this.usersComboBox.Location = new System.Drawing.Point(12, 21);
            this.usersComboBox.Name = "usersComboBox";
            this.usersComboBox.Size = new System.Drawing.Size(415, 23);
            this.usersComboBox.TabIndex = 0;
            // 
            // selectUserBtn
            // 
            this.selectUserBtn.Location = new System.Drawing.Point(12, 49);
            this.selectUserBtn.Name = "selectUserBtn";
            this.selectUserBtn.Size = new System.Drawing.Size(202, 23);
            this.selectUserBtn.TabIndex = 1;
            this.selectUserBtn.Text = "Confirm";
            this.selectUserBtn.UseVisualStyleBackColor = true;
            this.selectUserBtn.Click += new System.EventHandler(this.selectUserBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.добавитьНовогоПользователяToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(439, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // добавитьНовогоПользователяToolStripMenuItem
            // 
            this.добавитьНовогоПользователяToolStripMenuItem.Name = "добавитьНовогоПользователяToolStripMenuItem";
            this.добавитьНовогоПользователяToolStripMenuItem.Size = new System.Drawing.Size(91, 20);
            this.добавитьНовогоПользователяToolStripMenuItem.Text = "Add new user";
            this.добавитьНовогоПользователяToolStripMenuItem.Click += new System.EventHandler(this.добавитьНовогоПользователяToolStripMenuItem_Click);
            // 
            // setUserDefaultCheckBox
            // 
            this.setUserDefaultCheckBox.AutoSize = true;
            this.setUserDefaultCheckBox.Location = new System.Drawing.Point(284, 53);
            this.setUserDefaultCheckBox.Name = "setUserDefaultCheckBox";
            this.setUserDefaultCheckBox.Size = new System.Drawing.Size(113, 19);
            this.setUserDefaultCheckBox.TabIndex = 3;
            this.setUserDefaultCheckBox.Text = "Save on the start";
            this.setUserDefaultCheckBox.UseVisualStyleBackColor = false;
            // 
            // SelectCurrentUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 91);
            this.Controls.Add(this.setUserDefaultCheckBox);
            this.Controls.Add(this.selectUserBtn);
            this.Controls.Add(this.usersComboBox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SelectCurrentUserForm";
            this.Text = "SelectCurrentUserForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox usersComboBox;
        private System.Windows.Forms.Button selectUserBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem добавитьНовогоПользователяToolStripMenuItem;
        private System.Windows.Forms.CheckBox setUserDefaultCheckBox;
    }
}