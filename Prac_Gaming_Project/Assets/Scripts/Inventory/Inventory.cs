using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour {

    List<Item> Items;

    // Use this for initialization
    void Start()
    {
        Items = new List<Item>();
    }

    public void AddTo(Item NewItem)
    {
        Items.Add(NewItem);
    }

    internal Item getItem(int v)
    {
        //Debug.Log(Items[v].ToString());
        return Items[v];
    }

    public void RemoveItem(Item item)
    {
        Items.Remove(item);
    }

    public bool IsNull()
    {
        bool isNull = true;

        if(Items.Count != 0)
        {
            isNull = false;
        }

        return isNull;
    }
}
