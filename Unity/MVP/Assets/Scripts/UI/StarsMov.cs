using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsMov : MonoBehaviour {
    public float movSpeed;

	// Update is called once per frame
	void Update () {
        transform.Rotate(0, movSpeed, 0);
	}
}
