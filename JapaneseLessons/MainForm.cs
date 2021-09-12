using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using JapaneseLessons.Context;
using JapaneseLessons.Models;
using JapaneseLessons.Services;
using Microsoft.EntityFrameworkCore;

namespace JapaneseLessons
{
    public partial class MainForm : Form
    {
        private User _currentUser;
        private Try _currentRun;
        private Word _currentWord;

        private WordProducer _wordProducer;
        public MainForm()
        {
            InitializeComponent();
            using MyLessonsContext ctx = new MyLessonsContext();
            if (ctx.DefaultUser.FirstOrDefault() is { } defaultUser)
            {
                var user = ctx.Users.First(x => x.Id == defaultUser.UserKey);
                UserWasSelected(user);
            }

            _wordProducer = new WordProducer();
            _wordProducer.AllWordsWerePassed += WordProducerOnAllWordsWerePassed;
        }

        private void WordProducerOnAllWordsWerePassed()
        {
            _wordProducer = null;
            using MyLessonsContext ctx = new MyLessonsContext();
            ctx.Tries.Add(_currentRun);
            ctx.SaveChanges();
            MessageBox.Show($"Завершено! Результат: {_currentRun.SuccessCount}/{_currentRun.WordsCount}");
            _currentRun = null;
            _currentWord = null;
        }

        /// <summary>
        /// Выбор пользователя
        /// </summary>
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using MyLessonsContext ctx = new MyLessonsContext();
            var addForm = new SelectCurrentUserForm(ctx, _currentUser);
            addForm.UserWasSelected += UserWasSelected;
            addForm.ShowDialog();
        }

        private void UserWasSelected(User selectedUser)
        {
            _currentUser = selectedUser;
            currentUserValue.Text = _currentUser.Name;
        }

        private void addWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using MyLessonsContext ctx = new MyLessonsContext();
            var addForm = new AddNewWordForm(ctx);
            addForm.ShowDialog();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Отобразить форму
            // Создать ран
            // Взять слова из списка
            // Для каждого слова вывести его текст и спросить, помнит ли его пользователь
            // Если слово угадано - записать его в успешные, иначе в ошибки

            mainScreenPanel.Visible = true;
            using MyLessonsContext ctx = new MyLessonsContext();

            _currentRun = new Try();
            _wordProducer.SetupWords(ctx);
            PlayWithTheWord();

        }

        private void PlayWithTheWord()
        {
            _currentWord = _wordProducer.GetNextWord();
            wordTextRichTextBox.Text = _currentWord?.Text;

            // очистка со старого
            translateLabel.Text = string.Empty;
            pronounceLabel.Text = string.Empty;
            AlphabetLabel.Text = string.Empty;
        }

        private void SwapButtonsEnable()
        {
            // Должно гореть либо дейсвтие "дальше", либо проверки
            wrongButton.Enabled = showButton.Enabled;
            correctButton.Enabled = showButton.Enabled;

            showButton.Enabled = !showButton.Enabled;
        }

        private void wrongButton_Click(object sender, EventArgs e)
        {
            SwapButtonsEnable();
            _currentRun.ErrorCount++;
            AppendWord();
        }

        private void correctButton_Click(object sender, EventArgs e)
        {
            SwapButtonsEnable();
            _currentRun.SuccessCount++;
            AppendWord();
        }

        private void AppendWord()
        {
            _currentRun.WordsCount++;
            _currentRun.LearnedWords.Add(_currentWord);
            SwapButtonsEnable();
            PlayWithTheWord();
        }

        private void moveButton_Click(object sender, EventArgs e)
        {
            translateLabel.Text = _currentWord.Meaning;
            pronounceLabel.Text = _currentWord.PronounceRussian;
            AlphabetLabel.Text = _currentWord.PronounceJapanese;
            SwapButtonsEnable();
        }
    }
}
