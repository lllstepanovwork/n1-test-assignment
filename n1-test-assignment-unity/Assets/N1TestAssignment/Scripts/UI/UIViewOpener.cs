using System;

namespace N1TestAssignment.UI
{
    public class UIViewOpener
    {
        public void OpenView(UIView uIView, Action onComplete = null)
        {
            switch (uIView.AnimationType)
            {
                case UIViewAnimationType.FromBottom:
                    IUIViewAnimation UIPanelAnimation = new FromBottomUIViewAnimation();

                    uIView.gameObject.SetActive(true);
                    UIPanelAnimation.Animate(uIView, true, () =>
                    {
                        onComplete?.Invoke();
                    });
                    break;
                case UIViewAnimationType.None:
                    uIView.gameObject.SetActive(true);
                    onComplete?.Invoke();
                    break;
            }
        }

        public void CloseView(UIView uIView, Action onComplete = null)
        {
            switch (uIView.AnimationType)
            {
                case UIViewAnimationType.FromBottom:
                    IUIViewAnimation UIPanelAnimation = new FromBottomUIViewAnimation();

                    UIPanelAnimation.Animate(uIView, false, () =>
                    {
                        uIView.gameObject.SetActive(false);
                        onComplete?.Invoke();
                    });
                    break;
                case UIViewAnimationType.None:
                    uIView.gameObject.SetActive(false);
                    onComplete?.Invoke();
                    break;
            }
        }
    }
}


