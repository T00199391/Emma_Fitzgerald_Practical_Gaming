using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeText : MonoBehaviour {

    public Text loading;
    public Text start;
    public Text control;

    public void changeText()
    {
        loading.text = "Loading...";
        start.text = "";
        control.text = "";
    }
}
