using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using JapaneseLessons.Context;
using JapaneseLessons.Models;
using JapaneseLessons.Repositories;

namespace JapaneseLessons.Forms
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

            if (!users.Any()) selectUserBtn.Enabled = false;
            usersComboBox.DataSource = users;
            usersComboBox.DisplayMember = "Name";
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
                MessageBox.Show("No user provided");
            }
        }

        private void добавитьНовогоПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
