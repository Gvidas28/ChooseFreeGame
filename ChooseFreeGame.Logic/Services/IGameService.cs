using ChooseFreeGame.Logic.Entities.Internal;
using System.Collections.Generic;

namespace ChooseFreeGame.Logic.Services
{
    public interface IGameService
    {
        ServerResult<RandomGameData> GetRandomGame(RandomGameArgs args);
        ServerResult<GameDetails> GetGameDetails(int gameId);
        ServerResult SaveGame(int gameId);
        ServerResult<List<string>> GetSavedGameTitles();
        ServerResult<SavedGame> GetSavedGameByTitle(string title);
        ServerResult DeleteSavedGameByTitle(string title);
    }
}