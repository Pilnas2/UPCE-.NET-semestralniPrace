using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KulickaCamera : MonoBehaviour
{
    public GameObject targetObject;
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - targetObject.transform.position;
    }

    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, targetObject.transform.position + offset, 0.8f);
    }
}
