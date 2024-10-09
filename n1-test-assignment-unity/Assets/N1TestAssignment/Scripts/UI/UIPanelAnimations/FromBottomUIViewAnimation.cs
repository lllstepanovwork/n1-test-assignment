using UnityEngine;
using DG.Tweening;
using System;

namespace N1TestAssignment.UI
{
    public class FromBottomUIViewAnimation : IUIViewAnimation
    {
        public void Animate(UIView uIView, bool open, Action onComplete = null)
        {
            float startY = 0;
            float endY = 0;

            if (open)
            {
                startY = -20;
                endY = 0;
            }
            else
            {
                startY = 0;
                endY = -20;
            }

            uIView.contentTransform.position = new Vector3(0, startY, 0);
            uIView.contentTransform.DOMoveY(endY, 1f).OnComplete(() =>
            {
                onComplete?.Invoke();
            });
        }
    }
}