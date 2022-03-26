using UnityEngine;
using System.Collections;

public class showGroup3 : MonoBehaviour
{
    public static bool ShowHidden = false;
    public GameObject Hidden;
    public static showGroup3 GameInstance;
    private showGroup3()
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
