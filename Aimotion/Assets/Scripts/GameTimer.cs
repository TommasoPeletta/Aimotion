using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameTimer : MonoBehaviour
{
    public float timeLeft = 30.0f;
    public int timeVisible = 30;
    public AudioSource TimerSound;
    public GameObject GameTime;
    // Start is called before the first frame update
    void Start()
    {
        TimerSound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        TimerSound.loop = true;
        timeLeft -= Time.deltaTime;
        timeVisible = (int)Mathf.Ceil(timeLeft);
        GameTime.GetComponent<Text>().text = ""+timeVisible;
        if (timeLeft < 0)
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        TimerSound.loop = false;
        TimerSound.Stop();

    }
}
