using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]

public class Items : ScriptableObject {

    new public string name = "New Item";
    public Sprite icon = null;
    public bool isDefaultItem = false;
    GameObject player;
    Movement playerControl;

    public virtual void Use(Items item)
    {
        FindPlayer();
        Inventoory.instance.Remove(item);

        if(item.name == "Health Potion")
        {
            playerControl.IncreaseHealth();
        }
    }

    private void FindPlayer()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        playerControl = player.GetComponent<Movement>();
    }
}
