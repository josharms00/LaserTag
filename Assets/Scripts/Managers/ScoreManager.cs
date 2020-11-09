using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    GameObject player1;

    Tagged p1Tag;

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
        scores[0].text = "P1: " + Mathf.FloorToInt(p1Tag.timeNotIt) + "s";

        scores[1].text = "P2: " + Mathf.FloorToInt(p2Tag.timeNotIt) + "s";
    }
}
