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
    public partial class AddWordForm : Form
    {
        private readonly MyLessonsContext _ctx;

        public AddWordForm(MyLessonsContext ctx)
        {
            _ctx = ctx;
            InitializeComponent();
        }

        private void addWordBtn_Click(object sender, EventArgs e)
        {
            var word = new Word()
            {
                Text = textWordTextBox.Text,
                Meaning = meaningTextBox.Text,
                PronounceJapanese = byLetterWritingTextBox.Text,
                PronounceRussian = pronounceTextBox.Text
            };
            _ctx.Words.Add(word);
            _ctx.SaveChanges();
            Close();
        }
    }
}
