using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject ice;

	private float elapsed = 0;
	private float timer = 10;

	private PlayerController pc;

	// Use this for initialization
	void Start () {
		pc = GameObject.Find("player").GetComponent<PlayerController>();
	}
	
	// Update is called once per frame
	void Update () {
		elapsed += Time.deltaTime*pc.speed;
		if (elapsed >= timer) {
			elapsed = 0;
			GameObject instance = Instantiate(ice, this.transform.position, Quaternion.identity) as GameObject;
			instance.transform.SetParent(transform);
		}
	}
}
