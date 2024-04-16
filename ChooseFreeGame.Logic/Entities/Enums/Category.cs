using System.ComponentModel;

namespace ChooseFreeGame.Logic.Entities.Enums
{
    public enum Category
    {
        [Description("any")]
        ALL = 0,

        [Description("mmorpg")]
        MMORPG = 1,

        [Description("shooter")]
        SHOOTER = 2,

        [Description("strategy")]
        STRATEGY = 3,

        [Description("moba")]
        MOBA = 4,

        [Description("racing")]
        RACING = 5,

        [Description("sports")]
        SPORTS = 6,

        [Description("social")]
        SOCIAL = 7,

        [Description("sandbox")]
        SANDBOX = 8,

        [Description("open-world")]
        OPENWORLD = 9,

        [Description("survival")]
        SURVIVAL = 10,

        [Description("pvp")]
        PVP = 11,

        [Description("pve")]
        PVE = 12,

        [Description("pixel")]
        PIXEL = 13,

        [Description("voxel")]
        VOXEL = 14,

        [Description("zombie")]
        ZOMBIE = 15,

        [Description("turn-based")]
        TURNBASED = 16,

        [Description("first-person")]
        FIRSTPERSON = 17,

        [Description("third-Person")]
        THIRDPERSON = 18,

        [Description("top-down")]
        TOPDOWN = 19,

        [Description("tank")]
        TANK = 20,

        [Description("space")]
        SPACE = 21,

        [Description("sailing")]
        SAILING = 22,

        [Description("side-scroller")]
        SIDESCROLLER = 23,

        [Description("superhero")]
        SUPERHERO = 24,

        [Description("permadeath")]
        PERMADEATH = 25,

        [Description("card")]
        CARD = 26,

        [Description("battle-royale")]
        BATTLEROYALE = 27,

        [Description("mmo")]
        MMO = 28,

        [Description("mmofps")]
        MMOFPS = 29,

        [Description("mmotps")]
        MMOTPS = 30,

        [Description("3d")]
        THREEDIMENSIONAL = 31,

        [Description("2d")]
        TWODIMENSIONAL = 32,

        [Description("anime")]
        ANIME = 33,

        [Description("fantasy")]
        FANTASY = 34,

        [Description("sci-fi")]
        SCIFI = 35,

        [Description("fighting")]
        FIGHTING = 36,

        [Description("action-rpg")]
        ACTIONRPG = 37,

        [Description("action")]
        ACTION = 38,

        [Description("military")]
        MILITARY = 39,

        [Description("martial-arts")]
        MARTIALARTS = 40,

        [Description("flight")]
        FLIGHT = 41,

        [Description("low-spec")]
        LOWSPEC = 42,

        [Description("tower-defense")]
        TOWERDEFENSE = 43,

        [Description("horror")]
        HORROR = 44,

        [Description("mmorts")]
        MMORTS = 45
    }
}