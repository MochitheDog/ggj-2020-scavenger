using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIUpdate : MonoBehaviour
{

    private UnityEngine.UI.Text partsText;
    private string staticPartsUI = "/6 parts found";

    // Start is called before the first frame update
    void Start()
    {
        partsText = GameObject.Find("UIParts").GetComponent<UnityEngine.UI.Text>();
        staticPartsUI = "/" + Parts.totalNum + " parts found";
    }

    // Update is called once per frame
    void Update()
    {
        int numPartsFound = Parts.numCollected;
        partsText.text = numPartsFound + staticPartsUI;
    }
}
