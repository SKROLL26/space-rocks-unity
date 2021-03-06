﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.LowLevel;
using UnityEngine.UI;
using Random = UnityEngine.Random;

public class LoseScreenController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject[] asteroids = new GameObject[3];
    void Start()
    {
        


        for (int i = 0; i < 25; i++)
        {
            
            float x = Random.Range(GlobalControl.Instance.leftBound, GlobalControl.Instance.rightBound);
            float y = Random.Range(GlobalControl.Instance.lowerBound, GlobalControl.Instance.upperBound);
            float z = 200.0f;

            Vector3 pos = new Vector3(x, y, z);
            GameObject asteroid = asteroids[Random.Range(0, asteroids.Length)];
            Instantiate(asteroid, pos, new Quaternion());
            
        }
    }
    

    private void OnGUI()
    {
        GameObject.Find("Score Text").GetComponent<Text>().text =
            "YOUR SCORE: " + GlobalControl.Instance.score + " POINTS";
    }

    public void ToMainMenu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Exit()
    {
        Application.Quit();
    }
}
