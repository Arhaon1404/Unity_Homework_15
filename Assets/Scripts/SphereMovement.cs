using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereMovement : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Start()
    {
        _speed = 1;
    }

    void Update()
    {
        Vector3 movementZ = new Vector3(0.0f, 0.0f, _speed);
        transform.Translate(movementZ * Time.deltaTime);
    }
}
