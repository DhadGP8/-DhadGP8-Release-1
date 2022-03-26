using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class argame1 : MonoBehaviour
{
    public Transform[] points;
    public GameObject[] letters;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(StartSpawning());

    }
    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(4);
        for(int i = 0; i < 3; i++)
        {
            Instantiate(letters[i], points[i].position, Quaternion.identity);
        }
        StartCoroutine(StartSpawning());
    }
    
}
