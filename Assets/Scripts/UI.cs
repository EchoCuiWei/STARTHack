using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {

    bool showText = true;
    float time = 0.0f;
    Rect textArea = new Rect( 10 , 10 , Screen.width-50 , Screen.height-50 );
    private GameObject enemy;
    string string_random;
    private GameObject player;

    // Use this for initialization
    void Start () {
        enemy = GameObject.Find("enemy");
        player = GameObject.Find("player");
    }


    void OnGUI() {

        if ( showText ) {

            GUI.Label( textArea , string_random);

        }




    }


	// Update is called once per frame
	void Update () {
	    time += Time.deltaTime;


        if (enemy.GetComponent<enemyControler>().deadBoy) 
            string_random = "Eres un campeón!";
        else if (player.GetComponent<PlayerController>().deadBoy)
            string_random = "Has muerto";
        else string_random = "It's been " + Mathf.Ceil(time) + " seconds ! \n RUN!!!";
        
	}
}
