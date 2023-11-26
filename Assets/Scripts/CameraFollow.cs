using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {
	private Transform player;

	void Start() {
		player = transform.parent;
	}

	void Update() {
		transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
	}
}
