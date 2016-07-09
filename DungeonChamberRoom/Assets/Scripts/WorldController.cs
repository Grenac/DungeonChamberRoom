using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WorldController : MonoBehaviour {


	private List<GameObject> chamberObjects;

	public void registerChamberObject(GameObject newObject) {
		chamberObjects.Add(newObject);
	}


	// Use this for initialization
	void Start () {
		chamberObjects = new List<GameObject>();


	}

	// Update is called once per frame
	void Update () {
		Debug.Log(chamberObjects);
	}
}
