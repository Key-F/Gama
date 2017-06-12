#pragma strict

var rotationSpeed = 100;
var jumpheight = 9;
var isFalling = false;

function Update () 
{
	var rotation : float = Input.GetAxis ("Horizontal") * rotationSpeed;
	rotation *= Time.deltaTime;
	GetComponent.<Rigidbody>().AddRelativeTorque (Vector3.back * rotation);

	if (Input.GetKey(KeyCode.W))
	{
		GetComponent.<Rigidbody>().velocity.y = jumpheight;
	
	}
	if (Input.GetKey(KeyCode.S))
	{
		GetComponent.<Rigidbody>().velocity.y = -jumpheight;
	
	}

	if (Input.GetKey(KeyCode.D))
	{
		GetComponent.<Rigidbody>().velocity.x = jumpheight;
	
	}
	if (Input.GetKey(KeyCode.A))
	{
		GetComponent.<Rigidbody>().velocity.x = -jumpheight;
	
	}
}
