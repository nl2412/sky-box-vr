﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionTest : MonoBehaviour {

    public AudioClip triggerSound;
    // Use this for initialization
    void Start () {
	}
	
	// Update is called once per frame
	void Update () {
    }

    void OnTriggerEnter(Collider other)
    {
        AudioSource.PlayClipAtPoint(triggerSound, transform.position);
        Debug.Log(gameObject.name + " was triggered by " + other.gameObject.name);
        DestroyObject(gameObject); // destroy that object
        CustomNetwork.instance.SendObjectDestroyedMsg(gameObject.name.ToString().Trim(), other.gameObject.name.ToString().Trim());
    }
}
