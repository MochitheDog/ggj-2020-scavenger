using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parts : MonoBehaviour
{
    public static int numCollected;
    public static int totalNum;
    public static bool createdShip = false;
    private void Start()
    {
        numCollected = 0;
        totalNum = 6;
    }
}
