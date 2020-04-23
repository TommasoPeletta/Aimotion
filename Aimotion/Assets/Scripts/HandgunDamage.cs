using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandgunDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

public int DamageAmount = 5;
public float TargetDistance;
public float AllowedRange = 100.0f;

void Update () {
if ((GlobalAmmo.LoadedAmmo >= 1) & GunFire.fireing ){
 if(Input.GetButtonDown("Fire1")) {
  RaycastHit Shot;
  if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), out Shot)) {
   TargetDistance = Shot.distance;
   if (TargetDistance < AllowedRange) {
    Shot.transform.SendMessage("DeductPoints", DamageAmount, SendMessageOptions.DontRequireReceiver);
    }
   }
  }
}
 }
}
