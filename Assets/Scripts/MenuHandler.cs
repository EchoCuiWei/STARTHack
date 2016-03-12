using UnityEngine;
using System.Collections;

public class MenuHandler : MonoBehaviour {
    
	public static bool isRGBKeyboard;
	public UnityEngine.UI.Button keyboardButton;
    
	// Use this for initialization
	void Start () {
	    isRGBKeyboard = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void handleExitButton() {
        Application.Quit();
    }
    
    public void handleStartButton() {
        Application.LoadLevel("main");
    }
    
    public void handleCreditsButton() {
        Application.LoadLevel("Credits");
    }
    
    public void handleKeyboardButton() {
        isRGBKeyboard = !isRGBKeyboard;

        
        if(isRGBKeyboard) {
			keyboardButton.GetComponentInChildren<UnityEngine.UI.Text>().text = "KEYBOARD: RGB";
        } else {
			keyboardButton.GetComponentInChildren<UnityEngine.UI.Text>().text = "KEYBOARD: STANDARD";
        }
    }

	public void handleCreditsBackButton() {
		Application.LoadLevel("MainMenu");
	}
}
