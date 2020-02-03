using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Add this script to whatever object the player must collide with to check win condition
public class BuildShipAtPlatform : MonoBehaviour
{
    public GameObject completedShip;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FPSController" && Parts.numCollected == Parts.totalNum && !Parts.createdShip)
        {
            print("Spawn Ship");
            Instantiate(completedShip, transform.position + new Vector3(-10.991f, 4.01f, -7.99f), Quaternion.Euler(0,0,0));
            Parts.createdShip = true;
            FindObjectOfType<AudioManager2>().Play("level", 3);
            FindObjectOfType<AudioManager2>().fade("level", 1, 0.5f);
            FindObjectOfType<AudioManager2>().fade("level", 2, 0.5f);
        }
    }
}
