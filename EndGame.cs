using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour {

     void Update()
    {
        StartCoroutine(endGame()); 
    }

    IEnumerator endGame()
    {
        yield return new WaitForSeconds(5f);
        SceneManager.LoadScene("Menu");
       
    }
}
