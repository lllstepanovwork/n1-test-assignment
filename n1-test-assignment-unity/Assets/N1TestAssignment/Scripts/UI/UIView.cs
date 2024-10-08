using UnityEngine;

namespace N1TestAssignment.UI
{
    public enum UIViewAnimationType
    {
        FromBottom,
        None
    }

    public abstract class UIView : MonoBehaviour
    {
        [Header("UI View Content")]
        public CanvasGroup canvasGroup;
        public Transform contentTransform;
        public UIViewAnimationType AnimationType;
    }
}