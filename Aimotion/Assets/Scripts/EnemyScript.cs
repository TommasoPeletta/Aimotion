using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

 public int EnemyHealth = 5;

 void DeductPoints (int DamageAmount) {
  EnemyHealth -= DamageAmount;
 }

 void Update () {
  if (EnemyHealth <= 0) {
   Destroy(gameObject);
	Spawner.targetSpawned -= 1;
  }
 }
}
