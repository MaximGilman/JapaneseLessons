
namespace JapaneseLessons
{
    partial class AddNewWordForm
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
            this.textWordTextBox = new System.Windows.Forms.TextBox();
            this.textLabel = new System.Windows.Forms.Label();
            this.japanesePronounceLabel = new System.Windows.Forms.Label();
            this.byLetterWritingTextBox = new System.Windows.Forms.TextBox();
            this.meaningLabel = new System.Windows.Forms.Label();
            this.meaningTextBox = new System.Windows.Forms.TextBox();
            this.pronounceRussianLabel = new System.Windows.Forms.Label();
            this.pronounceTextBox = new System.Windows.Forms.TextBox();
            this.addWordBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textWordTextBox
            // 
            this.textWordTextBox.Location = new System.Drawing.Point(173, 39);
            this.textWordTextBox.Name = "textWordTextBox";
            this.textWordTextBox.Size = new System.Drawing.Size(136, 23);
            this.textWordTextBox.TabIndex = 0;
            // 
            // textLabel
            // 
            this.textLabel.AutoSize = true;
            this.textLabel.Location = new System.Drawing.Point(93, 42);
            this.textLabel.Name = "textLabel";
            this.textLabel.Size = new System.Drawing.Size(74, 15);
            this.textLabel.TabIndex = 1;
            this.textLabel.Text = "Текст слова:";
            // 
            // japanesePronounceLabel
            // 
            this.japanesePronounceLabel.AutoSize = true;
            this.japanesePronounceLabel.Location = new System.Drawing.Point(52, 71);
            this.japanesePronounceLabel.Name = "japanesePronounceLabel";
            this.japanesePronounceLabel.Size = new System.Drawing.Size(118, 15);
            this.japanesePronounceLabel.TabIndex = 3;
            this.japanesePronounceLabel.Text = "Написание азбукой:";
            // 
            // byLetterWritingTextBox
            // 
            this.byLetterWritingTextBox.Location = new System.Drawing.Point(173, 68);
            this.byLetterWritingTextBox.Name = "byLetterWritingTextBox";
            this.byLetterWritingTextBox.Size = new System.Drawing.Size(136, 23);
            this.byLetterWritingTextBox.TabIndex = 2;
            // 
            // meaningLabel
            // 
            this.meaningLabel.AutoSize = true;
            this.meaningLabel.Location = new System.Drawing.Point(104, 100);
            this.meaningLabel.Name = "meaningLabel";
            this.meaningLabel.Size = new System.Drawing.Size(63, 15);
            this.meaningLabel.TabIndex = 5;
            this.meaningLabel.Text = "Значение:";
            // 
            // meaningTextBox
            // 
            this.meaningTextBox.Location = new System.Drawing.Point(173, 97);
            this.meaningTextBox.Name = "meaningTextBox";
            this.meaningTextBox.Size = new System.Drawing.Size(136, 23);
            this.meaningTextBox.TabIndex = 4;
            // 
            // pronounceRussianLabel
            // 
            this.pronounceRussianLabel.AutoSize = true;
            this.pronounceRussianLabel.Location = new System.Drawing.Point(5, 129);
            this.pronounceRussianLabel.Name = "pronounceRussianLabel";
            this.pronounceRussianLabel.Size = new System.Drawing.Size(162, 15);
            this.pronounceRussianLabel.TabIndex = 7;
            this.pronounceRussianLabel.Text = "Произношение на русском:";
            // 
            // pronounceTextBox
            // 
            this.pronounceTextBox.Location = new System.Drawing.Point(173, 126);
            this.pronounceTextBox.Name = "pronounceTextBox";
            this.pronounceTextBox.Size = new System.Drawing.Size(136, 23);
            this.pronounceTextBox.TabIndex = 6;
            // 
            // addWordBtn
            // 
            this.addWordBtn.Location = new System.Drawing.Point(173, 174);
            this.addWordBtn.Name = "addWordBtn";
            this.addWordBtn.Size = new System.Drawing.Size(136, 23);
            this.addWordBtn.TabIndex = 8;
            this.addWordBtn.Text = "Добавить";
            this.addWordBtn.UseVisualStyleBackColor = true;
            this.addWordBtn.Click += new System.EventHandler(this.addWordBtn_Click);
            // 
            // AddWordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 209);
            this.Controls.Add(this.addWordBtn);
            this.Controls.Add(this.pronounceRussianLabel);
            this.Controls.Add(this.pronounceTextBox);
            this.Controls.Add(this.meaningLabel);
            this.Controls.Add(this.meaningTextBox);
            this.Controls.Add(this.japanesePronounceLabel);
            this.Controls.Add(this.byLetterWritingTextBox);
            this.Controls.Add(this.textLabel);
            this.Controls.Add(this.textWordTextBox);
            this.Name = "AddWordForm";
            this.Text = "AddWordForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textWordTextBox;
        private System.Windows.Forms.Label textLabel;
        private System.Windows.Forms.Label japanesePronounceLabel;
        private System.Windows.Forms.TextBox byLetterWritingTextBox;
        private System.Windows.Forms.Label meaningLabel;
        private System.Windows.Forms.TextBox meaningTextBox;
        private System.Windows.Forms.Label pronounceRussianLabel;
        private System.Windows.Forms.TextBox pronounceTextBox;
        private System.Windows.Forms.Button addWordBtn;
    }

}