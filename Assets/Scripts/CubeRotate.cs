using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeRotate : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;

    void Start()
    {
        _rotateSpeed = 0.5f;
    }

    void Update()
    {
        Vector3 rotateY = new Vector3(0.0f, _rotateSpeed,0.0f);
        transform.Rotate(rotateY);
    }
}
