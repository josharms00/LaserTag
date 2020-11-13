using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayGameOver : MonoBehaviour
{
    public GameOverManager gm;

    Canvas canvas;
    
    // Start is called before the first frame update
    void Start()
    {
        canvas = GetComponent<Canvas> ();
    }

    // Update is called once per frame
    void Update()
    {
        if(gm.GameOver)
        {
            canvas.enabled = true;
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            canvas.enabled = false;
        }
    }
}
