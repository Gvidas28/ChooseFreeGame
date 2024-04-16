using ChooseFreeGame.Logic.Entities.Enums;
using ChooseFreeGame.Logic.Entities.Internal;
using ChooseFreeGame.Logic.Services;
using System;
using System.Windows.Forms;

namespace ChooseFreeGame.UI
{
    public partial class MainPage : Form
    {
        private readonly GameDetailsPage _gameDetailsPage;
        private readonly SavedGamesPage _savedGamesPage;
        private readonly IGameService _gameService;

        public MainPage(
            GameDetailsPage gameDetailsPage,
            SavedGamesPage savedGamesPage,
            IGameService gameService
            )
        {
            _gameDetailsPage = gameDetailsPage;
            _savedGamesPage = savedGamesPage;
            _gameService = gameService;
            InitializeComponent();
        }

        private void MainPage_Load(object sender, System.EventArgs e)
        {
            PlatformComboBox.DataSource = Enum.GetValues(typeof(Platform));
            CategoryComboBox.DataSource = Enum.GetValues(typeof(Category));
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            var res = _gameService.GetRandomGame(new RandomGameArgs
            {
                Platform = (Platform)PlatformComboBox.SelectedItem,
                Category = (Category)CategoryComboBox.SelectedItem
            });

            if (!res.Success)
            {
                MessageBox.Show(res.ErrorMessage);
                return;
            }

            GameIDLabel.Text = res.Data.ID.ToString();
            GameTitleLabel.Text = res.Data.Title;
            GameDescriptionLabel.Text = res.Data.ShortDescription;
            GameImagePictureBox.ImageLocation = res.Data.ImageURL;

            ViewDetailsButton.Visible = true;
            SaveGameButton.Visible = true;
        }

        private void ViewDetailsButton_Click(object sender, EventArgs e)
        {
            try
            {
                _gameDetailsPage.GameID = int.Parse(GameIDLabel.Text);
                _gameDetailsPage.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open game details due to {ex.Message}");
            }
        }

        private void SaveGameButton_Click(object sender, EventArgs e)
        {
            var saveMessage = "Game saved successfully!";

            var res = _gameService.SaveGame(int.Parse(GameIDLabel.Text));
            if (!res.Success)
                saveMessage = $"Failed to save the game due to {res.ErrorMessage}";

            MessageBox.Show(saveMessage);
        }

        private void SavedGamesButton_Click(object sender, EventArgs e)
        {
            try
            {
                _savedGamesPage.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to open saved games due to {ex.Message}");
            }
        }
    }
}