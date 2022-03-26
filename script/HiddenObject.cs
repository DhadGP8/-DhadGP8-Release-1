using UnityEngine;
using System.Collections;

public class HiddenObject : MonoBehaviour
{
    public static bool ShowHidden = false;
    public GameObject Hidden;
    public static HiddenObject GameInstance;
    private HiddenObject()
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
