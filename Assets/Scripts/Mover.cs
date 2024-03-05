using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Vector3 movement = Vector3.forward;
        transform.Translate(movement * _speed * Time.deltaTime);
    }
}
