using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageResizing : MonoBehaviour {
    public GameObject image;
    public GameObject canvas;
    RectTransform canvasRect;
    RectTransform imageRect;
    float width;
    float height;

    // Use this for initialization
    void Start () {
        canvasRect = canvas.GetComponent<RectTransform>();
        imageRect = image.GetComponent<RectTransform>();
    }
	
	// Update is called once per frame
	void Update () {
        width = canvasRect.rect.width;
        height = canvasRect.rect.height;
        imageRect.sizeDelta = new Vector2(width, height);
	}
}
