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
using Microsoft.EntityFrameworkCore.Internal;

namespace JapaneseLessons
{
    public partial class SelectCurrentUserForm : Form
    {
        private readonly MyLessonsContext _ctx;

        public delegate void UserSelected(User selectedUser);
        public event UserSelected UserWasSelected;
        public SelectCurrentUserForm(MyLessonsContext ctx, User tempUser)
        {
            _ctx = ctx;
            InitializeComponent();
            IEnumerable<User> users = ctx.Users.ToList();
            if (!users.Any()) selectUserBtn.Enabled = false;
            usersComboBox.DataSource = users;
            usersComboBox.DisplayMember = "Name";
            if (tempUser != null)
            {
                usersComboBox.SelectedItem = tempUser;
            }
        }

       

        private void selectUserBtn_Click(object sender, EventArgs e)
        {
            if (usersComboBox.SelectedItem is User selectedUser)
            {
                UserWasSelected?.Invoke(selectedUser);

                // Если установлен пользователь по умолчанию - выставляем его в бд
                if (setUserDefaultCheckBox.CheckState == CheckState.Checked)
                {
                    foreach (var entity in _ctx.DefaultUser)
                        _ctx.DefaultUser.Remove(entity);

                    DefaultUser defaultUser = new DefaultUser() {UserKey = selectedUser.Id};
                    _ctx.DefaultUser.Add(defaultUser);
                    _ctx.SaveChanges();
                }
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Не указан пользователь");
            }
        }

        private void добавитьНовогоПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
