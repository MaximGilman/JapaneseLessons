using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using JapaneseLessons.Models;
using JapaneseLessons.Repositories;

namespace JapaneseLessons.Forms
{
    public partial class ScoreForm : Form
    {
        private readonly IRepository<Try> _tryRepository;
        private BindingSource triesSource = new BindingSource();

        public static async Task<ScoreForm> CreateForm(IRepository<Try> tryRepository, IRepository<User> userRepository)
        {
            var users = await userRepository.Get();
            return new ScoreForm(tryRepository, users);
        }
        private ScoreForm(IRepository<Try> tryRepository, IEnumerable<User> users)
        {
            _tryRepository = tryRepository;
            InitializeComponent();
            
            triesDataGrid.AutoSize = true;
            triesDataGrid.DataSource = triesSource;
            
            userComboBox.DataSource = users;
            userComboBox.DisplayMember = "Name";
        }

        private async void userComboBox_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            triesSource.DataSource = await _tryRepository.Get();
        }
    }
}
