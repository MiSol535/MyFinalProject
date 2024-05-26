using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Quest : MonoBehaviour
{
    public GameObject _quest;
    public GameObject Dialog_Panel;
    public GameObject Player;
    public GameObject Camera;
    public GameObject quest2;
    public GameObject quest1;

    public GameObject Paladin;
    public GameObject Helmet;
    public GameObject Sword;
    public GameObject Shield;

    public int _number = 1;

    public GameObject Dialog_1;
    public GameObject Dialog_2;
    public GameObject Dialog_3;
    public GameObject Dialog_4;
    public GameObject Dialog_5;
    public GameObject Dialog_6;
    public GameObject Dialog_7;
    public GameObject Dialog_8;
    public GameObject Dialog_9;

    public void To_Next()
    {
        _number ++;
    }

    private void OnTriggerStay(Collider col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
                if (_number == 1)
                {
                    Dialog_1.SetActive(true);
                }

                if (_number == 2)
                {
                    Dialog_1.SetActive(false);

                    Dialog_2.SetActive(true);
                }

                if (_number == 3)
                {
                    Dialog_2.SetActive(false);

                    Dialog_3.SetActive(true);
                }

                if (_number == 4)
                {
                    Dialog_3.SetActive(false);

                    Dialog_4.SetActive(true);
                }

                if (_number == 5)
                {
                    Dialog_4.SetActive(false);

                    Dialog_5.SetActive(true);
                }

                if (_number == 6)
                {
                    Dialog_5.SetActive(false);

                    Dialog_6.SetActive(true);
                }

                if (_number == 7)
                {
                    Dialog_6.SetActive(false);

                    Dialog_7.SetActive(true);
                }

                if (_number == 8)
                {
                    Dialog_7.SetActive(false);

                    Dialog_8.SetActive(true);
                }

                if (_number == 9)
                {
                    Dialog_8.SetActive(false);

                    Dialog_9.SetActive(true);
                }

                if (_number == 10)
                {
                    SceneManager.LoadScene(2);
                }

            if (Input.GetKeyDown("e") && _number < 11)
            {
                quest2.SetActive(false);
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
                Dialog_Panel.SetActive(true);

                Camera.SetActive(true);
                Player.SetActive(false);

                Sword.SetActive(false);
                Shield.SetActive(false);
                Paladin.SetActive(false);
                Helmet.SetActive(false);                              
            }
        }
        
    }
}
