using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Items
{
    POTIONS ,
    FOOD ,
    WEAPONS ,
    MATERIALS ,
    KEYITEMS
}

public class Inventory : MonoBehaviour
{
    Dictionary<Items, int> myInventory = new Dictionary<Items, int>();
    List<Items> itemQueue = new List<Items>();
    public int anAmount { get; set; }
    public Items heldItem { get;  set; }

    void Start()
    {
        myInventory.Add(Items.POTIONS, 0);
        myInventory.Add(Items.FOOD, 0);
        myInventory.Add(Items.WEAPONS, 0);
        myInventory.Add(Items.MATERIALS, 0);
        myInventory.Add(Items.KEYITEMS, 0);
    }

    void Update()
    {
        if (itemQueue.Count != 0)
            DepositItems();
        if (Input.GetKeyDown(KeyCode.P))
            //had bedacht om de setter en getters te gebruiken in een vorm van gui maar wist noet hoe ik dat zou weergeven in code
            removeItem(anAmount, heldItem) ;
        if (Input.GetKeyDown(KeyCode.L))
            showItems();

    }

     void DepositItems()
    {
        Items currentItem;
        currentItem = itemQueue[0];
        myInventory[currentItem] += 1;
        itemQueue.Remove(itemQueue[0]);
    }
    void removeItem(int amount, Items type)
    {
        myInventory[type] -= amount;
    }

    void showItems()
    {
        print("the amount of items in your inventory is:");
        foreach (KeyValuePair<Items, int> item in myInventory)
        {
            Console.WriteLine("item: {0}, Amount: {1}",
                item.Key, item.Value);
        }
    }

   public void pickupItem(Items myItem)
    {
        itemQueue.Add(myItem);
    }
   
}
