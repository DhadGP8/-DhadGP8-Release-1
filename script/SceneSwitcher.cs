using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; 




public class SceneSwitcher : MonoBehaviour
{


    public static int checkG1L1=1;
    public static int checkG1L1int=0;

    public static int checkG1L2 = 1;
    public static int checkG1L2int = 0;

    public static int checkG2L1 = 1;
    public static int checkG2L1int = 0;


    public static int checkG3L1 = 1;
    public static int checkG3L1int = 0;

    public static int checkG4L1 = 1;
    public static int checkG4L1int = 0;

    public static int checkG5L1 = 1;
    public static int checkG5L1int = 0;

    public static int checkG6L1 = 1;
    public static int checkG6L1int = 0;

    public void Start()
    {


    }

    public void popUp()
    {
        SceneManager.LoadScene("popUp");
    }
    public void writeLetter()
    {
        SceneManager.LoadScene("AlphabetMenu");
    }
    public void ScanGame()
    {
        SceneManager.LoadScene("ScanGame");
    }
     public void Singout()
    {
        SceneManager.LoadScene("Login");
    }
    public void ARGame()
    {
        SceneManager.LoadScene("ARgame");
      


    }
    public void ARGame2()
    {
        SceneManager.LoadScene("ARgame");
        showGroup.ShowHidden = false;
        showGroup1.ShowHidden = false;
        showGroup2.ShowHidden = false;
        showGroup3.ShowHidden = false;
        showGroup4.ShowHidden = false;
        showGroup5.ShowHidden = false;


    }
    public void interface1()
    {
        SceneManager.LoadScene("interface");
    }
    public void draganddrop()
    {
        SceneManager.LoadScene("draganddrop");
    }
    public void draganddrop1()
    {
        SceneManager.LoadScene("draganddropnumber1");
    }
    public void draganddropNum1()
    {
        SceneManager.LoadScene("draganddropNum1");
    }
    public void dragAnddropNum2()
    {
        SceneManager.LoadScene("dragAnddropNum 2");
    }

    public void draganddrop3()
    {
        SceneManager.LoadScene("draganddrop-3");
    }
        public void draganddrop4()
    {
        SceneManager.LoadScene("draganddrop 4");
    }      public void draganddrop5()
    {
        SceneManager.LoadScene("draganddrop 5");
    }

    public void alanoudGame()
    {
        SceneManager.LoadScene("alanoudGame");

    }
    public void AlphabetWriting()
    {
        SceneManager.LoadScene("AlphabetWriting");

    }


    public void Game1level1()
    {
        SceneManager.LoadScene("ARgame");
        showGroup.ShowHidden = true;

        HiddenObject.ShowHidden = true;
        unlocklevel2.ShowHidden = true;
        progresBar.ShowHidden = true;
        checkG1L1int++;

        if (checkG1L1 == checkG1L1int)
        {
            Pointscount.scoreNumber += 5;
            progresBar.num += 7.2f;
        }
    }
    public void Game1level2()
        {
            SceneManager.LoadScene("ARgame");
        showGroup.ShowHidden = true;

        HiddenObject1.ShowHidden1 = true;
            unlocklevel3.ShowHidden = true;
        progresBar.ShowHidden = true;
        checkG1L2int++;

        if (checkG1L2 == checkG1L2int)
        {
            Pointscount.scoreNumber += 5;
            progresBar.num += 7.2f;
        }

    }
    public void Game2level1()
    {
        SceneManager.LoadScene("ARgame");
        showGroup1.ShowHidden = true;

        HiddenObject2.ShowHidden2 = true;
        unlocklevel2G2.ShowHidden = true;
        progresBar.ShowHidden = true;
        checkG2L1int++;
        if (checkG2L1 == checkG2L1int)
        {
            Pointscount.scoreNumber += 5;
            progresBar.num += 7.2f;
        }

    }
    public void Game3level1()
    {
        SceneManager.LoadScene("ARgame");
        showGroup2.ShowHidden = true;

        HiddenObject3.ShowHidden3 = true;
        unlocklevel2G3.ShowHidden = true;
        progresBar.ShowHidden = true;
        checkG3L1int++;
        if (checkG3L1 == checkG3L1int)
        {
            Pointscount.scoreNumber += 5;
            progresBar.num += 7.2f;
        }


    }
    public void Game4level1()
    {
        SceneManager.LoadScene("ARgame");
        showGroup3.ShowHidden = true;

        HiddenObject4.ShowHidden4 = true;
        unlocklevel2G4.ShowHidden = true;
        progresBar.ShowHidden = true;
        checkG4L1int++;
        if (checkG4L1 == checkG4L1int)
        {
            Pointscount.scoreNumber += 5;
            progresBar.num += 7.2f;
        }


    }
    public void Game5level1()
    {
        SceneManager.LoadScene("ARgame");
        showGroup4.ShowHidden = true;

        HiddenObject5.ShowHidden5 = true;
        unlocklevel2G5.ShowHidden = true;
        progresBar.ShowHidden = true;
        checkG5L1int++;
        if (checkG5L1 == checkG5L1int)
        {
            Pointscount.scoreNumber += 5;
            progresBar.num += 7.2f;
        }


    }
    public void Game6level1()
    {
        SceneManager.LoadScene("ARgame");
        showGroup5.ShowHidden = true;

        HiddenObject6.ShowHidden6 = true;
        unlocklevel2G6.ShowHidden = true;
        progresBar.ShowHidden = true;
        checkG6L1int++;
        if (checkG6L1 == checkG6L1int)
        {
            Pointscount.scoreNumber += 5;
            progresBar.num += 7.2f;
        }

    }
}