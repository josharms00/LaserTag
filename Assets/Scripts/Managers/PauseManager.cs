using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseManager : MonoBehaviour
{
    public bool paused = false;

    Canvas menu;

    public GameOverManager gameOverManager;

    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;

        menu = GetComponent<Canvas> ();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            paused = !paused;
        }

        if(paused && !gameOverManager.GameOver)
        {
            Cursor.visible = true;
            Cursor.lockState = CursorLockMode.None;
            menu.enabled = true;
        }
        else if (!paused || !gameOverManager.GameOver)
        {
            Cursor.visible = false;
            Cursor.lockState = CursorLockMode.Locked;
            menu.enabled = false;
        }
    }
}
