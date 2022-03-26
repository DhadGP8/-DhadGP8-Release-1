using UnityEngine;
using System.Collections;

public class HiddenObject4 : MonoBehaviour
{
    public static bool ShowHidden4 = false;
    public GameObject Hidden4;
    public static HiddenObject4 GameInstance4;
    private HiddenObject4()
    {
        GameInstance4 = this;
    }

    public void Update()
    {
        if (ShowHidden4 == true)
        {
            Hidden4.SetActive(true);
        }
    }
}