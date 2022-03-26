using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shortscript : MonoBehaviour
{
    public GameObject arCamera;
    public GameObject smoke;
    // Start is called before the first frame update
public void shoot()
    {
        RaycastHit hit;
        if(Physics.Raycast(arCamera.transform.position,arCamera.transform.forward,out hit))
        {
            if (hit.transform.name == "letter1(Clone)")
                Destroy(hit.transform.gameObject);
            Instantiate(smoke, hit.point, Quaternion.LookRotation(hit.normal));

        }

    }
}
