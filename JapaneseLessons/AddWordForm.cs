using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using JapaneseLessons.Context;
using JapaneseLessons.Models;

namespace JapaneseLessons
{
    public partial class AddWordForm : Form
    {
        public delegate void UserSelected(User selectedUser);
        public event UserSelected UserWasSelected;
        public AddWordForm(IEnumerable<User> users, User tempUser)
        {
            InitializeComponent();
           
            usersComboBox.DataSource = users;
            usersComboBox.DisplayMember = "Name";
            usersComboBox.ValueMember = "Id";

            if (tempUser != null)
            {
                usersComboBox.SelectedItem = tempUser;
            }
        }
        // Сделать generic комбобокс
        private void applyUserButton_Click(object sender, EventArgs e)
        {
            var selectedUser = usersComboBox.SelectedItem as User;
            UserWasSelected?.Invoke(selectedUser);
        }
    }
}
