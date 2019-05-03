using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour {

    private string name;
    private string type;


    public Item()
    {
        
    }

    public Item(string name, string type)
    {
        setType(type);

        setName(name);
    }

    public string getName()
    {
        return name;
    }

    public string getType()
    {
        return type;
    }

    public void setType(string Type)
    {
        this.type = Type;
    }

    public void setName(string Name)
    {
        this.name = Name;
    }

    public string ToString()
    {
        return "Name: " + getName() + "   Type: " + getType();
    }
}
