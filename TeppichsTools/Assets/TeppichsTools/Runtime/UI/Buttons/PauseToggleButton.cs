using TeppichsTools.Time;
using TeppichsTools.UI.Primitives;

namespace TeppichsTools.UI.Buttons
{
    public class PauseToggleButton : ButtonSubscriber
    {
        protected override void PayLoad() => TimeController.TogglePause();
    }
}