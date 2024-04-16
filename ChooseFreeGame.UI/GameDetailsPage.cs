using ChooseFreeGame.Logic.Entities.External;
using ChooseFreeGame.Logic.Entities.Internal;
using ChooseFreeGame.Logic.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ChooseFreeGame.UI
{
    public partial class GameDetailsPage : Form
    {
        public int GameID { get; set; }
        public List<Screenshot> Screenshots { get; set; }

        private readonly IGameService _gameService;
        private readonly IHelperService _helperService;

        public GameDetailsPage(
            IGameService gameService,
            IHelperService helperService
            )
        {
            _gameService = gameService;
            _helperService = helperService;
            InitializeComponent();
        }

        private void GameDetailsPage_VisibleChanged(object sender, EventArgs e)
        {
            if (!this.Visible)
                return;

            var res = _gameService.GetGameDetails(GameID);
            if (!res.Success)
            {
                MessageBox.Show(res.ErrorMessage);
                this.Hide();
            }

            GameIDLabel.Text = res.Data.ID.ToString();
            GameTitleLabel.Text = res.Data.Title;
            GameDescriptionLabel.Text = res.Data.LongDescription;
            DPRDLabel.Text = FormatDPRDInfo(res.Data);

            if (res.Data.MinimumSystemRequirements is not null)
                RequirementsLabel.Text = FormatRequirementsInfo(res.Data);
            if (res.Data.Screenshots is not null)
                Screenshots = res.Data.Screenshots;

            ScreenshotTimer.Enabled = true;
            ScreenshotTimer.Interval = 1000;
        }

        private void GameDetailsPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason is not CloseReason.UserClosing)
                return;

            e.Cancel = true;
            this.Hide();
            GameScreenshotsPictureBox.ImageLocation = null;
            ScreenshotTimer.Enabled = false;
        }

        private string FormatDPRDInfo(GameDetails gameDetails) => $"{gameDetails.Developer} | {gameDetails.Publisher} | {gameDetails.ReleaseDate}";

        private string FormatRequirementsInfo(GameDetails gameDetails) =>
            $"Operating System: {gameDetails.MinimumSystemRequirements.OS} \n" +
            $"Precessor: {gameDetails.MinimumSystemRequirements.Processor} \n" +
            $"Memory (RAM): {gameDetails.MinimumSystemRequirements.Memory} \n" +
            $"Graphics Card: {gameDetails.MinimumSystemRequirements.Graphics} \n" +
            $"Storage: {gameDetails.MinimumSystemRequirements.Storage}";

        private void ScreenshotTimer_Tick(object sender, EventArgs e)
        {
            if (!Screenshots.Any())
                return;

            var randomIndex = _helperService.GetRandomNumber(0, Screenshots.Count);
            var randomScreenshot = Screenshots[randomIndex];

            GameScreenshotsPictureBox.ImageLocation = randomScreenshot.Image;

            ScreenshotTimer.Interval = 3000;
        }
    }
}
