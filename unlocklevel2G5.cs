using UnityEngine;
using System.Collections;

public class unlocklevel2G5 : MonoBehaviour
{
    public static bool ShowHidden = false;
    public GameObject Hidden;
    public static unlocklevel2G5 GameInstance;
    private unlocklevel2G5()
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