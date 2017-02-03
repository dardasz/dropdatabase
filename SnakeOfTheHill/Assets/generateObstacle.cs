using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generateObstacle : MonoBehaviour {

    // Use this for initialization
    float x;
    float y;
    float z;
    Vector3 pos;

    void Start()
    {
        x = Random.Range(-18, 18);
        z = Random.Range(-18, 18);

        pos = new Vector3(x, 0, z);
        transform.position = pos;
    }

    // Update is called once per frame
    void Update () {
		
	}
}

/*
 



 * */
