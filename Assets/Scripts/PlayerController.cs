using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 0;
	bool left = true;
	private float elapsedAttack = 0;
	public float attackTime = 1;
	private bool attacking = false;
	public GameObject effect;

	private Animator animator;

	// Use this for initialization
	void Start () {
		animator = this.GetComponent<Animator>();
		effect.GetComponent<SpriteRenderer>().enabled = false;
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (attacking && other.name == "broken" || other.name == "broken(Clone)") {
			Destroy(other.gameObject,5);
			other.GetComponent<Explode>().explode();
			this.GetComponent<BoxCollider2D>().enabled = false;
		}
	}

	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.J)) {
            speed += 0.25f;
        }

        speed -= 0.01f;
		if (speed < 0) speed = 0;
		else if (speed > 1) speed = 1;
		animator.speed = speed;

        if (Input.GetKey(KeyCode.Space)) {
            attackingF();
        }

        if (attacking) {
			elapsedAttack += Time.deltaTime;
			if (elapsedAttack > attackTime) {
				elapsedAttack = 0;
				attacking = false;
				animator.SetBool("hitting",false);
				effect.GetComponent<SpriteRenderer>().enabled = false;
				this.GetComponent<BoxCollider2D>().enabled = true;
			}
		}
	}

	public void attackingF() {
		animator.SetBool("hitting",true);
		effect.GetComponent<SpriteRenderer>().enabled = true;
		attacking = true;
	}
}
