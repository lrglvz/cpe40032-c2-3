﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float timer;
    private float timeLimit = 1.0f;

    // Update is called once per frame
    void Update()
    {
        // Creates the time to allow player spawn a dog
        timer += Time.deltaTime;

        // On spacebar press, send dog
        if (Input.GetKeyDown(KeyCode.Space)&& timer > timeLimit)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

            //resets the timer
            timer = 0;
        }
    }
}
