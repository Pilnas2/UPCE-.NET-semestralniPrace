using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.UI.CanvasScaler;
using UnityEngine.SceneManagement;
using TMPro;

namespace Kulicka.UI
{
    public class HUDController : MonoBehaviour
    {
        [SerializeField]
        internal TimerRenderer _timerCountdown;

    }
    public static class HUD
    {
        public static void Initialize()
        {
            if (_init) { return; }
            _init = true;
            Scene hud = SceneManager.GetSceneByBuildIndex(1);
            if (!hud.isLoaded) { SceneManager.LoadScene("HUD", LoadSceneMode.Additive); }
        }

        internal static HUDController _controller;

        public static void RenderTimer(float remaining)
        {
            Initialize();
            _controller?._timerCountdown.Render(remaining);
        }
        internal static bool _init = false;

    }
}
