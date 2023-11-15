using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDetector : MonoBehaviour
{
    // Checks if player is dead, if dead, tells level switcher to change to GameOver

    LevelSwitchManager levelSwitcher;

    PlayerHealthManagment HealthCheck;

    // Start is called before the first frame update
    void Start()
    {
        levelSwitcher = GetComponent<LevelSwitchManager>();
        HealthCheck = GameObject.Find("Player").GetComponent<PlayerHealthManagment>();
    }

    private void FixedUpdate()
    {
        //Checks if Player is alive
        if (HealthCheck.checkIfAlive() == false)
        {
            levelSwitcher.toGameOver();
        }
    }
}
