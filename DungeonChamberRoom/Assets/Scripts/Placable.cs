using UnityEngine;
using System.Collections;

public class Placable : MonoBehaviour {


	private Vector2 worldPosition;
	public Vector2 WorldPosition {
		get {
			return worldPosition;
		}
	}

	// Use this for initialization
	void Start () {
		worldPosition = new Vector2(2, 4);
	}

	// Update is called once per frame
	void Update () {



	}
}
