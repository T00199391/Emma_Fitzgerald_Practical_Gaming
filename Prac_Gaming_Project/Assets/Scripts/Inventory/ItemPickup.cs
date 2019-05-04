using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemPickup : Interactable {

    public Items item;

    public override void Interact()
    {
        base.Interact();

        Pickup();
    }

    void Pickup()
    {
        Debug.Log("Picking up item" + item.name);
        bool wasPickedUp = Inventoory.instance.Add(item); 

        if(wasPickedUp)
            Destroy(gameObject);
    }
}
