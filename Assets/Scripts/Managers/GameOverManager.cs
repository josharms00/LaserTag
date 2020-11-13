using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverManager : MonoBehaviour
{
    public Timer timer;

    public ScoreManager scoreManager;

    public PauseManager pauseManager;

    public bool GameOver = false;

    // Update is called once per frame
    void Update()
    {
        if(timer.timeRemaining == 0)
        {
            AddToLeaderboard();
            
            pauseManager.paused = true;
            
            GameOver = true;
        }
        else
        {
            GameOver = false;
        }
    }

    void AddToLeaderboard()
    {
        LeaderBoardEntry p1 = gameObject.AddComponent<LeaderBoardEntry>();
        p1.AddEntry("Player 1", scoreManager.p1Score);

        LeaderBoardEntry p2 = gameObject.AddComponent<LeaderBoardEntry>();
        p2.AddEntry("Player 2", scoreManager.p2Score);

        LeaderboardManager.entries.Add(p1);
        LeaderboardManager.entries.Add(p2);
    }
}
