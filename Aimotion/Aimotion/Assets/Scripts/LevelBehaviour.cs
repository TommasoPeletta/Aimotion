using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelBehaviour : MonoBehaviour
{
    public static int level;
    public float time5 = 10.0f;
    public float time15 = 15.0f;
    public float bpmavarage = 0.0f;
    public int count = 0;
    public int levelinfo = 0;
    // Start is called before the first frame update
    void Start()
    {
        level = 0;
    }

    // Update is called once per frame
    void Update()
    {
        levelinfo = level;
        time5 -= Time.deltaTime;
        time15 -= Time.deltaTime;
        if (time5 <= 0)
        {
            count += 1;
            bpmavarage += HelloRequester.bpm;
        }
        if (time15 <= 0)
        {
            bpmavarage = bpmavarage / count;
            count = 0;
            if (bpmavarage < MainMenuOptions.bpm0 * 1.2)
            {
                if (level < 4)
                {
                    level += 1;
                }
            } else if (bpmavarage >= MainMenuOptions.bpm0 * 1.4)
            {
                if (level > 0)
                {
                    level -= 1;
                }
            }
            MainMenuOptions.bpm0 = bpmavarage;
            bpmavarage = 0.0f;
            time5 = 10.0f;
            time15 = 15.0f;
        }

    }
}
