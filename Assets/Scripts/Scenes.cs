using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scenes : MonoBehaviour
{
    public void StartPlay()
    {
        SceneManager.LoadScene("Game_Scene");
    }

    public void StopPlaying()
    {
        SceneManager.LoadScene("Exit_Scene");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Main_Menu");
    }

    public void ExitGame()
    {
        // exit the game for real play
        //Application.Quit();
        //does not work in Unity since it would  lose all settings. so:
        UnityEditor.EditorApplication.isPlaying = false;
    }
}