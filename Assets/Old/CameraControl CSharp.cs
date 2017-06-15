using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControlCSharp : MonoBehaviour {
    public GameObject obj;
    public Transform target;
    public Camera cam;
    static public float lift = 1.5f;
    static float distance = -10;
    public Vector3 Vect = new Vector3(0, lift, distance);
 
	// Update is called once per frame
	void Update () {
        cam.transform.position = obj.transform.position + Vect;
        transform.LookAt(target);
    }
}
