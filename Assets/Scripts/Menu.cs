using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{

    private bool menuOpen = false;

    private void OnGUI()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            menuOpen = true;
            Cursor.lockState = CursorLockMode.None;
        }

        if (menuOpen)
        {
            GUI.Box(new Rect(Screen.width/2 - 200, Screen.height/2 - 100, 400, 100), "Quit Game?");
            if (GUI.Button(new Rect(Screen.width/2-180, Screen.height/2-60, 160, 50), "Yes"))
            {
                Application.Quit();
            }
            if(GUI.Button(new Rect(Screen.width/2 + 20, Screen.height/2-60, 160, 50), "No"))
            {
                menuOpen = false;
                Cursor.lockState = CursorLockMode.Locked;
            }

        }
    }
}
