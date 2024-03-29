using Entitas;
using Entitas.CodeGeneration.Attributes;

namespace Samurai
{
    /// <summary>
    /// 相机动画状态，根据此状态的改变播放相机动画
    /// </summary>
    [Game, Event(EventTarget.Self)]
    public class CameraState : IComponent
    {
        public CameraAniName state;
    }
}
