using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class PlayerCondition : MonoBehaviour
{

    //UI Stuff
    private int Score;
    private float TImer = 21;
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
        TImer -= Time.deltaTime;
        Timertxt.text = "Timer: " + TImer.ToString("F0");

        if (TImer <= 0)
        {
            SceneManager.LoadScene(2);
        }
        else if (transform.position.y < -8)
        {
            SceneManager.LoadScene(2);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
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
