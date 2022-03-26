using UnityEngine;
using System.Collections;

public class unlocklevel2G4 : MonoBehaviour
{
    public static bool ShowHidden = false;
    public GameObject Hidden;
    public static unlocklevel2G4 GameInstance;
    private unlocklevel2G4()
    {
        GameInstance = this;
    }

    public void Update()
    {
        if (ShowHidden == true)
        {
            Hidden.SetActive(false);
        }
    }
}
