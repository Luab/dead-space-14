using Content.Shared.DeadSpace.Smokables;
using Robust.Client.Graphics;

namespace Content.Client.DeadSpace.Smokables;

public sealed class ShishaSystem : SharedShishaSystem
{
    [Dependency] private readonly IOverlayManager _overlays = default!;

    public override void Initialize()
    {
        base.Initialize();
        _overlays.AddOverlay(new ShishaHoseOverlay(EntityManager));
    }

    public override void Shutdown()
    {
        _overlays.RemoveOverlay<ShishaHoseOverlay>();
        base.Shutdown();
    }
}
