using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {

    public float radius = 2f;
    bool isFocus = false;
    Transform player;

    public Transform interactionTransform;

    bool hasInteracted = false;

    private void Start()
    {
        interactionTransform = GetComponent<Transform>();
    }

    public void OnFocused(Transform playerTransform)
    {
        isFocus = true;
        player = playerTransform;
        hasInteracted = false;
    }

    public void OnDefocused()
    {
        hasInteracted = true;
        isFocus = false;
        player = null;
    }

    private void Update()
    {
        if(isFocus && !hasInteracted)
        {
            float distance = Vector3.Distance(player.position, interactionTransform.position);
            if(distance <= radius+4)
            {
                Interact();
                hasInteracted = true;
            }
        }
    }


    public virtual void Interact()
    {
        Debug.Log("Interacting with " + transform.name);
    }
}
