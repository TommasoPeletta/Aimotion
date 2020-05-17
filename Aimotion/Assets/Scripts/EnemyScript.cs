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
  if (EnemyHealth <= 0)
        {
            Spawner.playsound = true;
        }
  if ((EnemyHealth <= 0) || (Spawner.checktime))  {
            
   Destroy(gameObject);
	Spawner.targetSpawned -= 1;
    Spawner.timespawn = 5 - LevelBehaviour.level * 0.5f;
            Spawner.checktime = false;
        }
 }
}
