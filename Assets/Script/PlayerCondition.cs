﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerCondition : MonoBehaviour
{

    //UI Stuff
    private int Score;
    public float timeleft;
    private float timeremaining;
    public Text Scoretxt;
    public Text Timertxt;
    private int goal;

    // Start is called before the first frame update
    void Start()
    {
        //Check how many Coin on scene
        GameObject[] coins;
        coins = GameObject.FindGameObjectsWithTag("Coin");
        if (coins.Length >= 0)
        {
            goal = coins.Length;
        }
        Scoretxt.text = "Score: " + Score;
    }

    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;
        timeremaining = Mathf.FloorToInt(timeleft % 60);
        Timertxt.text = "Timer: " + timeremaining.ToString("F0");

        if (timeleft <= 0)
        {
            SceneManager.LoadScene(2);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Fire")
        {
            SceneManager.LoadScene(2);
        }
        if (other.gameObject.tag == "Coin")
        {
            Score += 10;
            Scoretxt.text = "Score: " + Score;
            goal--;

            if (goal <= 0)
            {
                SceneManager.LoadScene(1);
            }
        }
    }
}
