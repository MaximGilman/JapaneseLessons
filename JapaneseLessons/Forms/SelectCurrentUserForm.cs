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

        public delegate void UserSelected(User selectedUser);
        public event UserSelected UserWasSelected;
        public SelectCurrentUserForm(User tempUser)
        {
            InitializeComponent();
            using var ctx = new MyLessonsContext();
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
                using var ctx = new MyLessonsContext();

                // Если установлен пользователь по умолчанию - выставляем его в бд
                if (setUserDefaultCheckBox.CheckState == CheckState.Checked)
                {
                    foreach (var entity in ctx.DefaultUser)
                        ctx.DefaultUser.Remove(entity);

                    DefaultUser defaultUser = new DefaultUser() {UserKey = selectedUser.Id};
                    ctx.DefaultUser.Add(defaultUser);
                    ctx.SaveChanges();
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
            throw new NotImplementedException();
        }
    }
}
