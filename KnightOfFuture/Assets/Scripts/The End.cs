using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheEnd : MonoBehaviour
{
    public GameObject Dialog_Panel;
    public GameObject Player;
    public GameObject Camera;

    public GameObject Paladin;
    public GameObject Helmet;
    public GameObject Sword;
    public GameObject Shield;

    public GameObject order1;
    public GameObject IsAll;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void To_Next()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        Dialog_Panel.SetActive(false);

        Camera.SetActive(false);
        Player.SetActive(true);

        Sword.SetActive(true);
        Shield.SetActive(true);
        Paladin.SetActive(true);
        Helmet.SetActive(true);

        IsAll.SetActive(true);
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.CompareTag("Player") && Input.GetKeyDown("e"))
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            Dialog_Panel.SetActive(true);

            Camera.SetActive(true);
            Player.SetActive(false);

            Sword.SetActive(false);
            Shield.SetActive(false);
            Paladin.SetActive(false);
            Helmet.SetActive(false);

            order1.SetActive(false);
            IsAll.SetActive(false);
        }
    }
}
