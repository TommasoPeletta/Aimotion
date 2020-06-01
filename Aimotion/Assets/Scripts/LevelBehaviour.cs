using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class LevelBehaviour : MonoBehaviour
{
    public Text bpmText;
    public Text levelText;
    public float bpminfo;
    public static int level;
    public float time5 = 5.0f;
    public float time15 = 10.0f;
    public float bpmavarage = 0.0f;
    public int count = 0;
    public int levelinfo = 0;
    public static int lvlavarage = 0;
    public static int countlvl = 0;
    // Start is called before the first frame update
    void Start()
    {
        countlvl = 0;
        level = 0;
        ShowBpm();
    }

    // Update is called once per frame
    void Update()
    {
        if (!PauseGame.Paused2)
        {
            ShowBpm();
            levelinfo = level;
            time5 -= Time.deltaTime;
            time15 -= Time.deltaTime;
            if (time5 <= 0 )
            {
                count += 1;
                bpmavarage += HelloRequester.bpm;
            }
            if (time15 <= 0)
            {
                bpmavarage = bpmavarage / count;
                count = 0;
                if (bpmavarage < MainMenuOptions.bpm0*1.02)
                {
                    if (level < 4)
                    {
                        level += 1;
                    }
                }
                else if (bpmavarage >= MainMenuOptions.bpm0*1.02)
                {
                    if (level > 0)
                    {
                        level -= 1;
                    }
                }
                MainMenuOptions.bpm0 = bpmavarage;
                bpmavarage = 0.0f;
                time5 = 5.0f;
                time15 = 10.0f;
                lvlavarage += level;
                countlvl += 1;
            }
        }
    }
    
    void ShowBpm()
    {
        bpminfo = HelloRequester.bpm;
        bpmText.text = "Bpm : " + HelloRequester.bpm;
        levelText.text = "Level : " + level;
    }
}
