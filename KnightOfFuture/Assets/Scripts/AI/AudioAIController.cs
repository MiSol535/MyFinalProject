using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioAIController : MonoBehaviour
{
    public AudioSource _DamageDog;
    public AudioSource _HitDog;
    public int hp = 100;
    private float _timer = 1;
    UnityEngine.AI.NavMeshAgent agent;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Timer", 0, 1);
    }

    // Update is called once per frame
    void Update()
    {
        if(hp <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _HitDog.PlayOneShot(_HitDog.clip);
            _HitDog.UnPause();

            if(Input.GetButtonDown("Fire1") || Input.GetButtonDown("Fire2"))
            {
                _DamageDog.PlayOneShot(_DamageDog.clip);
                _HitDog.Pause();
            }

            if(Input.GetButtonDown("Fire1"))
            {
                hp -= 20;
            }

            if(Input.GetButtonDown("Fire2"))
            {
                hp -= 50;
            }

            
        }
    }
    private void Timer()
    {
        if (hp <= 0)
        {
            _timer -= 1;
        }
    }  

    
}
