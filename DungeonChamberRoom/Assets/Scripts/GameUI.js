#pragma strict

var itemSlots : GameObject[];
var characterKnightItems : Sprite[];

// for now
var item1Count :  int;
var item2Count :  int;
var item3Count :  int;

function Start () {

	itemSlots[0].GetComponentInChildren.<UnityEngine.UI.Text>().text = "x "+item1Count;
	itemSlots[1].GetComponentInChildren.<UnityEngine.UI.Text>().text = "x "+item2Count;
	itemSlots[2].GetComponentInChildren.<UnityEngine.UI.Text>().text = "x "+item3Count;

}

function Update () {

}