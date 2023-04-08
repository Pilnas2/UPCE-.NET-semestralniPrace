using Codice.Client.Common;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


namespace Kulicka
{

    [RequireComponent(typeof(KulickaController), typeof(Rigidbody))]
    public class PlayerEntity : MonoBehaviour
    {
        private Vector3 _spawnPoint;
        private Rigidbody _rigidBody;

        [SerializeField]
        public float _respawnTime = 1.44f;

        [SerializeField]
        private float _outOfBoundsDeathRange = 10f;
        private bool _isRespawning;

        [field: SerializeField]
        public UnityEvent OnDeath { get; private set; }

        protected void Awake()
        {
            _rigidBody = GetComponent<Rigidbody>();
            _spawnPoint = _rigidBody.position;
            Platforms.Initiaize();
        }

        public bool Kill()
        {
            OnDeath.Invoke();
            _isRespawning = true;
            StartCoroutine(Respawn());
            return _isRespawning;
        }

        public IEnumerator Respawn()
        {
            _rigidBody.constraints = RigidbodyConstraints.FreezeAll;
            GameObject child = GetComponentInChildren<Renderer>().gameObject;
            child.SetActive(false);
            yield return new WaitForSeconds(_respawnTime);
            _rigidBody.constraints = RigidbodyConstraints.None;
            _rigidBody.position = _spawnPoint;
            _rigidBody.velocity = Vector3.zero;
            _rigidBody.rotation = Quaternion.identity;
            child.SetActive(true);
            yield return new WaitForFixedUpdate();
            _isRespawning = false;
        }

        protected void Update()
        {
            CheckInBounds();
        }

        private void CheckInBounds()
        {
            if (_isRespawning) { return; }
            if ((_rigidBody.position.y + _outOfBoundsDeathRange) < Platforms.MinY)
            {
                Kill();
            }
        }
    }
}
