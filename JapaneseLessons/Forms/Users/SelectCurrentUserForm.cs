using JapaneseLibrary.Models;
using JapaneseLibrary.Repositories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JapaneseLessons.Forms.Users
{
    public partial class SelectCurrentUserForm : Form
    {
        private readonly IRepository<DefaultUser> _defaultUserRepository;
        private readonly IRepository<User> _userRepository;
        public delegate void UserSelected(User selectedUser);
        public event UserSelected UserWasSelected;

        public static async Task<SelectCurrentUserForm> CreateForm(IRepository<User> userRepository, IRepository<DefaultUser> defaultUserRepository,
            User currentUser)
        {
            var users = await userRepository.Get();
            return new SelectCurrentUserForm(users, defaultUserRepository, userRepository, currentUser);
        }

        private SelectCurrentUserForm(IEnumerable<User> users, IRepository<DefaultUser> defaultUserRepository,
            IRepository<User> userRepository, User tempUser)
        {
            InitializeComponent();
            _defaultUserRepository = defaultUserRepository;
            _userRepository = userRepository;

            SetUsersToDropdown(users);

            if (tempUser != null)
            {
                usersComboBox.SelectedItem = tempUser;
            }
        }



        private async void selectUserBtn_Click(object sender, EventArgs e)
        {
            if (usersComboBox.SelectedItem is User selectedUser)
            {
                UserWasSelected?.Invoke(selectedUser);

                // Set default user, if needed
                if (setUserDefaultCheckBox.CheckState == CheckState.Checked)
                {
                    // in basic way there will be only one, but we will delete all for sure
                    var defaultUsers = await _defaultUserRepository.Get();
                    await _defaultUserRepository.Remove(defaultUsers);

                    DefaultUser defaultUser = new DefaultUser() { UserKey = selectedUser.Id };
                    await _defaultUserRepository.Add(defaultUser);
                }

                this.Close();
            }
            else
            {
                MessageBox.Show(@"No user provided");
            }
        }

        private void addNewUserMenuStrip_Click(object sender, EventArgs e)
        {
            var createUserForm = Program.ServiceProvider.GetService<CreateUserForm>();
            createUserForm.UserWasAdded += UpdateUserList;
            createUserForm.ShowDialog();
        }

        private async void UpdateUserList()
        {
            var users = await _userRepository.Get();
            SetUsersToDropdown(users);
        }

        private void SetUsersToDropdown(IEnumerable<User> users)
        {
            if (!users.Any()) selectUserBtn.Enabled = false;
            usersComboBox.DataSource = users;
            usersComboBox.DisplayMember = "Name";
        }
    }
}
