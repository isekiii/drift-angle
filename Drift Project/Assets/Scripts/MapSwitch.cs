using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MapSwitch : MonoBehaviour
{
    //public MapIndex mapIndex;

    public void PlayMap1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void PlayMap2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void GoToSettingsMenu()
    {
        //  SceneManager.LoadScene("SettingsMenu");
    }

    public void GoToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    //public void Quitgame()
    //{
    //    Application.Quit();
    //    Debug.Log("App closed -_-");
    //}
}
