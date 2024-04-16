using ChooseFreeGame.Logic.Entities.External;
using ChooseFreeGame.Logic.Entities.Internal;
using System.Collections.Generic;

namespace ChooseFreeGame.Logic.Services
{
    public interface IClientService
    {
        List<GameBasic> GetAllGames(RandomGameArgs args);
        GameExtended GetGameDetails(int gameId);
    }
}