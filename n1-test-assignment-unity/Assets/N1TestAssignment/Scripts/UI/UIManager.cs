using System.Collections.Generic;
using UnityEngine;

namespace N1TestAssignment.UI
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private MainView mainView;

        private UIViewOpener uIViewOpener = new UIViewOpener();
        private Stack<UIView> uIViewStack = new Stack<UIView>();

        public void Start()
        {
            //Init();
        }

        public void Init()
        {
            OpenMainView();
        }

        public void OpenMainView()
        {
            uIViewStack.Push(mainView);
            uIViewOpener.OpenView(mainView);
        }

        public void OpenWebView()
        {

        }

        public void CloseLastUIViewInStack()
        {
            if (uIViewStack.Count > 0)
            {
                uIViewOpener.CloseView(uIViewStack.Pop());
            }
        }
    }
}
