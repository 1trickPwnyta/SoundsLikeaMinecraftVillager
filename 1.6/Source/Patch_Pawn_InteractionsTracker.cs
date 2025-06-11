using HarmonyLib;
using RimWorld;
using Verse;
using Verse.Sound;

namespace SoundsLikeaMinecraftVillager
{
    [HarmonyPatch(typeof(Pawn_InteractionsTracker))]
    [HarmonyPatch(nameof(Pawn_InteractionsTracker.TryInteractWith))]
    public static class Patch_Pawn_InteractionsTracker
    {
        public static void Postfix(Pawn ___pawn, bool __result)
        {
            if (__result && ___pawn.RaceProps.Humanlike)
            {
                DefDatabase<SoundDef>.GetNamed("Minecraft_Villager").PlayOneShot(___pawn);
            }
        }
    }
}
