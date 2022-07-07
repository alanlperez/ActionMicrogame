using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chest : MonoBehaviour
{
    public GameObject chestParent;
    PlayerController player;
    GameController cont;
    bool populated = false;

    
    void Awake()
    {
        player = FindObjectOfType<PlayerController>();
        cont = FindObjectOfType<GameController>();
        populated = false;

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PopulateChest()
    {
        ChestItem chestItem;
        for (int i = 0; i < 3; i++)
        {
            int r = Random.Range(0, 100);
            Debug.Log("random number is " + r);
            if (r < 3 && cont.legendaryItems.Count != 0)//legendary 
            {
                chestItem = Instantiate(cont.GetRandomItem(cont.legendaryItems));
                chestItem.transform.SetParent(chestParent.transform);
                chestItem.transform.localPosition = new Vector3((i * 1.5f) - 1.5f, 0, 0);   
            }
            else if (r < 10 && cont.rareItems.Count != 0)//rare
            {
                chestItem = Instantiate(cont.GetRandomItem(cont.rareItems));
                chestItem.transform.SetParent(chestParent.transform);
                chestItem.transform.localPosition = new Vector3((i * 1.5f) - 1.5f, 0, 0); 
            }
            else if (r < 50 && cont.uncommonItems.Count != 0)//uncommon
            {
                chestItem = Instantiate(cont.GetRandomItem(cont.uncommonItems));
                chestItem.transform.SetParent(chestParent.transform);
                chestItem.transform.localPosition = new Vector3((i * 1.5f) - 1.5f, 0, 0); 
            }
            else if (cont.legendaryItems.Count != 0) //common
            {
                chestItem = Instantiate(cont.GetRandomItem(cont.commonItems));
                chestItem.transform.SetParent(chestParent.transform);
                chestItem.transform.localPosition = new Vector3((i * 1.5f) - 1.5f, 0, 0); 
            }
            else 
            {
                Debug.Log("No item in Chest");
            }
        }

    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!populated && collision.gameObject.CompareTag("Player"))
        {
            PopulateChest();
            populated = true;
        }

    }
 
}
