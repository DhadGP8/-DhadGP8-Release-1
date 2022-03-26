using UnityEngine;
using System.Collections;

public class HiddenObject3 : MonoBehaviour
{
    public static bool ShowHidden3 = false;
    public GameObject Hidden3;
    public static HiddenObject3 GameInstance3;
    private HiddenObject3()
    {
        GameInstance3 = this;
    }

    public void Update()
    {
        if (ShowHidden3 == true)
        {
            Hidden3.SetActive(true);
        }
    }
}