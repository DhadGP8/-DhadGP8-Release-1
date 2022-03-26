using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class genderActive : MonoBehaviour
{
    public GameObject girle;
    public GameObject boy;


    public void activatGirle()
    {
        girle.SetActive(true);
        boy.SetActive(false);


    }
    public void activatBoy()
    {
        boy.SetActive(true);
        girle.SetActive(false);


    }
}
