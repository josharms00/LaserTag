using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    GameObject player1;

    Tagged p1Tag;

    public int p1Score;

    public int p2Score;

    GameObject player2;

    Tagged p2Tag;

    GameObject HUD;

    Text[] scores;

    void Awake()
    {
        player1 = GameObject.Find("Player1");

        p1Tag = player1.GetComponent<Tagged> ();

        player2 = GameObject.Find("Player2");

        p2Tag = player2.GetComponent<Tagged> ();

        HUD = GameObject.Find("HUD");

        scores = HUD.GetComponentsInChildren<Text> ();
    }

    void Update()
    {
        p1Score = Mathf.FloorToInt(p1Tag.timeNotIt);

        p2Score = Mathf.FloorToInt(p2Tag.timeNotIt);

        DisplayScore();
    }

    void DisplayScore()
    {
        scores[0].text = "P1: " + p1Score + "s";

        scores[1].text = "P2: " + p2Score + "s";
    }
}
