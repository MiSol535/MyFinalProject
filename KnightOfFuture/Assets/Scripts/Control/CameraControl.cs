using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CameraControl : MonoBehaviour
{
    private PlayerInput _input;
    public Transform orientation;

    float _xRotation;
    float _yRotation;

    private void Awake()
    {
        _input = new PlayerInput();
    }

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    private void Update()
    {
        Vector2 _cameraDirection = _input.Player.RotateCamera.ReadValue<Vector2>();

        _yRotation += _cameraDirection.x;
        _xRotation -= _cameraDirection.y;

        _xRotation = Mathf.Clamp(_xRotation, -20f, 20f);

        gameObject.transform.rotation = Quaternion.Euler(_xRotation, _yRotation,0);

        orientation.rotation = Quaternion.Euler(0, _yRotation,0);

    }

    private void OnEnable()
    {
        _input.Enable();
    }

    private void OnDisable()
    {
        _input.Disable();
    }
}
