using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventoory : MonoBehaviour {
    public static Inventoory instance;

    private void Awake()
    {
        if(instance != null)
        {
            Debug.LogWarning("More than one instance of Inventoory found");
            return; 
        }
        instance = this;
    }


    public List<Items> items = new List<Items>();
    public int space = 5;

    public delegate void OnItemChanged();
    public OnItemChanged OnItemChangedCallBack;

    public bool Add(Items item)
    {
        if(!item.isDefaultItem)
        {
            if(items.Count >= space)
            {
                Debug.Log("Not Enough Space");
                return false;
            }
            items.Add(item);

            if(OnItemChangedCallBack != null)
                OnItemChangedCallBack.Invoke();
        }

        return true;
    }

    public void Remove(Items item)
    {
        items.Remove(item);

        if (OnItemChangedCallBack != null)
            OnItemChangedCallBack.Invoke();
    }

}
