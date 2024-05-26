using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class UI : MonoBehaviour
{
    public GameObject Settings_menu;
    private bool _settings = false;
    public TMP_Dropdown dropDown;

    Resolution[] _resolutions;
    int _width = 1920;
    int _height = 1080;

    // Start is called before the first frame update
    void Start()
    {
        _resolutions = Screen.resolutions;

        List<string> str_resolution = new List<string>();

        for (int i = 0; i < _resolutions.Length; i++)
        {
            str_resolution.Add(_resolutions[i].ToString());
        }

        dropDown.ClearOptions();

        dropDown.AddOptions(str_resolution);

        Screen.SetResolution(_width, _height, true);
    }

    public void SetResolution()
    {
        _width = _resolutions[dropDown.value].width;
        _height = _resolutions[dropDown.value].height;

        Screen.SetResolution(_width, _height, true);
    }

    public void To_Continue()
    {
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        Application.Quit();
    }

    public void To_Settings()
    {
        _settings = !_settings;
        Settings_menu.SetActive(_settings);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
