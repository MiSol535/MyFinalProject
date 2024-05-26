using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Damage : MonoBehaviour
{
    [SerializeField]
    private Slider _lives;
    private float hp = 100; 
    private float _timer = 0.5f;

    private float time;
    
    bool immortal = false;
    
    private void Start()
    {
        InvokeRepeating("Timer", 0, 1);
        _lives.value = hp;
    }

    private void Update()
    {
        if (_timer <= 0)
        {
            hp++;
            _lives.value = hp;
            _timer = 0.5f; 
        }

        if (hp <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Enemy") && !immortal)
        {
            immortal = true;
            Invoke("NotImmortal", 0.5f);
            hp -= 10;
            _lives.value = hp;
        }
    }

    private void Timer()
    {
        if (hp < 100)
        {
            _timer -= 0.5f;
        }
    }    

    void NotImmortal()
    {
        immortal = false;
    }
}
