using System;
using System.Windows.Forms;
using JapaneseLessons.Models;
using JapaneseLessons.Repositories;

namespace JapaneseLessons.Forms.Users
{
    public partial class CreateUserForm : Form
    {
        public delegate void UserAdded();
        public event UserAdded UserWasAdded;

        private readonly IRepository<User> _userRepository;

        public CreateUserForm(IRepository<User> userRepository)
        {
            _userRepository = userRepository;
            InitializeComponent();
        }

        private async void createUserButton_Click(object sender, EventArgs e)
        {
            string userName = createdUserTexBox.Text;
            if(string.IsNullOrEmpty(userName))
                Close();
            
            if (await _userRepository.GetFirstOrDefault(x => 
                string.Equals(x.Name, userName/*, StringComparison.InvariantCultureIgnoreCase*/)
            ) is { })
            {
                MessageBox.Show(@"User with the same name already exists");
            }

            var newUser = new User() {Name = userName};
            await _userRepository.Add(newUser);
            UserWasAdded?.Invoke();
            Close();
        }
    }
}
