using UnityEngine;
using System.Collections;

public class InfiniteMovement : MonoBehaviour {

	public float initSpeed = 0;
	public int size = 5;
	public float baseSpeed = 0;

	private PlayerController pc;
	public GameObject player;

	private float pos = 0f;
	private float speed;

	void Awake () {
		speed = initSpeed;
		DontDestroyOnLoad(transform.gameObject);
        player = GameObject.Find("player");
		pc = player.GetComponent<PlayerController>();
	}

	// Update is called once per frame
	void Update () {
		float movement = -speed*Time.deltaTime*pc.speed + Time.deltaTime*baseSpeed;
		pos += movement;
		if (transform.position.x < -size) {
			pos += 2*size;
			transform.Translate(new Vector3(2*size,0,0));
		}
		transform.Translate(new Vector3(movement,0,0));
	}

	public void setSpeed(float factor) {
		speed = initSpeed * factor;
	}
}
