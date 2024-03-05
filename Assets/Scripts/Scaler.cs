using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private float _scaleChangeSpeed;
    
    private void Update()
    {
        Vector3 scaleChange = Vector3.one;
        transform.localScale += scaleChange * _scaleChangeSpeed * Time.deltaTime;
    }
}
