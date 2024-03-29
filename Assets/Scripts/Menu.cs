﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Menu : MonoBehaviour
{

    private bool menuOpen = false;
    public GameObject myFPSController = null;
    MouseLook mouseLook;

    private void Start()
    {
        if (myFPSController == null)
        {
            mouseLook = null;
        }
        else
        {
            mouseLook = myFPSController.GetComponent<FirstPersonController>().m_MouseLook;
        }

        GUI.backgroundColor = Color.black;
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            menuOpen = true;
            // Cursor.lockState = CursorLockMode.None;
            if (mouseLook == null)
            {
                Cursor.lockState = CursorLockMode.None;
            }
            else
            {
                mouseLook.SetCursorLock(false);
            }
        }
    }

    private void OnGUI()
    {
        if (menuOpen)
        {
            GUI.Box(new Rect(Screen.width/2 - 200, Screen.height/2 - 50, 400, 100), "Do you want to return to the main menu?");
            if (GUI.Button(new Rect(Screen.width/2-180, Screen.height/2-10, 160, 50), "Yes"))
            {
                UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
            }
            if(GUI.Button(new Rect(Screen.width/2 + 20, Screen.height/2-10, 160, 50), "No"))
            {
                menuOpen = false;
                //Cursor.lockState = CursorLockMode.Locked;
                if (mouseLook == null)
                {
                    Cursor.lockState = CursorLockMode.Locked;
                }
                else
                {
                    mouseLook.SetCursorLock(true);
                }

            }

        }
    }
}
