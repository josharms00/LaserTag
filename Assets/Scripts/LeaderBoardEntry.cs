using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeaderBoardEntry : MonoBehaviour
{
    string n;
    int s;

    public void AddEntry(string name, int score)
    {
        n = name;
        s = score;
    }

    public string GetName()
    {
        return n;
    }

    public int GetScore()
    {
        return s;
    }
}
