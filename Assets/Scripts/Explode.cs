using UnityEngine;
using System.Collections;

public class Explode : MonoBehaviour {

	float speed = 0;
	private PlayerController pc;
	public GameObject player;

	// Use this for initialization
	void Start () {
		pc = player.GetComponent<PlayerController>();
		foreach (Transform child in transform) {
			child.GetComponent<PolygonCollider2D>().enabled = false;
		}

	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Space)) explode();
		transform.Translate(-pc.speed*Time.deltaTime,0,0);
	}

	void explode() {
		foreach (Transform child in transform) {
			child.gameObject.AddComponent<Rigidbody2D>();
			child.GetComponent<PolygonCollider2D>().enabled = true;
		}
	}
}
