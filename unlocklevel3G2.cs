using UnityEngine;
using System.Collections;

public class unlocklevel3G2 : MonoBehaviour
{
    public static bool ShowHidden = false;
    public GameObject Hidden;
    public static unlocklevel3G2 GameInstance;
    private unlocklevel3G2()
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