using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerFollow : MonoBehaviour {

    private Transform target;

    [SerializeField]
    private Vector3 offsetPosition;

	// Use this for initialization
	void Awake () {
        target = GameObject.FindGameObjectWithTag("Fighter").transform;
	}

    void LateUpdate()
    {
        FollowPlayer();
    }

    void FollowPlayer()
    {
        transform.position = target.TransformPoint(offsetPosition);

        transform.rotation = target.rotation;
    }
}
