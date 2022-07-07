using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChestItem : MonoBehaviour
{

    public Item item;

    PlayerController player;
    Inventory inventory;
    SpriteRenderer rend;
    Text itemText;

    void Awake()
    {
        player = FindObjectOfType<PlayerController>();
        inventory = FindObjectOfType<Inventory>();
        rend = GetComponent<SpriteRenderer>();
        itemText = GetComponentInChildren<Text>();
        rend.sprite = item.itemSprite;
    }


    public void PickUpItem()
    {
        inventory.AddItem(item);
        Destroy(gameObject);   
    }

    private void OnMouseDown()
    {
        PickUpItem();
    }
    // Update is called once per frame
    void Update()
    {
        itemText.text = item.itemName;
        
    }
}
