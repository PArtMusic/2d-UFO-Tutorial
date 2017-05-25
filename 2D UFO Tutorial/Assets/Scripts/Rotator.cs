using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotator : MonoBehaviour {
    public Vector3 v3 = new Vector3(0,0,45);
    // Update is called once per frame
    void Update () {
        transform.Rotate(v3 * Time.deltaTime);
	}
}
