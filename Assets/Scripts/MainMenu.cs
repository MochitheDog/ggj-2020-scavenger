using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{

    public bool isStart = false;
    public bool isQuit = false;

    private void OnMouseUp()
    {
        if (isStart)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("Level1");
        }
        if (isQuit)
        {
            Application.Quit();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
