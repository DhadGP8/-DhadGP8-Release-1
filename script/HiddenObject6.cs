using UnityEngine;
using System.Collections;

public class HiddenObject6 : MonoBehaviour
{
    public static bool ShowHidden6 = false;
    public GameObject Hidden6;
    public static HiddenObject6 GameInstance6;
    private HiddenObject6()
    {
        GameInstance6 = this;
    }

    public void Update()
    {
        if (ShowHidden6 == true)
        {
            Hidden6.SetActive(true);
        }
    }
}
