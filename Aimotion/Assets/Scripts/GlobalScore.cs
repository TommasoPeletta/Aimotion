using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GlobalScore : MonoBehaviour
{
	public static int CurrentScore;
	public GameObject ScoreText;
	public int InternalScore;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
	InternalScore = CurrentScore;
	ScoreText.GetComponent<Text>().text = "" + InternalScore;
        
    }
}
