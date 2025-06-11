using HarmonyLib;
using Verse;

namespace SoundsLikeaMinecraftVillager
{
    public class SoundsLikeaMinecraftVillagerMod : Mod
    {
        public const string PACKAGE_ID = "soundslikeaminecraftvillager.1trickPwnyta";
        public const string PACKAGE_NAME = "Sounds Like a Minecraft Villager";

        public SoundsLikeaMinecraftVillagerMod(ModContentPack content) : base(content)
        {
            var harmony = new Harmony(PACKAGE_ID);
            harmony.PatchAll();

            Log.Message($"[{PACKAGE_NAME}] Loaded.");
        }
    }
}
