using UnityEngine;
using System.Collections;

public class UI : MonoBehaviour {

    bool showText = true;
    float time = 0.0f;
    Rect textArea = new Rect( 10 , 10 , Screen.width-50 , Screen.height-50 );

	// Use this for initialization
	void Start () {
	
	}


    void OnGUI() {

        if ( showText ) {

            GUI.Label( textArea , "It's been " + Mathf.Ceil( time ) + " seconds ! \n RUN!!!" );

        }

    }


	// Update is called once per frame
	void Update () {
	    time += Time.deltaTime;
	}
}
