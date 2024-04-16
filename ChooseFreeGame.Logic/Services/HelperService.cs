using System;
using System.ComponentModel;
using System.Linq;

namespace ChooseFreeGame.Logic.Services
{
    public class HelperService : IHelperService
    {
        public int GetRandomNumber(int minValue, int maxValue) => new Random().Next(minValue, maxValue);

        public string GetEnumDescription(Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            if (fieldInfo is null)
                return value.ToString();

            var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            if (attributes?.ToList()?.Any() is true)
                return attributes[0].Description;

            return value.ToString();
        }
    }
}