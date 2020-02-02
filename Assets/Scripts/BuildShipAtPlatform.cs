using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Add this script to whatever object the player must collide with to check win condition
public class BuildShipAtPlatform : MonoBehaviour
{
    public GameObject completedShip;
    private bool created = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "FPSController" && Parts.numCollected == Parts.totalNum && !created)
        {
            print("Spawn Ship");
            Instantiate(completedShip, transform.position + new Vector3(-10.991f, 4.01f, -7.99f), Quaternion.Euler(0,0,0));
            created = true;
        }
    }
}
