using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityStandardAssets.Characters.FirstPerson;



public class GameTimer : MonoBehaviour
{
    public float timeLeft = 5.0f;
    public int timeVisible = 30;
    public AudioSource TimerSound;
    public GameObject GameOverPanel;
    public GameObject GameTime;
    public GameObject Score;
    public GameObject Accuracy;
    public GameObject MissedTargets;
    public GameObject PauseMenu;
    public GameObject Gun;
    public GameObject Player;
    public float acc;
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
        if (timeLeft <= 0)
        {
            GameOver();
        }
        if (PauseGame.soundpausetimer)
        {
            TimerSound.Pause();
            PauseGame.soundpausetimer = false;
        }

        if (PauseGame.soundresumetimer)
        {
            TimerSound.UnPause();
            PauseGame.soundresumetimer = false;
        }
    }

    public void GameOver()
    {
        Time.timeScale = 0;
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        GameOverPanel.SetActive(true);
        TimerSound.loop = false;
        TimerSound.Stop();
        PauseMenu.GetComponent<PauseGame>().enabled = false;
        Gun.GetComponent<GunFire>().enabled = false;
        Gun.GetComponent<HandgunRealoding>().enabled = false;
        Player.GetComponent<FirstPersonController>().enabled = false;
        Score.GetComponent<Text>().text = "Score : " + GlobalScore.CurrentScore;
        acc = (float)((float)GlobalScore.CurrentScore / (float)GunFire.totalshots) * 100;
        Accuracy.GetComponent<Text>().text = "Accuracy : " + acc + "%";
        MissedTargets.GetComponent<Text>().text = "Target Missed : " + Spawner.missedTarget;
    }

    public void Exit()
    {
        GameOverPanel.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(1);

    }
}
