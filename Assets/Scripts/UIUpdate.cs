using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIUpdate : MonoBehaviour
{
    public GameObject textBox;
    private UnityEngine.UI.Text partsText;
    private string staticPartsUI = "/6 parts found";
    private const string GO_TO_PLATFORM = "All parts found!\nGo back to the red platform to build the ship!";

    // Start is called before the first frame update
    void Start()
    {
        partsText = textBox.GetComponent<UnityEngine.UI.Text>();
        staticPartsUI = "/" + Parts.totalNum + " parts found";
    }

    // Update is called once per frame
    void Update()
    {
        if (Parts.numCollected != Parts.totalNum)
        {
            int numPartsFound = Parts.numCollected;
            partsText.text = numPartsFound + staticPartsUI;
        } else
        {
            partsText.text = GO_TO_PLATFORM;
        }
    }
}
