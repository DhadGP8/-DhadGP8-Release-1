using UnityEngine;
using System.Collections;

public class showGroup : MonoBehaviour
{
    public static bool ShowHidden = false;
    public GameObject Hidden;
    public static showGroup GameInstance;
    private showGroup()
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
