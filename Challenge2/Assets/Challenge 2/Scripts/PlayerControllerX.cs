using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float startDelay = 1.0f;
    private float spawnInterval = 5.0f;
    // Update is called once per frame
    void Update()
    {

        //// On spacebar press, send dog
        //InvokeRepeating("", startDelay, spawnInterval);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
        }
    }
}
