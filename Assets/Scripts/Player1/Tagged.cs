using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tagged : MonoBehaviour
{
    public bool It;

    public Text itText;

    public float timeNotIt = 0f;

    public GameObject menu;

    PauseManager p;

    void Awake()
    {

        p = menu.GetComponent<PauseManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!p.paused)
        {
            if (It)
            {
                itText.enabled = true;
            }
            else{
                itText.enabled = false;
                timeNotIt += Time.deltaTime;
            }
        }
    }
}
