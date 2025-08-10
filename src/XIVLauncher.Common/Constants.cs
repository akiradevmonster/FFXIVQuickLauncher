using System;

namespace XIVLauncher.Common
{
    public static class Constants
    {
        public const string BASE_GAME_VERSION = "2012.01.01.0000.0000";

        public const uint STEAM_APP_ID = 39210;
        public const uint STEAM_FT_APP_ID = 312060;

        public static string PatcherUserAgent => GetPatcherUserAgent(Util.GetPlatform());

        private static string GetPatcherUserAgent(Platform platform)
        {
            switch (platform)
            {
                case Platform.Win32:
                case Platform.Win32OnLinux:
                    return "FFXIV PATCH CLIENT";

                case Platform.Mac:
                    return "FFXIV-MAC PATCH CLIENT";

                default:
                    throw new ArgumentOutOfRangeException(nameof(platform), platform, null);
            }
        }

        private static string GetPatcherAdminAgent(Platform platform)
        {
            switch (platform)
            {
                case Platform.Win32:
                case Platform.Win32OnLinux:
                    return "FFXIV PATCH ADMIN";

                case Platform.Mac:
                    return "FFXIV-MAC PATCH ADMIN";

                default:
                    throw new ArgumentOutOfRangeException(nameof(platform), platform, null);
            }
        }
    }
}