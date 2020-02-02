using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class MainMenu : MonoBehaviour
{

    public bool isStart = false;
    public bool isQuit = false;
    public bool isCredits = false;
    private bool showCredits = false;
    private bool textureReady;
    private GUIContent content;
    private string credits;


    private void Start()
    {
        if (isCredits)
        {
            credits = "Credits\n\n";
            credits += "Developers: IAmTheRedSpy, KamiCreed, Sayaka, Vestrel\n";
            credits += "\n";
            credits += "Store Assets:\n";
            credits += "Quantum Development's 'Inventory System (Full)', https://assetstore.unity.com/packages/tools/gui/inventory-system-full-126053 \n";
            credits += "Ebal Studios's 'Star Sparrow Modular Spaceship', https://assetstore.unity.com/packages/3d/vehicles/space/star-sparrow-modular-spaceship-73167 \n";
            credits += "Unity Technologies's 'Standard Assets (for Unity 2017.3)', https://assetstore.unity.com/packages/essentials/asset-packs/standard-assets-for-unity-2017-3-32351 \n";
            credits += "\n";
            credits += "Music:\n";
            credits += "Moistgoatman's 'Machine dowering down', https://freesound.org/people/Moistgoatman/sounds/269588/ \n";
            credits += "nathanshadow's 'Thruster_Level_III.aif', https://freesound.org/people/nathanshadow/sounds/22456/ \n";
            credits += "josepharaoh99's 'Sci Fi Interface', https://freesound.org/people/josepharaoh99/sounds/367997/ \n";
            credits += "JarAxe's 'Alarm 4', https://freesound.org/people/JarAxe/sounds/204423/ \n";
            credits += "peepholecircus's 'Sci Fi button beep', https://freesound.org/people/peepholecircus/sounds/196979/ \n";
            credits += "Davidsraba's 'Coin Pickup Sound', https://freesound.org/people/Davidsraba/sounds/347172/ \n";
            credits += "spoonsandlessspoon's 'Device Powering Up', https://freesound.org/people/spoonsandlessspoons/sounds/361339/ \n";

            textureReady = false;
        }
    }
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
        if (isCredits)
        {
            showCredits = true;
        }
    }

    private void OnGUI()
    {
        if (showCredits)
        {
            if (!textureReady)
            {
                Texture2D bg = new Texture2D(Screen.width - 100, Screen.height - 100);
                var blacks = from x in Enumerable.Range(0, (Screen.width - 100) * (Screen.height - 100)) select (Color32)Color.black;
                bg.SetPixels32(blacks.ToArray());
                bg.Apply();
                content = new GUIContent(credits, bg);
                GUI.skin.box.normal.background = bg;
                textureReady = true;
            }
            GUI.Box(new Rect(50, 50, Screen.width - 100, Screen.height - 100), content);
            if (GUI.Button(new Rect(Screen.width-200, Screen.height-150, 100, 50), "close"))
            {
                showCredits = false;
            }
        }
    }
}
