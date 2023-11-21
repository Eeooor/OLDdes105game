using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    // This script spawns enemies based on a timer, and increases the amount to spawn each time
    public GameObject Enemie_Wasp; //Set which enemies to spawn

    Vector3 random_position = Vector3.zero; // Used to assign random position

    [SerializeField] Camera camBounds; // Manually set camera from editor

    // Define low end of spawn area range
    float spawnHeightmin;
    float spawnWidthmin;
    // Define High end of spawn area range
    float spawnHeightmax;
    float spawnWidthmax;

    // Timer stuff (see end for credits)

    public float timeRemaining = 5;
    public bool timerIsRunning = false;

    // Start is called before the first frame update
    void Start()
    {
        // Starts the timer automatically
        timerIsRunning = true;
    }

    // Update is called once per frame
    void Update()
    {
        // Changes as camera moves
        //set min bounds
        spawnHeightmin = camBounds.orthographicSize + 1;
        spawnWidthmin = camBounds.orthographicSize * camBounds.aspect + 1;
        //set max bounds
        spawnHeightmax = camBounds.orthographicSize + 3;
        spawnWidthmax = camBounds.orthographicSize * camBounds.aspect + 3;


        //Timer stuff from https://gamedevbeginner.com/how-to-make-countdown-timer-in-unity-minutes-seconds/
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= Time.deltaTime;
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                SpawnEnemies();
                timerIsRunning = false;
            }
        }
    }

    void SpawnEnemies()
    {
        float RandomXpos = Random.Range(spawnHeightmin, spawnHeightmax);

        float RandomYPos = Random.Range(spawnHeightmin, spawnWidthmax);
        // above is used to get random values within camera bounds

        random_position = new Vector3(RandomXpos, RandomYPos, 0f); // assigns values to position vector for use in loop
        Instantiate(Enemie_Wasp, random_position, transform.rotation);
    }
}
