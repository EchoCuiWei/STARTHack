using UnityEngine;
using System.Collections;

public class Explode : MonoBehaviour {

	float speed = 0;
	private PlayerController pc;
	public GameObject player;
	public GameObject[] flavours;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("player");
		Vector3 pos = this.transform.position;
		pos.z = -2;
		GameObject instance = Instantiate(flavours[Random.Range(0,flavours.Length)], pos , Quaternion.identity) as GameObject;
		instance.transform.SetParent(transform);
		pc = player.GetComponent<PlayerController>();
		foreach (PolygonCollider2D pc2d in gameObject.GetComponentsInChildren<PolygonCollider2D>()) {
			pc2d.enabled = false;
		}
	}

	// Update is called once per frame
	void Update () {
		transform.Translate(-pc.speed*Time.deltaTime,0,0);
	}

	public void explode() {
		this.GetComponent<BoxCollider2D>().enabled = false;
		foreach (PolygonCollider2D pc2d in gameObject.GetComponentsInChildren<PolygonCollider2D>()) {
			pc2d.enabled = true;
		}
		foreach (Transform child in transform) {
			child.gameObject.AddComponent<Rigidbody2D>();
			child.gameObject.GetComponent<Rigidbody2D>().velocity = new Vector2(3.0f, 3.0f);
		}
	}
}
