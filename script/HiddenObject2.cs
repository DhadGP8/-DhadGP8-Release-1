using UnityEngine;
using System.Collections;

public class HiddenObject2 : MonoBehaviour
{
    public static bool ShowHidden2 = false;
    public GameObject Hidden2;
    public static HiddenObject2 GameInstance2;
    private HiddenObject2()
    {
        GameInstance2 = this;
    }

    public void Update()
    {
        if (ShowHidden2 == true)
        {
            Hidden2.SetActive(true);
        }
    }
}
