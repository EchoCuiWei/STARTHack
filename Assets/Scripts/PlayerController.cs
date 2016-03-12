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
	
	// Update is called once per frame
	void Update () {
		speed -= 0.01f;
		if (speed < 0) speed = 0;
		else if (speed > 1) speed = 1;
		Debug.Log(speed);
		animator.speed = speed;

		
		if (attacking) {
			elapsedAttack += Time.deltaTime;
			if (elapsedAttack > attackTime) {
				elapsedAttack = 0;
				attacking = false;
				animator.SetBool("hitting",false);
				effect.GetComponent<SpriteRenderer>().enabled = false;
			}
		}
	}

	public void attackingF() {
		animator.SetBool("hitting",true);
		effect.GetComponent<SpriteRenderer>().enabled = true;
		attacking = true;
	}
}
