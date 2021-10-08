using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using JapaneseLessons.Context;
using JapaneseLessons.Models;

namespace JapaneseLessons
{
    public partial class AddNewWordForm : Form
    {

        public AddNewWordForm()
        {
            InitializeComponent();
        }

        private void addWordBtn_Click(object sender, EventArgs e)
        {
            using var ctx = new MyLessonsContext();

            var word = new Word()
            {
                Text = textWordTextBox.Text,
                Meaning = meaningTextBox.Text,
                PronounceJapanese = byLetterWritingTextBox.Text,
                PronounceRussian = pronounceTextBox.Text
            };
            ctx.Words.Add(word);
            ctx.SaveChanges();
            Close();
        }
    }
}
