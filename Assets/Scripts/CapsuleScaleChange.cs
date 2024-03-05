using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleScaleChange : MonoBehaviour
{
    [SerializeField] private float _scaleChangeSpeed;

    void Start()
    {
        _scaleChangeSpeed = 0.0001f;
    }
    
    void Update()
    {
        Vector3 scaleChange = new Vector3(_scaleChangeSpeed, _scaleChangeSpeed, _scaleChangeSpeed);
        transform.localScale += scaleChange;
    }
}
