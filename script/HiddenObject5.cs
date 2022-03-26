using UnityEngine;
using System.Collections;

public class HiddenObject5 : MonoBehaviour
{
    public static bool ShowHidden5 = false;
    public GameObject Hidden5;
    public static HiddenObject5 GameInstance5;
    private HiddenObject5()
    {
        GameInstance5 = this;
    }

    public void Update()
    {
        if (ShowHidden5 == true)
        {
            Hidden5.SetActive(true);
        }
    }
}
