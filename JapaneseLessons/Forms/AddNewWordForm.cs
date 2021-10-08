using System;
using System.Windows.Forms;
using JapaneseLessons.Context;
using JapaneseLessons.Models;
using JapaneseLessons.Repositories;

namespace JapaneseLessons.Forms
{
    public partial class AddNewWordForm : Form
    {
        private readonly IRepository<Word> _wordRepository;

        public AddNewWordForm(IRepository<Word> wordRepository)
        {
            _wordRepository = wordRepository;
            InitializeComponent();
        }

        private async void addWordBtn_Click(object sender, EventArgs e)
        {
            var word = new Word()
            {
                Text = textWordTextBox.Text,
                Meaning = meaningTextBox.Text,
                PronounceJapanese = byLetterWritingTextBox.Text,
                PronounceRussian = pronounceTextBox.Text
            };
            await _wordRepository.Add(word);
           
            Close();
        }
    }
}
