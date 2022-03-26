using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Pointscount : MonoBehaviour
{

    public Text scoreText;
    public static int scoreNumber;
    public int score;
    public GameObject level1;
    //PlayfabManager playfabMananger ;
    public GameObject level2;
    public GameObject level3;
    public GameObject level4;
    public GameObject level5;
    public GameObject level6;
    public GameObject level7;


    public static Pointscount GameInstance;
    private Pointscount()
    {
        GameInstance = this;
    }
    public void Start()
    {
        PlayerPrefs.GetInt("Score", scoreNumber);
       // playfabMananger = GameObject.Find("PlayfabManager").GetComponent<PlayfabManager>();

    }

    public void Update()
    {
       
            PlayerPrefs.SetInt("Score", scoreNumber);
            scoreText.text = scoreNumber.ToString();
       //  playfabMananger.SendLeaderboard(scoreNumber);

        if (scoreNumber == 10)
        {
            level2.SetActive(true);
            level1.SetActive(false);


        }

        if (scoreNumber == 20)
        {
            level3.SetActive(true);
            level2.SetActive(false);
            level1.SetActive(false);


        }
        if (scoreNumber == 25)
        {
            level3.SetActive(true);
            level2.SetActive(false);
            level1.SetActive(false);


        }

        if (scoreNumber == 30)
        {
            level4.SetActive(true);
            level3.SetActive(false);
            level1.SetActive(false);


        }
        if (scoreNumber == 35)
        {
            level4.SetActive(true);
            level3.SetActive(false);
            level1.SetActive(false);


        }


        if (scoreNumber == 40)
        {
            level5.SetActive(true);
            level4.SetActive(false);


        }


        if (scoreNumber == 50)
        {
            level6.SetActive(true);
            level5.SetActive(false);

        }


        if (scoreNumber == 60)
        {
            level7.SetActive(true);
            level6.SetActive(false);

        }

    }
}
