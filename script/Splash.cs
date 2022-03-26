using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{

    public Button btn;

    void Start()
    {
        StartCoroutine(WaitAndShowText());
    }

    IEnumerator WaitAndShowText()
    {
        yield return new WaitForSeconds(2f);
        btn.gameObject.SetActive(true);

    }

    public void ButttonSelect()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}


