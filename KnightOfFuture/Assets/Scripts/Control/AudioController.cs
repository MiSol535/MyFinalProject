using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    public AudioSource _Walking;
    public AudioSource _Attack;
    public AudioSource _Jump;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float _axis = Input.GetAxis("Vertical");
        float _HorAxis = Input.GetAxis("Horizontal");

        if (_axis != 0 || _HorAxis != 0)
        {
            _Walking.UnPause();
        }
        else
        {
            _Walking.Pause();
        }

        if (Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2"))
        {
            _Attack.PlayOneShot(_Attack.clip);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            _Jump.PlayOneShot(_Jump.clip);
        }
    }
}
