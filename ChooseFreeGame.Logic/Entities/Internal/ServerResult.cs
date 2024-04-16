using ChooseFreeGame;
using ChooseFreeGame.Logic;
using ChooseFreeGame.Logic.Entities;
using ChooseFreeGame.Logic.Entities.Internal;

namespace ChooseFreeGame.Logic.Entities.Internal
{
    public class ServerResult
    {
        public bool Success { get; set; }
        public string ErrorMessage { get; set; }
    }

    public class ServerResult<T> : ServerResult
    {
        public T Data { get; set; }
    }
}