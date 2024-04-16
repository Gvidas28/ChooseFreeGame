using ChooseFreeGame.Logic.Entities.External;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChooseFreeGame.Logic.Entities.Internal
{
    public class GameDetails
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string LongDescription { get; set; }
        public string Developer { get; set; }
        public string Publisher { get; set; }
        public string ReleaseDate { get; set; }
        public MinimumSystemRequirements MinimumSystemRequirements { get; set; }
        public List<Screenshot> Screenshots { get; set; }
    }
}