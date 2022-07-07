using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Consumable : Item
{

    public int uses;

    public override void Use()
    {
        base.Use();
        //Debug.Log("Use Consumable");
        if (uses > 0)
        {
            uses--;
            FindObjectOfType<PlayerController>().Heal(amount);

        }
        else
            Remove();
    }
    
    public override void Remove()
    {
        base.Remove();
        Debug.Log("Remove Consumable");

    }
}
