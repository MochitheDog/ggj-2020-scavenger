using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickupable : MonoBehaviour
{
    [SerializeField] bool inPickupRange = false;
    [SerializeField] GameObject origin;

    public 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // If player enters pickupable item's trigger,
    // item is able to be picked up
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            inPickupRange = true;
            print("hi");
        }
    }

    // If player leaves trigger, item cannot be picked up
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            inPickupRange = false;
            print("bye");
        }
    }
}
