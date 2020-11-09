using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenLeaderboard : MonoBehaviour
{
    public Button leaderboardBtn;

	void Awake () {
		leaderboardBtn = GetComponent<Button>();
		leaderboardBtn.onClick.AddListener(GoTo);
	}

	void GoTo(){
		SceneManager.LoadScene("Leaderboard", LoadSceneMode.Single);
	}
}
