using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSwitchManager : MonoBehaviour
{
    // gameobject called Player
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

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
    }

    public void toExitApp()
    {
        Debug.Log("Quit App");
        Application.Quit();
    }
}
