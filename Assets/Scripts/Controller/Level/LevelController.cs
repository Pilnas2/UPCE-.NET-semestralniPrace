using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace Kulicka
{

    public class LevelController : MonoBehaviour
    {
        [field: SerializeField]
        public UnityEvent OnLevelComplete { get; private set; }

        [SerializeField]
        private float _goalResolveTime = 3.0f;
        private float _playerEnterGoalTime;

        public void CheckGoalTriggerStart(Collider other)
        {
            if (other.attachedRigidbody.TryGetComponent<PlayerEntity>(out _))
            {
                _playerEnterGoalTime = Time.time;
            }
        }

        public void CheckGoalTriggerStay(Collider other)
        {
            if (other.attachedRigidbody.TryGetComponent<PlayerEntity>(out _))
            {
                float timeInGoal = Time.time - _playerEnterGoalTime;
                if (timeInGoal >= _goalResolveTime)
                {
                    Debug.Log("Cil");
                    OnLevelComplete.Invoke();
                }
            }
        }
    }
}

