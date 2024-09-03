namespace SoundsLikeaMinecraftVillager
{
    public static class Debug
    {
        public static void Log(string message)
        {
#if DEBUG
            Verse.Log.Message($"[{SoundsLikeaMinecraftVillagerMod.PACKAGE_NAME}] {message}");
#endif
        }
    }
}
