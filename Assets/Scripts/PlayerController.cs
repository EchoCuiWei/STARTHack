using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	float speed = 0;
	bool left = true;

	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () {
		if (left && Input.GetKeyDown(KeyCode.A)) {
			speed += 0.25f;
			left = !left;
		}
		else if (!left && Input.GetKeyDown(KeyCode.J)) {
			speed += 0.25f;
			left = !left;
		}
		else speed -= 0.01f;
		if (speed < 0) speed = 0;
		else if (speed > 1) speed = 1;
		Debug.Log(speed);
		animator.speed = speed;

	}
}
