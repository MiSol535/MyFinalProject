using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Medical : MonoBehaviour
{
    public GameObject Q1;
    public GameObject Q2;
    private int aid = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Medical") //&& Input.GetKeyDown("e") 
        )
        {
            Q1.SetActive(false);
            Q2.SetActive(true);
            Destroy(col.gameObject);
            aid += 1;
        }

        if(col.gameObject.CompareTag("End") && aid >= 1)
        {
            //Destroy(collision.gameObject);
            SceneManager.LoadScene(3);
        }
    }

}
