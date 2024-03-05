using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private float _rotateSpeed;

    private void Update()
    {
        Vector3 rotate = Vector3.up;
        transform.Rotate(rotate * _rotateSpeed * Time.deltaTime);
    }
}
