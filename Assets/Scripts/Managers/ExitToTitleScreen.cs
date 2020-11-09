using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitToTitleScreen : MonoBehaviour
{
    public Button returnBtn;

	void Awake () {
		returnBtn = GetComponent<Button>();
		returnBtn.onClick.AddListener(Return);
	}

	void Return(){
		SceneManager.LoadScene("TitleScreen", LoadSceneMode.Single);
	}
}
