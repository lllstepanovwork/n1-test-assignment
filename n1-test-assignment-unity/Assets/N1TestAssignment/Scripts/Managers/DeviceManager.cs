using UnityEngine;

namespace N1TestAssignment.App
{
    public class DeviceManager : MonoBehaviour
    {
        private void OnEnable()
        {
            WebViewManager.OnWebViewOpen += OnWebViewOpen;
            WebViewManager.OnWebViewClose += OnWebViewClose;
        }

        private void OnDisable()
        {
            WebViewManager.OnWebViewOpen -= OnWebViewOpen;
            WebViewManager.OnWebViewClose -= OnWebViewClose;
        }

        private void OnWebViewOpen()
        {
            EnableAutoRotation(true);
            EnableNavigationBar(true);

        }

        private void OnWebViewClose()
        {
            EnableAutoRotation(false);
            EnableNavigationBar(false);
        }

        private void EnableNavigationBar(bool enable)
        {
            Screen.fullScreen = !enable;
        }

        private void EnableAutoRotation(bool enable)
        {
            Screen.autorotateToPortrait = enable;
            Screen.autorotateToPortraitUpsideDown = enable;
            Screen.autorotateToLandscapeLeft = enable;
            Screen.autorotateToLandscapeRight = enable;

            if (enable)
            {
                Screen.orientation = ScreenOrientation.AutoRotation;
            }
            else
            {
                Screen.orientation = ScreenOrientation.Portrait;
            }
        }
    }
}
