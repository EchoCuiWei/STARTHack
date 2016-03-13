                   using UnityEngine;
using System.Collections;

public class enemyControler : MonoBehaviour {

	public float speed = 0;
	public GameObject effect;
	public GameObject dead;
	private bool deadBoy = false;

	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator>();
		effect.GetComponent<SpriteRenderer>().enabled = false;
	}

	void OnTriggerEnter2D(Collider2D other) {
        if ( other.name == "player" ) {
				deadBoy = true;
				Vector3 pos = transform.position;
				pos.y += 0.1f;
				pos.z += -2;
				GameObject instance = Instantiate(dead, pos , Quaternion.identity) as GameObject;
				instance.transform.SetParent(transform);
		}
	}

	// Update is called once per frame
	void Update () {
            speed += 0.20f;

        speed -= 0.01f;
		if (speed < 0) speed = 0;
		else if (speed > 1) speed = 1;

		
		if (deadBoy) {
			speed = 0;
		}
		animator.speed = speed;

	}

	public void attackingF() {

	}
}
