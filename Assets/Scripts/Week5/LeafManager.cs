using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeafManager : MonoBehaviour
{
    public GameObject leaf;
    Camera camera;
    float halfHeight = 0;
    float halfWidth = 0;
    Vector3 random_position = Vector3.zero; // USed to assign random position

    // Start is called before the first frame update
    void Start()
    {
        camera= Camera.main;
        halfHeight = camera.orthographicSize;
        halfWidth = camera.aspect * halfHeight;
    }

    // Update is called once per frame
    void Update()
    {
        CheckInputs();
    }
    void CheckInputs() { 
        if(Input.GetKeyDown(KeyCode.L)) {
            //AddNewLeaves(Random.Range(3,10));
            AddRandomLeaves(Random.Range(3, 10));
        }
    }
    /*
     * ------- Challenge 3 ------- Hard -------
     * 1. Make a new function similar to AddNewLeaves and call the new function from line 21 instead of AddNewLeaves
     * 2. In the new function you just made instantiate new objects at random locations within the camera space. 
     * 
     * Please note: -halfWidth and halfWidth gives you minimum and maximum values for x axis and -halfHeight and halfHeight gives you minimum and maximum values for y.
     * Please note the location of these new leaves should be between the boundaries of the camera view. 
     */
    void AddNewLeaves(int howMany)
    {
        for (int loopIndex = 0; loopIndex < howMany; loopIndex += 1)
        {
            Instantiate(leaf, transform.position, transform.rotation);
        }
    }

    void AddRandomLeaves(int howMany)
    {
        float RandomXpos = Random.Range(-halfWidth, halfWidth);
        
        float RandomYPos = Random.Range(-halfHeight, halfHeight);
        // above is used to get random values within camera bounds
        
        random_position = new Vector3(RandomXpos, RandomYPos, 0f); // assigns values to position vector for use in loop
        
        for (int loopIndex = 0; loopIndex < howMany; loopIndex += 1)
        {
            Instantiate(leaf, random_position, transform.rotation);
        }
    }
}
