using ChooseFreeGame.Logic.Services;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ChooseFreeGame.UI
{
    public partial class SavedGamesPage : Form
    {
        private readonly IGameService _gameService;

        public SavedGamesPage(
            IGameService gameService
            )
        {
            _gameService = gameService;
            InitializeComponent();
        }

        private void SavedGamesForm_Load(object sender, EventArgs e) => LoadGameTitles();

        private void LoadGameTitles()
        {
            var gameTitles = _gameService.GetSavedGameTitles();
            if (!gameTitles.Success)
                MessageBox.Show(gameTitles.ErrorMessage);

            SavedGamesComboBox.DataSource = gameTitles.Data;
        }

        private void LoadSavedGameDetails()
        {
            if (string.IsNullOrWhiteSpace(SavedGamesComboBox.SelectedItem?.ToString()))
                return;

            var res = _gameService.GetSavedGameByTitle(SavedGamesComboBox.SelectedItem.ToString());
            if (!res.Success)
                MessageBox.Show(res.ErrorMessage);

            DescriptionLabel.Text = res.Data.ShortDescription;
            GameThumbnailPictureBox.ImageLocation = res.Data.Thumbnail;
        }

        private void SavedGamesComboBox_SelectedIndexChanged(object sender, EventArgs e) => LoadSavedGameDetails();

        private void DeleteGameButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SavedGamesComboBox.SelectedItem?.ToString()))
            {
                MessageBox.Show("No game selected!");
                return;
            }

            var res = _gameService.DeleteSavedGameByTitle(SavedGamesComboBox.SelectedItem.ToString());
            if (!res.Success)
                MessageBox.Show(res.ErrorMessage);

            LoadGameTitles();
        }

        private void SavedGamesPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason is not CloseReason.UserClosing)
                return;

            LoadGameTitles();

            e.Cancel = true;
            this.Hide();
        }
    }
}
