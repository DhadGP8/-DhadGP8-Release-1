using UnityEngine;
using System.Collections;

public class unlocklevel2G6 : MonoBehaviour
{
    public static bool ShowHidden = false;
    public GameObject Hidden;
    public static unlocklevel2G6 GameInstance;
    private unlocklevel2G6()
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