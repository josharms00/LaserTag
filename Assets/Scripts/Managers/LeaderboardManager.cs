using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LeaderboardManager : MonoBehaviour
{

    public static List<LeaderBoardEntry> entries;

    Transform template;

    float templateHeight = 20f;

    // Start is called before the first frame update
    void Awake()
    {
        if(entries == null)
        {
            return;
        }
        
        template = transform.Find("Template");

        for( int i = 0; i < 10; i++)
        {
            if(entries.Count == i)
            {
                break;
            }
            Transform newEntry = Instantiate(template, transform);
            RectTransform rect = newEntry.GetComponent<RectTransform> ();
            rect.anchoredPosition = new Vector2(0, -templateHeight * i);
            newEntry.gameObject.SetActive(true);

            Text[] texts = newEntry.GetComponentsInChildren<Text> ();

            texts[0].text = entries[i].GetName();
            texts[1].text = entries[i].GetScore().ToString();
        }
    }
}
