#pragma strict
var CoinEffect : Transform;
var CoinRotationSpeed = 2;
function OnTriggerEnter (info : Collider) {
	if (info.name == "Ball")
	{
		//GuimMuniger.currentScore += 1;
		var effect = Instantiate(CoinEffect, transform.position, transform.rotation);
		Destroy(effect.gameObject, 2);
		Destroy(gameObject);
	}
}

	function Update () {
     transform.Rotate(Vector3.up * CoinRotationSpeed);
}
	

