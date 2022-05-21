using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;




public class SceneSwitcher : MonoBehaviour
{


    public static int checkG1L1 = 1;
    public static int checkG1L1int = 0;

    public static int checkG1L2 = 1;
    public static int checkG1L2int = 0;

    public static int checkG2L1 = 1;
    public static int checkG2L1int = 0;
    public static int checkG2L2 = 1;
    public static int checkG2L2int = 0;

    public static int checkG3L1 = 1;
    public static int checkG3L1int = 0;
    public static int checkG3L2 = 1;
    public static int checkG3L2int = 0;

    public static int checkG4L1 = 1;
    public static int checkG4L1int = 0;
    public static int checkG4L2 = 1;
    public static int checkG4L2int = 0;



    public static int checkG5L1 = 1;
    public static int checkG5L1int = 0;
    public static int checkG5L2 = 1;
    public static int checkG5L2int = 0;
    public GameObject panelout;
    public static int checkG6L1 = 1;
    public static int checkG6L1int = 0;
    public static int checkG6L2 = 1;
    public static int checkG6L2int = 0;
    public bool truevalue = true;
    public static int scoreupdate;
    //public PlayfabManager PlayfabManager1 = new PlayfabManager();
    public void Start()
    {


    }

    public void popUp()
    {
        SceneManager.LoadScene("popUp");
    }  public void ShootArObject()
    {
        SceneManager.LoadScene("ShootArObject");
    }
    public void writeLetter()
    {
        SceneManager.LoadScene("AlphabetMenu");
    }
    public void ScanGame()
    {
        SceneManager.LoadScene("ScanGame");
    }

    public void ARGame()
    {
        Screen.orientation = ScreenOrientation.Portrait;
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
        Screen.orientation = ScreenOrientation.Portrait;

        SceneManager.LoadScene("interface");
    }
    public void DragGameG1L1()
    {
        SceneManager.LoadScene("DragGameG1L1");
        Screen.orientation = ScreenOrientation.Portrait;
        panelScore.scorePanel = PlayfabManager.scoresum + 5;
        if (PlayfabManager.Group1L1value == true)
        {
            panelScore.scorePanel = PlayfabManager.scoresum;
        }
    }
    public void DragGameG1L2()
    {
        SceneManager.LoadScene("DragGameG1L2");
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        panelScore.scorePanel = PlayfabManager.scoresum + 5;
        if (PlayfabManager.Group1L2value == true)
        {
            panelScore.scorePanel = PlayfabManager.scoresum;
        }
    }
    public void DragGameG2L1()
    {
        SceneManager.LoadScene("DragGameG2L1");
        Screen.orientation = ScreenOrientation.Portrait;
        panelScore.scorePanel = PlayfabManager.scoresum + 5;
       
            if (PlayfabManager.Group2L1value == true)
            {
                panelScore.scorePanel = PlayfabManager.scoresum;
            }
        
    }
    public void DragGameG2L2()
    {
        SceneManager.LoadScene("DragGameG2L2");
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        panelScore.scorePanel = PlayfabManager.scoresum + 5;
        if (PlayfabManager.Group2L2value == true)
        {
            panelScore.scorePanel = PlayfabManager.scoresum;
        }
    }
    public void DragGameG3L1()
    {
        SceneManager.LoadScene("DragGameG3L1");
        Screen.orientation = ScreenOrientation.Portrait;
        panelScore.scorePanel = PlayfabManager.scoresum + 5;
        if (PlayfabManager.Group3L1value == true)
        {
            panelScore.scorePanel = PlayfabManager.scoresum;
        }
    }
    public void DragGameG3L2()
    {
        SceneManager.LoadScene("DragGameG3L2");
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        panelScore.scorePanel = PlayfabManager.scoresum + 5;
        if (PlayfabManager.Group3L2value == true)
        {
            panelScore.scorePanel = PlayfabManager.scoresum;
        }
    }
    public void DragGameG4L1()
    {
        SceneManager.LoadScene("DragGameG4L1");
        Screen.orientation = ScreenOrientation.Portrait;
        panelScore.scorePanel = PlayfabManager.scoresum + 5;
        if (PlayfabManager.Group4L1value == true)
        {
            panelScore.scorePanel = PlayfabManager.scoresum;
        }
    }
    public void DragGameG4L2()
    {
        SceneManager.LoadScene("DragGameG4L2");
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        panelScore.scorePanel = PlayfabManager.scoresum + 5;
        if (PlayfabManager.Group4L2value == true)
        {
            panelScore.scorePanel = PlayfabManager.scoresum;
        }
    }
    public void DragGameG5L1()
    {
        SceneManager.LoadScene("DragGameG5L1");
        Screen.orientation = ScreenOrientation.Portrait;
        panelScore.scorePanel = PlayfabManager.scoresum + 5;
        if (PlayfabManager.Group5L1value == true)
        {
            panelScore.scorePanel = PlayfabManager.scoresum;
        }
    }
    public void DragGameG5L2()
    {
        SceneManager.LoadScene("DragGameG5L2");
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        panelScore.scorePanel = PlayfabManager.scoresum + 5;
        if (PlayfabManager.Group5L2value == true)
        {
            panelScore.scorePanel = PlayfabManager.scoresum;
        }
    }
    public void DragGameG6L1()
    {
        SceneManager.LoadScene("DragGameG6L1");
        Screen.orientation = ScreenOrientation.Portrait;
        panelScore.scorePanel = PlayfabManager.scoresum + 5;
        if (PlayfabManager.Group6L1value == true)
        {
            panelScore.scorePanel = PlayfabManager.scoresum;
        }

    }
    public void DragGameG6L2()
    {
        SceneManager.LoadScene("DragGameG6L2");
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        panelScore.scorePanel = PlayfabManager.scoresum + 5;
        if (PlayfabManager.Group6L2value == true)
        {
            panelScore.scorePanel = PlayfabManager.scoresum;
        }

    }

    public void LeaderBoard()
    {
        SceneManager.LoadScene("LeaderBoard");

    }
       public void Shooting()
    {
        SceneManager.LoadScene("Shooting");

    }







    public void signup()
    {
        Screen.orientation = ScreenOrientation.Portrait;

        SceneManager.LoadScene("signup");

    }
    public void Login()
    {
        Screen.orientation = ScreenOrientation.Portrait;

        SceneManager.LoadScene("Login");

    } public void intro()
    {
        Screen.orientation = ScreenOrientation.Portrait;

        SceneManager.LoadScene("Intro");

    }

    public void signout()
    {

        panelout.SetActive(true);
    }


    public void yesout()
    {
        SceneManager.LoadScene("Intro");
        panelout.SetActive(false);

    }
    public void noout()
    {
        panelout.SetActive(false);


    }


    public void playinterface()
    {
        Screen.orientation = ScreenOrientation.Portrait;


        SceneManager.LoadScene("PlayInterface");

    }




    public void alanoudGame()
    {
        Screen.orientation = ScreenOrientation.Portrait;

        SceneManager.LoadScene("alanoudGame");

    }
    public void AlphabetWriting()
    {
        Screen.orientation = ScreenOrientation.Portrait;

        SceneManager.LoadScene("AlphabetWriting");

    }

    /*
    public void Game1level1()
    {
        SceneManager.LoadScene("ARgame");
        showGroup.ShowHidden = true;
      //  PlayfabManager1.Group1L1 = truevalue;
        //  HiddenObject.ShowHidden = true;
        // unlocklevel2.ShowHidden = true;
        //   progresBar.ShowHidden = true;
        checkG1L1int++;

        if (checkG1L1 == checkG1L1int)
        {
            // scoreupdate = 5;
            //  PlayfabManager1.scoreNumber = scoreupdate;
            PlayfabManager1.Update();
            PlayfabManager1.SaveLevelG1L1();



            //progresBar.num += 7.2f;

            //Starcount.numG1 += 50.0f;
        }
    }
    public void Game1level2()
    {
        SceneManager.LoadScene("ARgame");
        showGroup.ShowHidden = true;
      //  PlayfabManager1.Group1L2 = true;
        //  PlayfabManager1.Group1L1 = true;
        //  HiddenObject1.ShowHidden1 = true;
        unlocklevel3.ShowHidden = true;
        // progresBar.ShowHidden = true;
        checkG1L2int++;

        if (checkG1L2 == checkG1L2int)
        {
            //   scoreupdate = 5;
            //   PlayfabManager1.scoreNumber = scoreupdate;



            PlayfabManager1.Update();
            PlayfabManager1.SaveLevelG1L2();
            //progresBar.num += 7.2f;
            //  Starcount.numG1 += 50.0f;

        }

    }
    public void Game2level1()
    {
        SceneManager.LoadScene("ARgame");
        showGroup1.ShowHidden = true;
// PlayfabManager1.Group2L1 = true;

        //  HiddenObject2.ShowHidden2 = true;
        //  progresBar.ShowHidden = true;
        checkG2L1int++;
        if (checkG2L1 == checkG2L1int)
        {
            PlayfabManager1.Update();
            PlayfabManager1.SaveLevelG2L1();
            // scoreupdate = 5;
            //    PlayfabManager1.scoreNumber = scoreupdate;
            //   PlayfabManager1.Update();
            // PlayfabManager.scoreNumber += 5;
            //    progresBar.num += 7.2f;
            //   Starcount.numG2 += 50.0f;

        }

    }
    public void Game2level2()
    {
        SceneManager.LoadScene("ARgame");
        showGroup1.ShowHidden = true;
       // PlayfabManager1.Group2L2 = true;

        // HiddenObject1.ShowHidden1 = true;
        //  progresBar.ShowHidden = true;
        checkG2L2int++;

        if (checkG2L2 == checkG2L2int)
        {
            // scoreupdate = 5;
            //PlayfabManager1.scoreNumber = scoreupdate;
            //  PlayfabManager1.Update();
            //   PlayfabManager.scoreNumber += 5;
            //   progresBar.num += 7.2f;
            //   Starcount.numG2 += 50.0f;
            PlayfabManager1.Update();
            PlayfabManager1.SaveLevelG2L2();
        }

    }


    public void Game3level1()
    {
        SceneManager.LoadScene("ARgame");
        showGroup2.ShowHidden = true;
      //  PlayfabManager1.Group3L1 = true;

        HiddenObject3.ShowHidden3 = true;
        progresBar.ShowHidden = true;
        checkG3L1int++;
        if (checkG3L1 == checkG3L1int)
        {
            //  PlayfabManager.scoreNumber += 5;
            // progresBar.num += 7.2f;
            // Starcount.numG3 += 50.0f;
            // scoreupdate = 5;
            // PlayfabManager1.scoreNumber = scoreupdate;
            // PlayfabManager1.Update();
            PlayfabManager1.Update();
            PlayfabManager1.SaveLevelG3L1();
        }


    }
    public void Game3level2()
    {
        SceneManager.LoadScene("ARgame");
        showGroup.ShowHidden = true;
       // PlayfabManager1.Group3L2 = true;

        HiddenObject1.ShowHidden1 = true;
        progresBar.ShowHidden = true;
        checkG3L2int++;

        if (checkG3L2 == checkG3L2int)
        {
            // PlayfabManager.scoreNumber += 5;
            // progresBar.num += 7.2f;
            // Starcount.numG3 += 50.0f;
            // scoreupdate = 5;
            // PlayfabManager1.scoreNumber = scoreupdate;
            // PlayfabManager1.Update();
            PlayfabManager1.Update();
            PlayfabManager1.SaveLevelG3L2();
        }

    }






    public void Game4level1()
    {
        SceneManager.LoadScene("ARgame");
        showGroup3.ShowHidden = true;
        //PlayfabManager1.Group4L1 = true;

        HiddenObject4.ShowHidden4 = true;
        progresBar.ShowHidden = true;
        checkG4L1int++;
        if (checkG4L1 == checkG4L1int)
        {
            //   PlayfabManager.scoreNumber += 5;
            //   progresBar.num += 7.2f;
            // Starcount.numG4 += 50.0f;
            // scoreupdate = 5;
            // PlayfabManager1.scoreNumber = scoreupdate;
            //  PlayfabManager1.Update();
            PlayfabManager1.Update();
            PlayfabManager1.SaveLevelG4L1();
        }


    }

    public void Game4level2()
    {
        SceneManager.LoadScene("ARgame");
        showGroup.ShowHidden = true;
        PlayfabManager.Group4L2 = true;

        HiddenObject1.ShowHidden1 = true;
        progresBar.ShowHidden = true;
        checkG4L2int++;

        if (checkG4L2 == checkG4L2int)
        {
            //PlayfabManager.scoreNumber += 5;
            //   progresBar.num += 7.2f;
            //  Starcount.numG4 += 50.0f;
            //  scoreupdate = 5;
            //  PlayfabManager1.scoreNumber = scoreupdate;
            //  PlayfabManager1.Update();
            PlayfabManager.Update();
            PlayfabManager.SaveLevelG4L2();
        }

    }



    public void Game5level1()
    {
        SceneManager.LoadScene("ARgame");
        showGroup4.ShowHidden = true;
        PlayfabManager.Group5L1 = true;

        HiddenObject5.ShowHidden5 = true;

        progresBar.ShowHidden = true;
        checkG5L1int++;
        if (checkG5L1 == checkG5L1int)
        {
            //   PlayfabManager.scoreNumber += 5;
            //     progresBar.num += 7.2f;
            //  Starcount.numG5 += 50.0f;
            // scoreupdate = 5;
            // PlayfabManager1.scoreNumber = scoreupdate;
            // PlayfabManager1.Update();
            PlayfabManager.Update();
            PlayfabManager.SaveLevelG5L1();
        }


    }


    public void Game5level2()
    {
        SceneManager.LoadScene("ARgame");
        showGroup.ShowHidden = true;
        PlayfabManager.Group5L2 = true;

        HiddenObject1.ShowHidden1 = true;
        progresBar.ShowHidden = true;
        checkG5L2int++;

        if (checkG5L2 == checkG5L2int)
        {
            // PlayfabManager.scoreNumber += 5;
            //progresBar.num += 7.2f;
            //  Starcount.numG5 += 50.0f;
            // scoreupdate = 5;
            // PlayfabManager1.scoreNumber = scoreupdate;
            // PlayfabManager1.Update();
            PlayfabManager.Update();
            PlayfabManager.SaveLevelG5L2();
        }

    }

    public void Game6level1()
    {
        SceneManager.LoadScene("ARgame");
        showGroup5.ShowHidden = true;
          PlayfabManager.Group6L1 = true;

        HiddenObject6.ShowHidden6 = true;
        unlocklevel2G6.ShowHidden = true;
        progresBar.ShowHidden = true;
        checkG6L1int++;
        if (checkG6L1 == checkG6L1int)
        {
            // PlayfabManager.scoreNumber += 5;
            // progresBar.num += 7.2f;
            //Starcount.numG6 += 50.0f;
            //  scoreupdate = 5;
            // PlayfabManager1.scoreNumber = scoreupdate;
            // PlayfabManager1.Update();
            PlayfabManager.Update();
            PlayfabManager.SaveLevelG6L1();
        }

    }

    public void Game6level2()
    {
        SceneManager.LoadScene("ARgame");
        showGroup.ShowHidden = true;
        PlayfabManager.Group6L2 = true;

        HiddenObject1.ShowHidden1 = true;
        progresBar.ShowHidden = true;
        checkG6L2int++;

        if (checkG6L2 == checkG6L2int)
        {
            // PlayfabManager.scoreNumber += 5;
            progresBar.num += 7.2f;
            Starcount.numG6 += 50.0f;
            //  scoreupdate = 5;
            // PlayfabManager1.scoreNumber = scoreupdate;
            //  PlayfabManager1.Update();
            PlayfabManager.Update();
            PlayfabManager.SaveLevelG6L2();
        }

    }*/

}