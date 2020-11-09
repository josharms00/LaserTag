using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContinueManager : MonoBehaviour
{
    public Button Continuebtn;

    Canvas menu;

    PauseManager p;

	void Awake () {
		Continuebtn = GetComponent<Button>();
		Continuebtn.onClick.AddListener(Continue);
        menu = GetComponentInParent<Canvas> ();
        p = GetComponentInParent<PauseManager> ();
	}

	void Continue(){
		menu.enabled = false;
        p.paused = false;
	}
}
