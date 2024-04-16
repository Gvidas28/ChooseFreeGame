using System;
using ChooseFreeGame;
using ChooseFreeGame.Logic;
using ChooseFreeGame.Logic.Entities;
using ChooseFreeGame.Logic.Entities.Exceptions;

namespace ChooseFreeGame.Logic.Entities.Exceptions
{
    public class CommunicationException : Exception
    {
        public CommunicationException(string message) : base(message) { }
    }
}