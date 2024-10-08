using System;

namespace N1TestAssignment.UI
{
    public interface IUIViewAnimation
    {
        public void Animate(UIView uIView, bool open, Action onComplete = null);
    }
}