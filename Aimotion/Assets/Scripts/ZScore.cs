using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZScore : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void DeductPoints(int DamageAmount)
    {
        GlobalScore.CurrentScore += 1;
    }
}
