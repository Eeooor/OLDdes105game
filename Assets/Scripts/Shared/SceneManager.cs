using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
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
    }

    public void toMainMenu()
    {
        Debug.Log("Scene switched to MainMenu");
    }

    public void toExitApp()
    {
        Debug.Log("Exited App");
    }
}
