using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMultiTransform : MonoBehaviour
{
    [SerializeField] private float _movementSpeed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _scaleChangeSpeed;

    void Start()
    {
        _movementSpeed = 1f;
        _rotateSpeed = -0.05f;
        _scaleChangeSpeed = 0.0001f;
    }

    void Update()
    {
        MoveAxisZ();
        RotateAxisY();
        ScaleAllAxis();
    }

    private void MoveAxisZ()
    {
        Vector3 movementZ = new Vector3(0.0f, 0.0f, _movementSpeed);
        transform.Translate(movementZ * Time.deltaTime);
    }

    private void RotateAxisY()
    {
        Vector3 rotateY = new Vector3(0.0f, _rotateSpeed, 0.0f);
        transform.Rotate(rotateY);
    }

    private void ScaleAllAxis() 
    {
        Vector3 scaleChange = new Vector3(_scaleChangeSpeed, _scaleChangeSpeed, _scaleChangeSpeed);
        transform.localScale += scaleChange;
    }
}
