using UnityEngine;
using System.Collections;

public class unlocklevel2G2 : MonoBehaviour
{
    public static bool ShowHidden = false;
    public GameObject Hidden;
    public static unlocklevel2G2 GameInstance;
    private unlocklevel2G2()
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
