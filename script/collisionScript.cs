using UnityEngine;
using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class collisionScript : MonoBehaviour {
    public Text scoreText;
    public static int scoreNumber;
    public GameObject ob1;
    public GameObject ob2;
    public Text scorePanel;

    public GameObject ob3;
    public GameObject ob4;
    public GameObject ob5;
    public GameObject ob6; 
    public GameObject ob12;
    public GameObject ob22;
    public GameObject ob32;
    public GameObject ob42;
    public GameObject ob52;
    public GameObject ob62;
    public Text text;
    public  float time;
    public GameObject stoppanel;



    // Use this for initialization
    void Start () {
        PlayerPrefs.GetInt("Score", scoreNumber);
        time = 30;

    }

    // Update is called once per frame
    void Update () {
        PlayerPrefs.SetInt("Score", scoreNumber);
        scoreText.text = scoreNumber.ToString();
        scorePanel.text = scoreNumber.ToString();
        time -= Time.deltaTime;
        text.text = "" + Mathf.Round(time);
       if(scoreNumber == 6||time <= 0) { 
            stoppanel.SetActive(true);
        }

    }

    //for this to work both need colliders, one must have rigid body (spaceship) the other must have is trigger checked.
    public  void OnTriggerEnter (Collider col)
  {
  
    Destroy(col.transform.gameObject); // destroy spider
            scoreNumber+=1;


         /*   if (GameObject.FindGameObjectsWithTag("player1").Length == 0)
            {
            ob1.SetActive(true);
            ob1 = ob12;


        }
        if (GameObject.FindGameObjectsWithTag("player2").Length == 0)
            {

            ob2.SetActive(true);
            ob2 = ob22;
        }
        if (GameObject.FindGameObjectsWithTag("player3").Length == 0)
            {
            ob3.SetActive(true);
            ob3 = ob32;
        }
        if (GameObject.FindGameObjectsWithTag("player4").Length == 0)
            {
            ob4.SetActive(true);
            ob4 = ob42;

        }
        if (GameObject.FindGameObjectsWithTag("player5").Length == 0)
            {
            ob5.SetActive(true);
            ob5 = ob52;

        }
        if (GameObject.FindGameObjectsWithTag("player6").Length == 0)
            {
            ob6.SetActive(true);
            ob6 = ob62;

        }
       if (ob12.activeInHierarchy == false)
        {
            scoreNumber++;

        }
        if (ob22.activeInHierarchy == false)
        {
            scoreNumber++;

        }
        if (ob32.activeInHierarchy == false)
        {
            scoreNumber++;

        }
        if (ob42.activeInHierarchy == false)
        {
            scoreNumber++;

        }
        if (ob52.activeInHierarchy == false)
        {
            scoreNumber++;

        }*/


    }
    public void OnTriggerEnter ()
  {
       
  
    Destroy(gameObject); // destroy spider
        

   
  }

    public void finsh()

    {
        stoppanel.SetActive(false);
        SceneManager.LoadScene("interface");

        scoreNumber = 0;

    }



}
