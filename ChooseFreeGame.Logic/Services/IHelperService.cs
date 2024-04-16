using System;

namespace ChooseFreeGame.Logic.Services
{
    public interface IHelperService
    {
        int GetRandomNumber(int minValue, int maxValue);
        string GetEnumDescription(Enum value);
    }
}