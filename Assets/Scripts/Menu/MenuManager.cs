using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class MenuManager : MonoBehaviour
{
    public void Level1()
    {
        SceneManager.LoadScene(1);
    }
    public void Level2()
    {
        SceneManager.LoadScene(2);
    }

    public void Level3()
    {
        SceneManager.LoadScene(3);
    }
    public void btnRecord()
    {
        string filePath = Application.dataPath + "gameTimes.txt";
        if (File.Exists(filePath))
        {
            string fileContent = File.ReadAllText(filePath);
            Debug.Log("Obsah souboru gameTimes:\n" + fileContent);
        }
        else
        {
            Debug.LogError("Soubor gameTimes neexistuje.");
        }
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
