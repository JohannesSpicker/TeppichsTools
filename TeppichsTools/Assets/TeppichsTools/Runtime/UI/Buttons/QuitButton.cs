﻿using TeppichsTools.Behavior;
using TeppichsTools.UI.Primitives;

namespace TeppichsTools.Runtime.UI.Buttons
{
    public class QuitButton : ButtonSubscriber
    {
        protected override void PayLoad() => QuitHelper.Quit();
    }
}