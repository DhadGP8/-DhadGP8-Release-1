using UnityEngine;
using System.Collections;

public class showGroup1 : MonoBehaviour
{
    public static bool ShowHidden = false;
    public GameObject Hidden;
    public static showGroup1 GameInstance;
    private showGroup1()
    {
        GameInstance = this;
    }

    public void Update()
    {
        if (ShowHidden == true)
        {
            Hidden.SetActive(true);
        }
    }
}