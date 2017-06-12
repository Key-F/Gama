#pragma strict

var obj1: GameObject;
public var target : Transform;
var cam: Camera;
var lift = 1.5;
var distance = -10;


function Update () {
    cam.transform.position = obj1.transform.position + Vector3(0, lift, distance);
	transform.LookAt(target);
}
 