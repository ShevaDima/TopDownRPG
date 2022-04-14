using UnityEngine;

namespace CodeBase.Services.Input
{
    public class MobileinputService : InputService
    {
        public override Vector2 Axis => SimpleInputAxis();
    }
}