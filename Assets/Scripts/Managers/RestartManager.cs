using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class RestartManager : MonoBehaviour
{
    public Button Restartbtn;

	void Awake () {
		Restartbtn = GetComponent<Button>();
		Restartbtn.onClick.AddListener(Restart);
	}

	void Restart(){
		SceneManager.LoadScene("DartTagArena", LoadSceneMode.Single);
	}
}
