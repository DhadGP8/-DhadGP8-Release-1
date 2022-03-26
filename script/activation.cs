using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activation : MonoBehaviour
{
    public GameObject active;
    public GameObject oben;
    public GameObject cloes;

    public void activatfunction()
    {
        active.SetActive(true);

    }
    public void disactivatfunction()
    {
        active.SetActive(false);

    }

    public void obenfunction()
    {
        cloes.SetActive(false);

        oben.SetActive(true);

    }
    public void cloesfunction()
    {
        oben.SetActive(false);

        cloes.SetActive(true);

    }
}
