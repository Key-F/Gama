#pragma strict

static var currentScore : int = 0;
public var GUI : UnityEngine.UI.Text;
var test = 0;

function Update (){
	GUI.text = currentScore.ToString();
}
function OnGUI () {
	
}
