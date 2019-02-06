using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour {

    private int health = 100;
    private int maxHealth = 100;
    public Text healthText;
    RectTransform position;

    // Use this for initialization
    void Start () {
        healthText = gameObject.GetComponentInChildren<Text>();
        position = healthText.GetComponentInChildren<RectTransform>();
        setPosition(-481, 274, 0);
        healthText.text = health.ToString();
    }
	
	// Update is called once per frame
	void Update () {
	}

    public void setPosition(int x, int y, int z)
    {
        Vector3 distance = new Vector3(x, y, z);
        position.Translate(distance);
    }
}
