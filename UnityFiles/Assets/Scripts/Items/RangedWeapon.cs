using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedWeapon : Item
{

    public GameObject Projectile;

        public override void Use()
    {
        base.Use();
        //Debug.Log("Use RangedWeapon");
        if (inventory.transform.localScale.x == 1)
          Instantiate(Projectile, transform.position, transform.rotation * Quaternion.Euler(0, 0, -90));
        if (inventory.transform.localScale.x == -1)
          Instantiate(Projectile, transform.position, transform.rotation * Quaternion.Euler(0, 0, 90));
    }
    
    public override void Remove()
    {
        base.Remove();
        Debug.Log("Remove RangedWeapon");

    }
}
