using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZScore : MonoBehaviour
{
    public float currentposx;
    public float currentposy;
    public int speed = 6;
    // Start is called before the first frame update
    void Start()
    {
     currentposx = transform.position.x;
     currentposy = transform.position.y;

    }
    void Update()
    {
        speed = 6 + LevelBehaviour.level * 2;
        if (Spawner.index <= 2)
        {
            transform.position = new Vector3(currentposx + Mathf.PingPong(Time.time * speed, 6), transform.position.y, transform.position.z);
        }
        else
        {
            transform.position = new Vector3(transform.position.x,currentposy + Mathf.PingPong(Time.time * speed, 3), transform.position.z);
        }
    }
    // Update is called once per frame
    void DeductPoints(int DamageAmount)
    {
        GlobalScore.CurrentScore += 1;
    }
}
