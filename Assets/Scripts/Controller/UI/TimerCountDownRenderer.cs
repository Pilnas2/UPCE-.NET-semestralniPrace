using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TMPro;
using UnityEngine;

namespace Kulicka.UI
{
    [RequireComponent(typeof(TextMeshProUGUI))]
    public class TimerCountdownRenderer : MonoBehaviour
    {
        private TextMeshProUGUI _text;

        public void Render(float timeRemaining)
        {
            _text.text = $"{(int)timeRemaining}".PadLeft(2, '0');
        }

        protected void Awake()
        {
            _text = GetComponent<TextMeshProUGUI>();
        }
    }
}
