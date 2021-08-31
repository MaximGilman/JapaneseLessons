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

namespace JapaneseLessons
{
    public partial class MainForm : Form
    {
        private User _currentUser;
        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Выбор пользователя
        /// </summary>
        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using MyLessonsContext ctx = new MyLessonsContext();
            var addForm = new AddWordForm(ctx.Users, _currentUser);
            addForm.UserWasSelected += UserWasSelected;
            Application.Run(addForm);
        }

        private void UserWasSelected(User selectedUser)
        {
            _currentUser = selectedUser;
        }

        private void addWordToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
