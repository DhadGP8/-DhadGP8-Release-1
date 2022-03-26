using UnityEngine;
using System.Collections;

public class showGroup4 : MonoBehaviour
{
    public static bool ShowHidden = false;
    public GameObject Hidden;
    public static showGroup4 GameInstance;
    private showGroup4()
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