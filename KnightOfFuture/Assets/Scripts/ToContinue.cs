using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ToContinue : MonoBehaviour
{
    public GameObject _quest;
    public GameObject quest1;
    public GameObject quest2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.CompareTag("Doctor") && Input.GetKeyDown("e"))
        {
            quest1.SetActive(false);
            quest2.SetActive(true);
            _quest.SetActive(true);
        }

        
    }

    
}
