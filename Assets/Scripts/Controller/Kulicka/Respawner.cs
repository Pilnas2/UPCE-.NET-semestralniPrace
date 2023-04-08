using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Respawner : MonoBehaviour
{
    [field: SerializeField]
    public Vector3 SpawnPoint { get; set; }

    public void Respawn()
    {
        transform.position = SpawnPoint;
    }
    protected void Awake()
    {
        SpawnPoint = transform.position;
    }
}
