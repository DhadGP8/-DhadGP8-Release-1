using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class progresBar : MonoBehaviour
{
    public static bool ShowHidden = false;
    public Image Hidden;
    public static progresBar GameInstance;
    public static float num ;
    public static float max= 100.0f; 
    private progresBar()
    {
        GameInstance = this;
    }
    public void Start()
    {
      

    }
    public void Update()
    {
        if (ShowHidden == true)
        {
          
            Hidden.fillAmount = num / max;
        }
    }
}
