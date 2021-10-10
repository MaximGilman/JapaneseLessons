using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using JapaneseLessons.Forms.Users;
using JapaneseLessons.Models;
using JapaneseLessons.Repositories;
using JapaneseLessons.Services;
using Microsoft.Extensions.DependencyInjection;

namespace JapaneseLessons.Forms
{
    public partial class MainForm : Form
    {
        private User _currentUser;
        private Try _currentRun;
        private Word _currentWord;

        private WordProducer _wordProducer;

        private readonly IRepository<Word> _wordRepository = Program.ServiceProvider.GetService<IRepository<Word>>();
        private readonly IRepository<Try> _tryRepository = Program.ServiceProvider.GetService<IRepository<Try>>();
        private readonly IRepository<User> _userRepository = Program.ServiceProvider.GetService<IRepository<User>>();
        private readonly IRepository<DefaultUser> _defaultRepository = Program.ServiceProvider.GetService<IRepository<DefaultUser>>();

        public static async Task<MainForm> CreateFormAsync()
        {
            var defaultUserRepository =Program.ServiceProvider.GetService<IRepository<DefaultUser>>();
            var userRepository = Program.ServiceProvider.GetService<IRepository<User>>();
            User defaultUserData = null;
            if (await defaultUserRepository.GetFirstOrDefault() is { } defaultUser)
            {
                defaultUserData = await userRepository.GetFirstOrDefault(x => x.Id == defaultUser.UserKey);
            }

            return new MainForm(defaultUserData);
        }

        private MainForm(User defaultUser)
        {
            InitializeComponent();

            UserWasSelected(defaultUser);
            _wordProducer = Program.ServiceProvider.GetService<WordProducer>();
            _wordProducer.AllWordsWerePassed += WordProducerOnAllWordsWerePassed;
        }

        private void WordProducerOnAllWordsWerePassed()
        {
            _wordProducer = null;
            _currentRun.PercentOfSuccess = _currentRun.SuccessCount / _currentRun.WordsCount;
            _tryRepository.Add(_currentRun);
            mainScreenPanel.Visible = false;

            MessageBox.Show($@"Run finished! Result: {_currentRun.SuccessCount}/{_currentRun.WordsCount}");
            _currentRun = null;
            _currentWord = null;
        }

        /// <summary>
        /// User selection
        /// </summary>
        private async void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addForm = await SelectCurrentUserForm.CreateForm(_userRepository, _defaultRepository, _currentUser);
            addForm.UserWasSelected += UserWasSelected;
            addForm.ShowDialog();
        }

        private void UserWasSelected(User selectedUser)
        {
            _currentUser = selectedUser;
            if (_currentUser != null)
                currentUserValue.Text = _currentUser.Name;
        }

        private void addWordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var addForm = new AddNewWordForm(_wordRepository);
            addForm.ShowDialog();
        }

        private async void startToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Отобразить форму
            // Создать ран
            // Взять слова из списка
            // Для каждого слова вывести его текст и спросить, помнит ли его пользователь
            // Если слово угадано - записать его в успешные, иначе в ошибки

            mainScreenPanel.Visible = true;

            _currentRun = new Try();
            await _wordProducer.SetupWords();
            SwapButtonsEnable();
            PlayWithTheWord();

        }

        private void PlayWithTheWord()
        {
            _currentWord = _wordProducer.GetNextWord();
            if (_currentWord != null)
                wordTextRichTextBox.Text = _currentWord?.Text;

            // clear existed data
            translateLabel.Text = string.Empty;
            pronounceLabel.Text = string.Empty;
            AlphabetLabel.Text = string.Empty;
        }

        private void SwapButtonsEnable()
        {
            // There either should be able 'next' button or 'check'
            wrongButton.Enabled = showButton.Enabled;
            correctButton.Enabled = showButton.Enabled;

            showButton.Enabled = !showButton.Enabled;
        }

        private void wrongButton_Click(object sender, EventArgs e)
        {
            _currentRun.ErrorCount++;
            AppendWord();
        }

        private void correctButton_Click(object sender, EventArgs e)
        {
            _currentRun.SuccessCount++;
            AppendWord();
        }

        private void AppendWord()
        {
            _currentRun.WordsCount++;
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

        private async void scoreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var scoreForm = await ScoreForm.CreateForm(_tryRepository, _userRepository);
            scoreForm.ShowDialog();
        }
    }
}
