using UnityEngine;
using N1TestAssignment.App;

namespace N1TestAssignment.UI
{
    public class UIManager : MonoBehaviour
    {
        [SerializeField] private MainView mainView;
        [SerializeField] private WebViewManager webViewManager;

        private UIViewOpener uIViewOpener = new UIViewOpener();

        private void OnEnable()
        {
            WebViewManager.OnWebViewClose += OpenMainView;
        }

        private void OnDisable()
        {
            WebViewManager.OnWebViewClose -= OpenMainView;
        }

        public void OpenMainView()
        {
            uIViewOpener.OpenView(mainView);
        }

        public void OpenWebView()
        {
            uIViewOpener.CloseView(mainView, ()=>
            {
                webViewManager.ShowUrlFullScreen();
            });
        }
    }
}
