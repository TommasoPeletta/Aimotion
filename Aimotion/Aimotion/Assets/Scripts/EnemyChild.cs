using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChild : MonoBehaviour
{
     
public EnemyScript parHealth;
void Start() {
	parHealth = transform.parent.GetComponent<EnemyScript>();
}
 void DeductPoints (int DamageAmount) {
  parHealth.EnemyHealth -= DamageAmount;
 }

}
