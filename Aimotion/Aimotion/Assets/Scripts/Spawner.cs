using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject target;
    GameObject clone;

    public float spawnWait = 0.4f;
	public bool stop =false;
	public int info;
    int randnumber;
    public int maxTarget = 1;
    public int newindex = 0;
    public Vector3[] positions = new[] {new Vector3 (-18.78f,12.58f,40.34f), new Vector3(-24.51f, 11.66f, 9.95f), new Vector3(27.16f, 11.73f, 26.29f), new Vector3(17.05f, 14.15f, 47.97f), new Vector3(-26.06f, 13.09f, 38.97f) };
    public Vector3 currentScale = new Vector3(1, 0, 1);
    public static Vector3 spawnPosition = new Vector3(-18.78f, 12.58f, 40.34f);
    public static int index = 0;
    public static float timespawn=5.0f;
    public static float initialtime = 5.0f;
    public static int targetSpawned = 0;
    public static bool checktime = false;
    public static int missedTarget = 0;
    public static bool playsound = false;
    public AudioSource AudioSpawn;
    public AudioSource AudioPoints;


    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (LevelBehaviour.level == 0) {
            currentScale = new Vector3(1 , 0, 1);
        }
        else
        {
            currentScale = new Vector3(1f - LevelBehaviour.level*0.3f, 0, 1f - LevelBehaviour.level * 0.3f);
        }
        if (playsound)
        {
            AudioPoints.time = 0.300f;
            AudioPoints.Play();
            playsound = false;
        }
        if (targetSpawned == 1)
        {
            timespawn -= Time.deltaTime;
            if (timespawn < 0)
            {
                checktime = true;
                missedTarget += 1;
                            }
        }
        if (maxTarget <= targetSpawned)
        {
            stop = true;
        }
        else
        {
            stop = false;
        }
        info = targetSpawned;
        StartCoroutine(waitSpawner());
       
    }

IEnumerator waitSpawner(){

	while (!stop){
        randnumber = Random.Range(1, 5);
        index = newindex;
        spawnPosition = positions[index];
        newindex = (index + randnumber) % 5;
		transform.rotation = Quaternion.Euler (90,0,0);
		clone = (GameObject) Instantiate(target, spawnPosition, transform.rotation);
        clone.transform.localScale += currentScale;
        targetSpawned += 1;
        AudioSpawn.time = 0.600f;
        AudioSpawn.Play();
        yield return new WaitForSeconds(spawnWait);
}
}
}
