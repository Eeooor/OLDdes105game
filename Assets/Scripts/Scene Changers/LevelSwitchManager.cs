using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitchManager : MonoBehaviour
{
    // Used to change Scenes (requires other scripts to call functions)

    public void toGameOver()
    {
        Debug.Log("Scene switched to gameover");
        SceneManager.LoadScene("GameOver");
    }

    public void toMainGame()
    {
        Debug.Log("Scene switched to MainGame");
        SceneManager.LoadScene("MainGame");
    }

    public void toMainMenu()
    {
        Debug.Log("Scene switched to MainMenu");
        //SceneManager.LoadScene("MainMenu");
    }

    public void toExitApp()
    {
        Debug.Log("Quit App");
        Application.Quit();
    }
}
