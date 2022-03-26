using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Menu : MonoBehaviour {

    public GameObject panelBestScore;
    public Text bestScoreText;


     void Start()
    {
       
    }



    public void StartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void BestScore()
    {
        
        panelBestScore.SetActive(true);
        bestScoreText.text = PlayerPrefs.GetInt("HighScore").ToString();
    
    }

    public void Return()
    {
        panelBestScore.SetActive(false);
    }
}
