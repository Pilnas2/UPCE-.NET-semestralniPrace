using Kulicka.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem.HID;

namespace Kulicka
{

    public class LevelTimer : MonoBehaviour
    {
        [SerializeField]
        private float _timeLeft = 0;
        [field: SerializeField]
        public UnityEvent OnTimesUp { get; private set; }
        [field: SerializeField]
        public UnityEvent<float> OnTimeChange { get; private set; }

        public float TimeLeft
        {
            get => _timeLeft;
            private set
            {
                if (_timeLeft == value) { return; }
                _timeLeft = value;
                OnTimeChange.Invoke(_timeLeft);
                if (_timeLeft == 0)
                {
                    OnTimesUp.Invoke();
                }
            }
        }

        [field: SerializeField]
        public float StartingTimeAmount { get; private set; } = 15;

        public void ResetTimer()
        {
            TimeLeft = StartingTimeAmount;
        }

        protected void Update()
        {
            TimeLeft -= Time.deltaTime;
        }
    }
}
