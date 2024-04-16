using ChooseFreeGame.Logic.Entities.Internal;
using ChooseFreeGame.Logic.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ChooseFreeGame.Logic.Services
{
    public class GameService : IGameService
    {
        private readonly IClientService _clientService;
        private readonly IHelperService _helperService;

        public GameService(
            IClientService clientService,
            IHelperService helperService
            )
        {
            _clientService = clientService;
            _helperService = helperService;
        }

        public ServerResult<RandomGameData> GetRandomGame(RandomGameArgs args)
        {
            try
            {
                var allGames = _clientService.GetAllGames(args);
                if (!allGames.Any())
                    return new() { Success = false, ErrorMessage = "No free to play games found with the current filters!" };

                var randomIndex = _helperService.GetRandomNumber(0, allGames.Count);
                var randomGame = allGames[randomIndex];

                return new()
                {
                    Success = true,
                    Data = new()
                    {
                        ID = randomGame.ID,
                        Title = randomGame.Title,
                        ShortDescription = randomGame.ShortDescription,
                        ImageURL = randomGame.Thumbnail
                    }
                };
            }
            catch (Exception ex)
            {
                return new() { Success = false, ErrorMessage = ex.Message };
            }
        }

        public ServerResult<GameDetails> GetGameDetails(int gameId)
        {
            try
            {
                var gameDetails = _clientService.GetGameDetails(gameId);
                if (gameDetails is null)
                    return new() { Success = false, ErrorMessage = $"Game details are not available for game {gameId}" };

                return new()
                {
                    Success = true,
                    Data = new()
                    {
                        ID = gameDetails.ID,
                        Title = gameDetails.Title,
                        LongDescription = gameDetails.Description,
                        Developer = gameDetails.Developer,
                        Publisher = gameDetails.Publisher,
                        ReleaseDate = gameDetails.ReleaseDate,
                        MinimumSystemRequirements = gameDetails.MinimumSystemRequirements,
                        Screenshots = gameDetails.Screenshots
                    }
                };
            }
            catch (Exception ex)
            {
                return new() { Success = false, ErrorMessage = ex.Message };
            }
        }

        public ServerResult SaveGame(int gameId)
        {
            try
            {
                var gameDetails = _clientService.GetGameDetails(gameId);
                if (gameDetails is null)
                    return new() { Success = false, ErrorMessage = $"Game details are not available for game {gameId}" };

                using (var context = new SavedGameRepository())
                {
                    context.SavedGames.Add(new SavedGame
                    {
                        ID = gameDetails.ID,
                        Title = gameDetails.Title,
                        ShortDescription = gameDetails.ShortDescription,
                        Thumbnail = gameDetails.Thumbnail
                    });

                    context.SaveChanges();
                }

                return new() { Success = true };
            }
            catch (Exception ex)
            {
                return new() { Success = false, ErrorMessage = ex.Message };
            }
        }

        public ServerResult<List<string>> GetSavedGameTitles()
        {
            try
            {
                using (var context = new SavedGameRepository())
                {
                    var savedGames = context.SavedGames.ToList();
                    var gameTitles = savedGames.Select(x => x.Title).ToList();
                    return new() { Success = true, Data = gameTitles };
                }
            }
            catch (Exception ex)
            {
                return new() { Success = false, ErrorMessage = ex.Message };
            }
        }

        public ServerResult<SavedGame> GetSavedGameByTitle(string title)
        {
            try
            {
                using (var context = new SavedGameRepository())
                {
                    var savedGames = context.SavedGames.ToList();
                    var game = savedGames.FirstOrDefault(x => string.Equals(x.Title, title));
                    return new() { Success = true, Data = game };
                }
            }
            catch (Exception ex)
            {
                return new() { Success = false, ErrorMessage = ex.Message };
            }
        }

        public ServerResult DeleteSavedGameByTitle(string title)
        {
            try
            {
                using (var context = new SavedGameRepository())
                {
                    var savedGamesToRemove = context.SavedGames.Where(x => string.Equals(x.Title, title));
                    context.SavedGames.RemoveRange(savedGamesToRemove);
                    context.SaveChanges();
                    return new() { Success = true};
                }
            }
            catch (Exception ex)
            {
                return new() { Success = false, ErrorMessage = ex.Message };
            }
        }
    }
}