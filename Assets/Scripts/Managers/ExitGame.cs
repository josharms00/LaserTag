using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExitGame : MonoBehaviour
{
    public Button Exitbtn;

	void Awake () {
		Exitbtn = GetComponent<Button>();
		Exitbtn.onClick.AddListener(QuitGame);
	}

	void QuitGame(){
		Application.Quit();
	}
}
