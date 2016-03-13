using UnityEngine;
using System.Collections;

public class TitleMovement : MonoBehaviour {
	Transform transform2;
	Vector3 startpos;
	Vector3 endpos;

	Quaternion startrotation;
	Quaternion endrotation;

	Quaternion leftrotation;
	Quaternion rightrotation;


	float t;
	float t_rot;

	// Use this for initialization
	void Start () {
		transform2 = GetComponent<Transform> ();
		startpos = transform2.position;
		endpos = startpos + new Vector3 (0.0f, 40.0f, 0.0f);
		startrotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, -4.0f));
		endrotation = Quaternion.Euler(new Vector3(0.0f, 0.0f, 4.0f));

		t = 0.0f;
	}
	
	// Update is called once per frame
	void Update () {
		t += Time.deltaTime;
		t_rot += Time.deltaTime / 2.0f;
		transform2.position = Vector3.Lerp(startpos, endpos, Mathf.SmoothStep(0.0f, 1.0f, t));
		transform2.rotation = Quaternion.Lerp(startrotation, endrotation, Mathf.SmoothStep(0.0f, 1.0f, t_rot));

		if (t >= 1.0f) {
			endpos = startpos;
			startpos = transform2.position;

			t = 0.0f;
		}

		if (t_rot >= 1.0f) {
			endrotation = startrotation;
			startrotation = transform2.rotation;

			t_rot = 0.0f;
		}
	}
}
