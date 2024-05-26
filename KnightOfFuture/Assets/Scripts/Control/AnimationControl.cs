using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationControl : MonoBehaviour
{
    [SerializeField]
    private Animator _animator;

    public GameObject Sword;
    public GameObject Shield;

    private void Update()
    {
        float _axis = Input.GetAxis("Vertical");
        float _HorAxis = Input.GetAxis("Horizontal");

        if (_axis != 0)
        {
            if (_axis > 0)
            {
                _animator.SetInteger("Speed", 1);
            }
            else
            {
                _animator.SetInteger("Speed", -1);
            }
        }
        else
        {
            _animator.SetInteger("Speed", 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _animator.SetTrigger("Is_Jump");
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            _animator.SetBool("Is_Dance", true);
        }
        else
        {
            _animator.SetBool("Is_Dance", false);
        }
        if (_HorAxis != 0)
        {
            if (_HorAxis > 0)
            {
                _animator.SetInteger("Horizontal", 1);
            }
            else
            {
                _animator.SetInteger("Horizontal", -1);
            }
        }
        else
        {
            _animator.SetInteger("Horizontal", 0);
        }

        if (Input.GetButtonDown("Fire1"))
        {
            _animator.SetTrigger("Is_Attack");
        }
        
        if (Input.GetButtonDown("Fire2"))
        {
            _animator.SetTrigger("Is_Slash");
        }
    }
}