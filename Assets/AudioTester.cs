using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTester : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

      if (Input.GetKeyDown(KeyCode.Keypad1)){
  			FindObjectOfType<AudioManager2>().Play("player", 1);
  		}

      if (Input.GetKeyDown(KeyCode.Keypad2)){
        FindObjectOfType<AudioManager2>().Play("player", 0);
      }

      if (Input.GetKeyDown(KeyCode.Keypad3)){
        FindObjectOfType<AudioManager2>().Play("ambient", 0);
      }

      if (Input.GetKeyDown(KeyCode.Keypad4)){
        Debug.Log("keypad4");
        FindObjectOfType<AudioManager2>().Play("level", 0);
      }

    }
}
