using UnityEngine;
using System.Collections;

public class showGroup2 : MonoBehaviour
{
    public static bool ShowHidden = false;
    public GameObject Hidden;
    public static showGroup2 GameInstance;
    private showGroup2()
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