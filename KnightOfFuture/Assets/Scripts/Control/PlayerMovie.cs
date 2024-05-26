using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovie : MonoBehaviour
{
    public float moveSpeed;
    public Transform orientation;
    private Rigidbody _rb;
    private PlayerInput _input;
    public LayerMask whatIsGround;
    bool _grounded;

    private void Awake()
    {
        _input = new PlayerInput();
        _input.Player.Jump.performed += context => Jump();
    }

     private void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.freezeRotation = true;
    }

    private void Update()
    {
        _grounded = Physics.Raycast(transform.position, Vector3.down, 1.5f, whatIsGround);
        Move();
        SpeedControl();

        if (_grounded)
        {
            _rb.drag = 0.5f;
        }
        else 
        {
            _rb.drag = 0; 
        }
    }

    private void Move()
    {
        Vector2 _direction = _input.Player.Move.ReadValue<Vector2>();
        Vector3 moveDirection = orientation.right * _direction.x + orientation.forward*_direction.y;
        _rb.AddForce(moveDirection.normalized * moveSpeed, ForceMode.Force);
    }
    private void SpeedControl()
    {
        Vector3 _flatVel = new Vector3(_rb.velocity.x, 0f, _rb.velocity.z);

        if (_flatVel.magnitude > moveSpeed)
        {
            Vector3 _limitedVel = _flatVel.normalized  * moveSpeed;

            _rb.velocity = new Vector3(_limitedVel.x, _rb.velocity.y, _limitedVel.z);
        }
    }
    
    private void Jump()
    {
        if (_grounded)
        {
            _rb.velocity = new Vector3(_rb.velocity.x, 0f, _rb.velocity.z);
            _rb.AddForce(Vector3.up * 5f, ForceMode.Impulse);
        }
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
