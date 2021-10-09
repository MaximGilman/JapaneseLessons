
namespace JapaneseLessons.Forms
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentUserTitle = new System.Windows.Forms.Label();
            this.currentUserValue = new System.Windows.Forms.Label();
            this.mainScreenPanel = new System.Windows.Forms.Panel();
            this.AlphabetLabel = new System.Windows.Forms.Label();
            this.pronounceLabel = new System.Windows.Forms.Label();
            this.translateLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.correctButton = new System.Windows.Forms.Button();
            this.wrongButton = new System.Windows.Forms.Button();
            this.showButton = new System.Windows.Forms.Button();
            this.wordTextRichTextBox = new System.Windows.Forms.RichTextBox();
            this.scoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.mainScreenPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem,
            this.addWordToolStripMenuItem,
            this.userToolStripMenuItem,
            this.scoreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.startToolStripMenuItem.Text = "Start";
            this.startToolStripMenuItem.Click += new System.EventHandler(this.startToolStripMenuItem_Click);
            // 
            // addWordToolStripMenuItem
            // 
            this.addWordToolStripMenuItem.Name = "addWordToolStripMenuItem";
            this.addWordToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.addWordToolStripMenuItem.Text = "AddWord";
            this.addWordToolStripMenuItem.Click += new System.EventHandler(this.addWordToolStripMenuItem_Click);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.userToolStripMenuItem.Text = "User";
            this.userToolStripMenuItem.Click += new System.EventHandler(this.userToolStripMenuItem_Click);
            // 
            // currentUserTitle
            // 
            this.currentUserTitle.AutoSize = true;
            this.currentUserTitle.Location = new System.Drawing.Point(580, 9);
            this.currentUserTitle.Name = "currentUserTitle";
            this.currentUserTitle.Size = new System.Drawing.Size(75, 15);
            this.currentUserTitle.TabIndex = 3;
            this.currentUserTitle.Text = "Current user:";
            // 
            // currentUserValue
            // 
            this.currentUserValue.AutoSize = true;
            this.currentUserValue.Location = new System.Drawing.Point(724, 8);
            this.currentUserValue.Name = "currentUserValue";
            this.currentUserValue.Size = new System.Drawing.Size(0, 15);
            this.currentUserValue.TabIndex = 4;
            // 
            // mainScreenPanel
            // 
            this.mainScreenPanel.Controls.Add(this.AlphabetLabel);
            this.mainScreenPanel.Controls.Add(this.pronounceLabel);
            this.mainScreenPanel.Controls.Add(this.translateLabel);
            this.mainScreenPanel.Controls.Add(this.label3);
            this.mainScreenPanel.Controls.Add(this.label2);
            this.mainScreenPanel.Controls.Add(this.label1);
            this.mainScreenPanel.Controls.Add(this.correctButton);
            this.mainScreenPanel.Controls.Add(this.wrongButton);
            this.mainScreenPanel.Controls.Add(this.showButton);
            this.mainScreenPanel.Controls.Add(this.wordTextRichTextBox);
            this.mainScreenPanel.Location = new System.Drawing.Point(12, 27);
            this.mainScreenPanel.Name = "mainScreenPanel";
            this.mainScreenPanel.Size = new System.Drawing.Size(776, 411);
            this.mainScreenPanel.TabIndex = 5;
            this.mainScreenPanel.Visible = false;
            // 
            // AlphabetLabel
            // 
            this.AlphabetLabel.AutoSize = true;
            this.AlphabetLabel.Location = new System.Drawing.Point(486, 90);
            this.AlphabetLabel.Name = "AlphabetLabel";
            this.AlphabetLabel.Size = new System.Drawing.Size(0, 15);
            this.AlphabetLabel.TabIndex = 9;
            // 
            // pronounceLabel
            // 
            this.pronounceLabel.AutoSize = true;
            this.pronounceLabel.Location = new System.Drawing.Point(486, 65);
            this.pronounceLabel.Name = "pronounceLabel";
            this.pronounceLabel.Size = new System.Drawing.Size(0, 15);
            this.pronounceLabel.TabIndex = 8;
            // 
            // translateLabel
            // 
            this.translateLabel.AutoSize = true;
            this.translateLabel.Location = new System.Drawing.Point(486, 37);
            this.translateLabel.Name = "translateLabel";
            this.translateLabel.Size = new System.Drawing.Size(0, 15);
            this.translateLabel.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(371, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ka-na:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pronounce:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Translate:";
            // 
            // correctButton
            // 
            this.correctButton.Location = new System.Drawing.Point(233, 247);
            this.correctButton.Name = "correctButton";
            this.correctButton.Size = new System.Drawing.Size(136, 31);
            this.correctButton.TabIndex = 3;
            this.correctButton.Text = "Correct";
            this.correctButton.UseVisualStyleBackColor = true;
            this.correctButton.Click += new System.EventHandler(this.correctButton_Click);
            // 
            // wrongButton
            // 
            this.wrongButton.Location = new System.Drawing.Point(69, 247);
            this.wrongButton.Name = "wrongButton";
            this.wrongButton.Size = new System.Drawing.Size(136, 31);
            this.wrongButton.TabIndex = 2;
            this.wrongButton.Text = "Wrong";
            this.wrongButton.UseVisualStyleBackColor = true;
            this.wrongButton.Click += new System.EventHandler(this.wrongButton_Click);
            // 
            // showButton
            // 
            this.showButton.Enabled = false;
            this.showButton.Location = new System.Drawing.Point(146, 187);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(146, 54);
            this.showButton.TabIndex = 1;
            this.showButton.Text = "Show";
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.moveButton_Click);
            // 
            // wordTextRichTextBox
            // 
            this.wordTextRichTextBox.Enabled = false;
            this.wordTextRichTextBox.Font = new System.Drawing.Font("Segoe UI", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.wordTextRichTextBox.Location = new System.Drawing.Point(114, 3);
            this.wordTextRichTextBox.Name = "wordTextRichTextBox";
            this.wordTextRichTextBox.Size = new System.Drawing.Size(203, 178);
            this.wordTextRichTextBox.TabIndex = 0;
            this.wordTextRichTextBox.Text = "";
            // 
            // scoreToolStripMenuItem
            // 
            this.scoreToolStripMenuItem.Name = "scoreToolStripMenuItem";
            this.scoreToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.scoreToolStripMenuItem.Text = "Score";
            this.scoreToolStripMenuItem.Click += new System.EventHandler(this.scoreToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainScreenPanel);
            this.Controls.Add(this.currentUserValue);
            this.Controls.Add(this.currentUserTitle);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Japanese Lessons";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.mainScreenPanel.ResumeLayout(false);
            this.mainScreenPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.Label currentUserTitle;
        private System.Windows.Forms.Label currentUserValue;
        private System.Windows.Forms.Panel mainScreenPanel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button correctButton;
        private System.Windows.Forms.Button wrongButton;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.RichTextBox wordTextRichTextBox;
        private System.Windows.Forms.Label AlphabetLabel;
        private System.Windows.Forms.Label pronounceLabel;
        private System.Windows.Forms.Label translateLabel;
        private System.Windows.Forms.ToolStripMenuItem scoreToolStripMenuItem;
    }
}

