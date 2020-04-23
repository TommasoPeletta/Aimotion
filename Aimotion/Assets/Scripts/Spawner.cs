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
		Vector3 spawnPosition = new Vector3 (5.3f,12.7f,30.6f);
		transform.rotation = Quaternion.Euler (90,0,0);
		Instantiate(target, spawnPosition, transform.rotation);
	targetSpawned += 1;
	yield return new WaitForSeconds(spawnWait);
}
}
}
