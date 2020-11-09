using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public Timer timer;

    public ScoreManager scoreManager;

    // Update is called once per frame
    void Update()
    {
        if(timer.timeRemaining == 0)
        {
            AddToLeaderboard();

            SceneManager.LoadScene("DartTagArena", LoadSceneMode.Single);
        }
    }

    void AddToLeaderboard()
    {
        LeaderBoardEntry p1 = new LeaderBoardEntry();
        p1.AddEntry("Player 1", scoreManager.p1Score);

        LeaderBoardEntry p2 = new LeaderBoardEntry();
        p2.AddEntry("Player 2", scoreManager.p2Score);

        LeaderboardManager.entries.Add(p1);
        LeaderboardManager.entries.Add(p2);
    }
}
