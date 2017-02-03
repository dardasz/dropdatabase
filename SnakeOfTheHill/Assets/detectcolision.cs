using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class detectcolision : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void OnCollisionEnter(Collision col)
    {
        Time.timeScale = 0;
    }
}
