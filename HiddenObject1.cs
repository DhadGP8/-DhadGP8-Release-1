using UnityEngine;
using System.Collections;

public class HiddenObject1 : MonoBehaviour
{
    public static bool ShowHidden1 = false;
    public GameObject Hidden1;
    public static HiddenObject1 GameInstance1;
    private HiddenObject1()
    {
        GameInstance1 = this;
    }

    public void Update()
    {
        if (ShowHidden1 == true)
        {
            Hidden1.SetActive(true);
        }
    }
}