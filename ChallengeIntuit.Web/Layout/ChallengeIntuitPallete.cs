﻿using MudBlazor.Utilities;
using MudBlazor;

namespace ChallengeIntuit.Web.Layout
{
    public sealed class ChallengeIntuitPallete : PaletteDark
    {
        private ChallengeIntuitPallete()
        {
            Primary = new MudColor("#9966FF");
            Secondary = new MudColor("#F6AD31");
            Tertiary = new MudColor("#8AE491");
        }

        public static ChallengeIntuitPallete CreatePallete => new();
    }
}
