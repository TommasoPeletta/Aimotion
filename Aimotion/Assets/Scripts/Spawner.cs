using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
	public GameObject target;

	public float spawnWait = 0.4f;
	public bool stop =false;
	public static int targetSpawned = 0;
	public int info;
	public int maxTarget = 1;
    public Vector3[] positions = new[] {new Vector3 (5.3f,12.7f,30.6f),new Vector3 (-14.47f, 12.72f, 31.69f),new Vector3 (24.3f, 17.1f, 49.4f), new Vector3(-13.36f, 11.78f, 7.7f), new Vector3(15.72f, 10.72f, 24.23f) };
    public int index = 0;
    int randnumber;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (maxTarget <= targetSpawned){
	stop = true;}else{
	stop = false;}
	info = targetSpawned;
	StartCoroutine(waitSpawner());
    }

IEnumerator waitSpawner(){
	while (!stop){
        randnumber = Random.Range(1, 5);
        Vector3 spawnPosition = positions[index];
        index = (index + randnumber) % 5;
		transform.rotation = Quaternion.Euler (90,0,0);
		Instantiate(target, spawnPosition, transform.rotation);
        targetSpawned += 1;
	yield return new WaitForSeconds(spawnWait);
}
}
}
