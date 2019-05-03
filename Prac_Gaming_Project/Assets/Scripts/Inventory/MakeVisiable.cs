using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeVisiable : MonoBehaviour {

    private bool isVisiable = false;
    public GameObject inventory;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.I))
        {
            isVisiable = !isVisiable;
        }
        
        inventory.SetActive(isVisiable);
	}
}
