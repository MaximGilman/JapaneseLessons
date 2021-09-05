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
using Microsoft.EntityFrameworkCore;

namespace JapaneseLessons
{
    public partial class MainForm : Form
    {
        private User _currentUser;
        public MainForm()
        {
            InitializeComponent();
            using MyLessonsContext ctx = new MyLessonsContext();
            if (ctx.DefaultUser.FirstOrDefault() is { } defaultUser)
            {
                var user = ctx.Users.First(x => x.Id == defaultUser.UserKey);
                UserWasSelected(user);
            }
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
            var addForm = new AddWordForm(ctx);
            addForm.ShowDialog();
        }

        private void startToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
