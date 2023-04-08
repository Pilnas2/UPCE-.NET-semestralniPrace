using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void btnStart()
    {
        SceneManager.LoadScene(0);
    }
    public void btnExit()
    {
        Debug.Log("EXIT");
        Application.Quit();
    }

    public void Quality(int _int)
    {
        QualitySettings.SetQualityLevel(_int);
    }
    public void FullScreen(bool _bool)
    {
        Screen.fullScreen = _bool;
    }
}
