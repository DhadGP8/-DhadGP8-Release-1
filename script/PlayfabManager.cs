using System.Collections;

using System.Collections.Generic;

using UnityEngine;

using PlayFab;

using PlayFab.ClientModels;

using UnityEngine.UI;
using System.Linq;

using UnityEngine.SceneManagement;

using System.Text.RegularExpressions;

public class PlayfabManager : MonoBehaviour

{

    [Header("UI")]
    public Toggle boy;
    public Toggle girle;
    public Text namemaa;
    public string nameget;
    public Text messageText;
    public Text errorinfo;
    public Text positiontext;
    public string positioostring;
    //public string getpositiontext;
    public GameObject posionpanel;

    public Text helloText;
    public string nameText;
    public string gender;
    public GameObject DisplayText;
    public GameObject input;
    public static int scoreNumber;
    public static int scoreint;
    public static int scoresum = 0;
    public static int ARscore;
    public static int ARscoretosend;
    public string score;
    public string getscore;
    public Text scoretext;
    public InputField nameInput;
    public InputField age;
    public GameObject infoCanvase;
    public InputField emailInput;
    public InputField passwordInput;
    public InputField cpasswordInput;
    public bool Group1L1;
    public static bool Group1L1value;
    public static int scoreupdate;
    public bool Group1L2;
    public static bool Group1L2value;
    public bool Group2L1;
    public static bool Group2L1value;
    public bool Group2L2;
    public static bool Group2L2value;
    public bool Group3L1;
    public static bool Group3L1value;
    public bool Group3L2;
    public static bool Group3L2value;
    public bool Group4L1;
    public static bool Group4L1value;
    public bool Group4L2;
    public static bool Group4L2value;
    public bool Group5L1;
    public static bool Group5L1value;
    public bool Group5L2;
    public static bool Group5L2value;
    public bool Group6L1;
    public static bool Group6L1value;
    public bool Group6L2;
    public static bool Group6L2value;
    public static int stopGroup1L1 = 0;
    public static int stopGroup1L2 = 0;
    public static int stopGroup2L1 = 0;
    public static int stopGroup2L2 = 0;
    public static int stopGroup3L1 = 0;
    public static int stopGroup3L2 = 0;
    public static int stopGroup4L1 = 0;
    public static int stopGroup4L2 = 0;
    public static int stopGroup5L1 = 0;
    public static int stopGroup5L2 = 0;
    public static int stopGroup6L1 = 0;
    public static int stopGroup6L2 = 0;
    public static int G1L1Opend = 0;
    public static int G1L2Opend = 0;
    public static int G2L1Opend = 0;
    public static int G2L2Opend = 0;
    public GameObject rowPrefab;
    public Transform rowsParent;
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
    public static string loggedInplayfabID;
    public static bool imInAR; 

    public static int checkG5L1 = 1;
    public static int checkG5L1int = 0;
    public static int checkG5L2 = 1;
    public static int checkG5L2int = 0;
    public static int checkARones;
    public static int checkG6L1 = 1;
    public static int checkG6L1int = 0;
    public static int checkG6L2 = 1;
    public static int checkG6L2int = 0;
    public static bool goo;
    public static bool fishAR;
    public static PlayfabManager GameInstance;
    private PlayfabManager()
   {
     GameInstance = this;
    }
    public void Start()
    {
        //scoresum = 0;

    }
    public void Update()
    {
        //scoreNumber = 11;
        //  score = scoreNumber.ToString();
        Debug.Log("successful AR "+ ARscore);
        //scoreint += scoreNumber;
        //score = scoreint.ToString();


        ubdategroup();
        // Savescore();


    }
    public void signout()
    {

        PlayFabClientAPI.ForgetAllCredentials();
        Pointscount.scoreTextS = "0";
        panelScore.scorePanel = 0;
        panelScore.scorePanel = 0;
        progresBar.num = 0;
        Starcount.numG1 = 0;
        Starcount.numG2 = 0;
        Starcount.numG3 = 0;
        Starcount.numG4 = 0;
        Starcount.numG5 = 0;
        Starcount.numG6 = 0;
        stopGroup1L1 = 0;
        stopGroup1L2 = 0;
        stopGroup2L1 = 0;
        stopGroup2L2 = 0;
        stopGroup3L1 = 0;
        stopGroup3L2 = 0;
        stopGroup4L1 = 0;
        stopGroup4L2 = 0;
        stopGroup5L1 = 0;
        stopGroup5L2 = 0;
        stopGroup6L1 = 0;
        stopGroup6L2 = 0;
        checkG1L1int = 0;
        checkG1L2int = 0;
        checkG2L2int = 0;
        checkG2L1int = 0;
        checkG3L2int = 0;
        checkG3L1int = 0;
        checkG4L2int = 0;
        checkG4L1int = 0;
        checkG5L2int = 0;
        checkG5L1int = 0;
        checkG6L2int = 0;
        checkG6L1int = 0;
        Group1L1value = false;
        Group1L2value = false;
        Group2L1value = false;
        Group2L2value = false;
        Group3L1value = false;
        Group3L2value = false;
        Group4L1value = false;
        Group4L2value = false;
        Group5L1value = false;
        Group5L2value = false;
        Group6L1value = false;
        Group6L2value = false;
        scoresum = 0;
        unlocklevel2.ShowHidden = false;
        unlocklevel2G3.ShowHidden = false;
        unlocklevel2G2.ShowHidden = false;
        unlocklevel2G4.ShowHidden = false;
        unlocklevel2G5.ShowHidden = false;
        unlocklevel2G6.ShowHidden = false;


    }

    public void leaderboard()
    {



        // SendLeaderboard(scoresum);

        //  GetLeaderboard();
    }
    public void getpositiontext(string position)
    {

        positiontext.text = position;
    }
    public void finesh()
    {
       
        SaveAR();


        GetLeaderboard();
       

        posionpanel.SetActive(true);



    }
    public void fishposition()
    {
        SceneManager.LoadScene("PlayInterface");
        posionpanel.SetActive(false);
        Explode.scoreNumber = 0;
        imInAR = false;
    }
    public void IfArCLICK()
    {

        imInAR = true;
        ARscore++;
        SendLeaderboard(ARscore);
        GetLeaderboard();
        Debug.Log("imInAR="+ imInAR);

    }
    public void ifshootcklic()
    {


       if(Explode.higetit == true)
        {
            imInAR = true;
            ARscore++;
            SendLeaderboard(ARscore);
            GetLeaderboard();
            Debug.Log("im in shooting" );
            Explode.higetit = false;
        }
    }
    public void ubdategroup()
    {
    
        if (stopGroup1L1 == 0)
        {
            if (Group1L1value == true)
            {
                Debug.Log("i'm in g1l1");
                stopGroup1L1++;
                progresBar.num += 8.33f;
                Starcount.numG1 += 50.0f;

                unlocklevel2.ShowHidden = true;
                progresBar.ShowHidden = true;
                // scoreupdate = 5;
                //  scoreNumber += 5;
              //  panelScore.scorePanel += 5;
               scoresum += 5;
                Savescore();

            }
        }


        if (stopGroup1L2 == 0)
        {
            if (Group1L2value == true)
            {
                progresBar.ShowHidden = true;
                stopGroup1L2++;
                // scoreupdate = 5;
                // scoreNumber += 5;
                progresBar.num += 8.33f;
                Starcount.numG1 += 50.0f;
                //panelScore.scorePanel += 5;

                scoresum += 5;
                Savescore();

            }
        }

        if (stopGroup2L1 == 0)
        {

            if (Group2L1value == true)
            {
                unlocklevel2G2.ShowHidden = true;
                stopGroup2L1++;
                progresBar.ShowHidden = true;

                progresBar.num += 8.33f;
                Starcount.numG2 += 50.0f;
               // panelScore.scorePanel += 5;

                scoresum += 5;
                Savescore();

            }
        }

        if (stopGroup2L2 == 0)
        {
            if (Group2L2value == true)
            {
                stopGroup2L2++;

                progresBar.num += 8.33f;
                Starcount.numG2 += 50.0f;
             //   panelScore.scorePanel += 5;

                scoresum += 5;
                Savescore();

            }
        }

        if (stopGroup3L1 == 0)
        {
            if (Group3L1value == true)
            {
                unlocklevel2G3.ShowHidden = true;
                stopGroup3L1++;
                progresBar.num += 8.33f;
                Starcount.numG3 += 50.0f;
               // panelScore.scorePanel += 5;

                scoresum += 5;
                Savescore();

            }

        }
        if (stopGroup3L2 == 0)
        {

            if (Group3L2value == true)
            {
                stopGroup3L2++;
                progresBar.num += 8.33f;
                Starcount.numG3 += 50.0f;
              //  panelScore.scorePanel += 5;

                scoresum += 5;
                Savescore();

            }
        }


        if (stopGroup4L1 == 0)
        {

            if (Group4L1value == true)
            {
                unlocklevel2G4.ShowHidden = true;
                stopGroup4L1++;
                progresBar.num += 8.33f;
                Starcount.numG4 += 50.0f;
               // panelScore.scorePanel += 5;

                scoresum += 5;
                Savescore();


            }
        }

        if (stopGroup4L2 == 0)
        {

            if (Group4L2value == true)
            {
                stopGroup4L2++;
                progresBar.num += 8.33f;
                Starcount.numG4 += 50.0f;
               // panelScore.scorePanel += 5;

                scoresum += 5;
                Savescore();


            }
        }

        if (stopGroup5L1 == 0)
        {
            if (Group5L1value == true)
            {
                stopGroup5L1++;
                unlocklevel2G5.ShowHidden = true;
                progresBar.num += 8.33f;
                Starcount.numG5 += 50.0f;
               // panelScore.scorePanel += 5;

                scoresum += 5;
                Savescore();


            }
        }

        if (stopGroup5L2 == 0)
        {
            if (Group5L2value == true)
            {
                stopGroup5L2++;
                progresBar.num += 8.33f;
                Starcount.numG5 += 50.0f;
             //   panelScore.scorePanel += 5;

                scoresum += 5;
                Savescore();

            }
        }


        if (stopGroup6L1 == 0)
        {

            if (Group6L1value == true)
            {
                unlocklevel2G6.ShowHidden = true;
                stopGroup6L1++;
                progresBar.num += 8.33f;
                Starcount.numG6 += 50.0f;
               // panelScore.scorePanel += 5;

                scoresum += 5;
                Savescore();

            }
        }


        if (stopGroup6L2 == 0)
        {

            if (Group6L2value == true)
            {
                stopGroup6L2++;
                progresBar.num += 8.33f;
                Starcount.numG6 += 50.0f;
              //  panelScore.scorePanel += 5;

                scoresum += 5;
                Savescore();


            }
        }







        if (panelScore.scorePanel == 65)
        {
            panelScore.scorePanel = 60;
        }











    }

    public void RegisterButton()
    {

        if (passwordInput.text.Length < 8)
        {

            messageText.text = "  ﺯﻮﻣﺭ  8 ﻰﻠﻋ ﺭﻭﺮﻤﻟﺍ ﺔﻤﻠﻛ ﻱﻮﺘﺤﺗ ﻥﺃ ﺐﺠﻳ";

            return;

        }


        if (passwordInput.text != cpasswordInput.text)
        {

            messageText.text = " ﻪﻘﺑﺎﻄﺘﻣ ﺭﻭﺮﻤﻟﺍ ﺕﺎﻤﻠﻛ ﻥأ ﻦﻣ ﺪﻛﺄﺗ";

            return;
        }

        Regex email = new Regex(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\.)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
           RegexOptions.CultureInvariant | RegexOptions.Singleline);

        if (!email.IsMatch(emailInput.text))
        {
            messageText.text = "  ﺢﻴﺤﺻ ﺮﻴﻏ ﻲﻧﻭﺮﺘﻜﻟﻹﺍ ﺪﻳﺮﺒﻟﺍ ";
            return;
        }

        //pattern to find if there is any special character in string
        Regex alphaNumeric = new Regex("^[a-zA-Z0-9]*$");






        var request = new RegisterPlayFabUserRequest
        {


            Email = emailInput.text,

            Password = passwordInput.text,

            RequireBothUsernameAndEmail = false,
        };

        PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnError);
    }



    void OnRegisterSuccess(RegisterPlayFabUserResult result)
    {
        Pointscount.scoreTextS = "0";
        panelScore.scorePanel = 0;
        panelScore.scorePanel = 0;
        progresBar.num = 0;
        Starcount.numG1 = 0;
        Starcount.numG2 = 0;
        Starcount.numG3 = 0;
        Starcount.numG4 = 0;
        Starcount.numG5 = 0;
        Starcount.numG6 = 0;
        stopGroup1L1 = 0;
        stopGroup1L2 = 0;
        stopGroup2L1 = 0;
        stopGroup2L2 = 0;
        stopGroup3L1 = 0;
        stopGroup3L2 = 0;
        stopGroup4L1 = 0;
        stopGroup4L2 = 0;
        stopGroup5L1 = 0;
        stopGroup5L2 = 0;
        stopGroup6L1 = 0;
        stopGroup6L2 = 0;
        checkG1L1int = 0;
        checkG1L2int = 0;
        checkG2L2int = 0;
        checkG2L1int = 0;
        checkG3L2int = 0;
        checkG3L1int = 0;
        checkG4L2int = 0;
        checkG4L1int = 0;
        checkG5L2int = 0;
        checkG5L1int = 0;
        checkG6L2int = 0;
        checkG6L1int = 0;
        Group1L1value = false;
        Group1L2value = false;
        Group2L1value = false;
        Group2L2value = false;
        Group3L1value = false;
        Group3L2value = false;
        Group4L1value = false;
        Group4L2value = false;
        Group5L1value = false;
        Group5L2value = false;
        Group6L1value = false;
        Group6L2value = false;
        scoresum = 0;
        ubdategroup();

        // panelScore.scorePanel = 5;
        loggedInplayfabID = result.PlayFabId;

        messageText.text = "Registered and logged in !";
        infoCanvase.SetActive(true);

        OnSuccess();
        //Save();


    }
    public void GetsavedInfo()
    {
        PlayFabClientAPI.GetUserData(new GetUserDataRequest(), OnDataRecieved, OnError);


    }
    public void OnDataRecieved(GetUserDataResult result)
    {

        Debug.Log("successful recifed");
        if (result.Data.ContainsKey("user"))
        {

            GetInfo.getName = result.Data["user"].Value;
            Debug.Log("Name is found");


            SubmitNameButton(result.Data["user"].Value);

            // SubmitNameButton();
            // GetLeaderboard();

        }
        if (result.Data.ContainsKey("age"))
        {

            GetInfo.getage = result.Data["age"].Value;
            Debug.Log("age is found");

        }
        if (result.Data.ContainsKey("gender"))
        {

            GetInfo.getgender = result.Data["gender"].Value;
            Debug.Log("gender is found");

        }      if (result.Data.ContainsKey("ARscore"))
        {
            if (checkARones == 0)
            {
                checkARones++;
                ARscore = int.Parse(result.Data["ARscore"].Value);
            }
        }

        if (result.Data.ContainsKey("userscore"))
        {

            Pointscount.scoreTextS = scoresum.ToString();
            Debug.Log("score is found ");

        }

        if (result.Data.ContainsKey("Group1L1"))
        {
            Group1L1value = bool.Parse(result.Data["Group1L1"].Value);

            Debug.Log("Group1L1");

            ubdategroup();
        }

        if (result.Data.ContainsKey("Group2L1"))
        {
            Debug.Log("Group2L1");
            Group2L1value = bool.Parse(result.Data["Group2L1"].Value);
            ubdategroup();
        }
        if (result.Data.ContainsKey("Group3L1"))
        {
            Debug.Log("Group3L1");
            Group3L1value = bool.Parse(result.Data["Group3L1"].Value);
            ubdategroup();
        }
        if (result.Data.ContainsKey("Group4L1"))
        {
            Debug.Log("Group4L1");
            Group4L1value = bool.Parse(result.Data["Group4L1"].Value);
            ubdategroup();
        }
        if (result.Data.ContainsKey("Group5L1"))
        {
            Debug.Log("Group5L1");
            Group5L1value = bool.Parse(result.Data["Group5L1"].Value);
            ubdategroup();
        }

        if (result.Data.ContainsKey("Group6L1"))
        {
            Debug.Log("Group6L1");
            Group6L1value = bool.Parse(result.Data["Group6L1"].Value);
            ubdategroup();
        }
        if (result.Data.ContainsKey("Group1L2"))
        {

            Group1L2value = bool.Parse(result.Data["Group1L2"].Value);
            ubdategroup();
        }

        if (result.Data.ContainsKey("Group2L2"))
        {

            Group2L2value = bool.Parse(result.Data["Group2L2"].Value);
            ubdategroup();
        }
        if (result.Data.ContainsKey("Group3L2"))
        {

            Group3L2value = bool.Parse(result.Data["Group3L2"].Value);
            ubdategroup();
        }
        if (result.Data.ContainsKey("Group4L2"))
        {

            Group4L2value = bool.Parse(result.Data["Group4L2"].Value);
            ubdategroup();
        }
        if (result.Data.ContainsKey("Group5L2"))
        {

            Group5L2value = bool.Parse(result.Data["Group5L2"].Value);
            ubdategroup();
        }
        if (result.Data.ContainsKey("Group6L2"))
        {

            Group6L2value = bool.Parse(result.Data["Group6L2"].Value);
            ubdategroup();
        }


        return;
    }



    public void Save()

    {

        var request = new UpdateUserDataRequest
        {
            Data = new Dictionary<string, string>{
                {"user", nameInput.text }
            }
        };
       

        PlayFabClientAPI.GetUserData(new GetUserDataRequest(), OnDataRecieved, OnError);

        PlayFabClientAPI.UpdateUserData(request, OnDataSend, OnError);
    }
    public void SaveAR()

    {

        var request = new UpdateUserDataRequest
        {
            Data = new Dictionary<string, string>{
                {"ARscore", ARscore.ToString() }
            }
        };

        PlayFabClientAPI.GetUserData(new GetUserDataRequest(), OnDataRecieved, OnError);

        PlayFabClientAPI.UpdateUserData(request, OnDataSend, OnError);
    }
    public void SaveAge()

    {

        var request = new UpdateUserDataRequest
        {
            Data = new Dictionary<string, string>{
               {"age",age.text },
                {"gender",gender }

            }
        };

        PlayFabClientAPI.GetUserData(new GetUserDataRequest(), OnDataRecieved, OnError);

        PlayFabClientAPI.UpdateUserData(request, OnDataSend, OnError);
    }
    public void Savescore()

    {

        var request = new UpdateUserDataRequest
        {
            Data = new Dictionary<string, string>{
                 {"userscore", scoresum.ToString() }
            }
        };

        PlayFabClientAPI.GetUserData(new GetUserDataRequest(), OnDataRecieved, OnError);

        PlayFabClientAPI.UpdateUserData(request, OnDataSend, OnError);
    }
    public void SaveLevelG1L1()

    {

        var request = new UpdateUserDataRequest
        {
            Data = new Dictionary<string, string>{
                 {"Group1L1", Group1L1.ToString() }


            }
        };
        G1L1Opend++;
        PlayFabClientAPI.GetUserData(new GetUserDataRequest(), OnDataRecieved, OnError);

        PlayFabClientAPI.UpdateUserData(request, OnDataSend, OnError);
    }
    public void SaveLevelG1L2()

    {

        var request = new UpdateUserDataRequest
        {
            Data = new Dictionary<string, string>{
                 {"Group1L2", Group1L2.ToString() }


            }
        };
        G1L2Opend++;

        PlayFabClientAPI.GetUserData(new GetUserDataRequest(), OnDataRecieved, OnError);

        PlayFabClientAPI.UpdateUserData(request, OnDataSend, OnError);
    }
    public void SaveLevelG2L1()

    {

        var request = new UpdateUserDataRequest
        {
            Data = new Dictionary<string, string>{
                 {"Group2L1", Group2L1.ToString() }


            }
        };
        G2L1Opend++;

        PlayFabClientAPI.GetUserData(new GetUserDataRequest(), OnDataRecieved, OnError);

        PlayFabClientAPI.UpdateUserData(request, OnDataSend, OnError);
    }
    public void SaveLevelG2L2()

    {

        var request = new UpdateUserDataRequest
        {
            Data = new Dictionary<string, string>{
                 {"Group2L2", Group2L2.ToString() }


            }
        };
        G2L2Opend++;

        PlayFabClientAPI.GetUserData(new GetUserDataRequest(), OnDataRecieved, OnError);

        PlayFabClientAPI.UpdateUserData(request, OnDataSend, OnError);
    }
    public void SaveLevelG3L1()

    {

        var request = new UpdateUserDataRequest
        {
            Data = new Dictionary<string, string>{
                 {"Group3L1", Group3L1.ToString() }


            }
        };


        PlayFabClientAPI.GetUserData(new GetUserDataRequest(), OnDataRecieved, OnError);

        PlayFabClientAPI.UpdateUserData(request, OnDataSend, OnError);
    }
    public void SaveLevelG3L2()

    {

        var request = new UpdateUserDataRequest
        {
            Data = new Dictionary<string, string>{
                 {"Group3L2", Group3L2.ToString() }


            }
        };


        PlayFabClientAPI.GetUserData(new GetUserDataRequest(), OnDataRecieved, OnError);

        PlayFabClientAPI.UpdateUserData(request, OnDataSend, OnError);
    }
    public void SaveLevelG4L1()

    {

        var request = new UpdateUserDataRequest
        {
            Data = new Dictionary<string, string>{
                 {"Group4L1", Group4L1.ToString() }


            }
        };


        PlayFabClientAPI.GetUserData(new GetUserDataRequest(), OnDataRecieved, OnError);

        PlayFabClientAPI.UpdateUserData(request, OnDataSend, OnError);
    }


    public void SaveLevelG4L2()

    {

        var request = new UpdateUserDataRequest
        {
            Data = new Dictionary<string, string>{
                 {"Group4L2", Group4L2.ToString() }


            }
        };


        PlayFabClientAPI.GetUserData(new GetUserDataRequest(), OnDataRecieved, OnError);

        PlayFabClientAPI.UpdateUserData(request, OnDataSend, OnError);
    }


    public void SaveLevelG5L1()

    {

        var request = new UpdateUserDataRequest
        {
            Data = new Dictionary<string, string>{
                 {"Group5L1", Group5L1.ToString() }


            }
        };


        PlayFabClientAPI.GetUserData(new GetUserDataRequest(), OnDataRecieved, OnError);

        PlayFabClientAPI.UpdateUserData(request, OnDataSend, OnError);
    }
    public void SaveLevelG5L2()

    {

        var request = new UpdateUserDataRequest
        {
            Data = new Dictionary<string, string>{
                 {"Group5L2", Group5L2.ToString() }


            }
        };


        PlayFabClientAPI.GetUserData(new GetUserDataRequest(), OnDataRecieved, OnError);

        PlayFabClientAPI.UpdateUserData(request, OnDataSend, OnError);
    }
    public void SaveLevelG6L1()

    {

        var request = new UpdateUserDataRequest
        {
            Data = new Dictionary<string, string>{
                 {"Group6L1", Group6L1.ToString() }


            }
        };


        PlayFabClientAPI.GetUserData(new GetUserDataRequest(), OnDataRecieved, OnError);

        PlayFabClientAPI.UpdateUserData(request, OnDataSend, OnError);
    }
    public void SaveLevelG6L2()

    {

        var request = new UpdateUserDataRequest
        {
            Data = new Dictionary<string, string>{
                 {"Group6L2", Group6L2.ToString() }


            }
        };


        PlayFabClientAPI.GetUserData(new GetUserDataRequest(), OnDataRecieved, OnError);

        PlayFabClientAPI.UpdateUserData(request, OnDataSend, OnError);
    }
    bool IsNumber(string text)
    {
        Regex regex = new Regex(@"^[-+]?[0-9]*\.?[0-9]+$");
        return regex.IsMatch(text);
    }

    public void getgender()
    {
        if (nameInput.text != "" )
        {
            Save();
            if (age.text != "")
            {
                if (IsNumber(age.text))
                {
                   
                    home();

                    if (boy.isOn)
                    {
                        Debug.Log("you select boy ");
                        gender = "boy";
                        SaveAge();


                    }
                    if (girle.isOn)
                    {
                        Debug.Log("you select girle ");
                        gender = "girle";
                        SaveAge();

                    }
                }
                else
                {
                    errorinfo.text = " ﻂﻘﻓ ﻡﺎﻗﺭﺍ ﻰﻠﻋ ﺮﻤﻌﻟﺍ ﻱﻮﺘﺤﻳ ﻥﺍ ﺐﺠﻳ";
                    return;

                }
            }
            else
            {
                errorinfo.text = "  ﻝﻮﻘﺤﻟﺍ ﻊﻴﻤﺟ ﺀﻞﻣ ﺐﺠﻳ";
                return;
            }
        }
        else
        {

            errorinfo.text = "  ﻝﻮﻘﺤﻟﺍ ﻊﻴﻤﺟ ﺀﻞﻣ ﺐﺠﻳ";
            return;


        }
    }







    //toggleGroup = GetComponent<ToggleGroup>();
    // Toggle toggle = toggleGroup.ActiveToggles().FirstOrDefault();
    // Debug.Log(toggle.name + " _ " + toggle.GetComponentInChildren<Text>().text);

















    void OnDataSend(UpdateUserDataResult result)
    {
        Debug.Log("successful Save");

        GetsavedInfo();
    }





    public void home()
    {
        SceneManager.LoadScene("interface");
        // scoresum += scoreint;

    }


    public void LoginButton()
    {

        var request = new LoginWithEmailAddressRequest
        {

            Email = emailInput.text,

            Password = passwordInput.text,
            //  InfoRequestParameters=new GetPlayerCominedInfoRequestParams

            //GetPlayerProfile=true
            InfoRequestParameters = new GetPlayerCombinedInfoRequestParams
            {
                GetPlayerProfile = true


            }

        };

        PlayFabClientAPI.LoginWithEmailAddress(request, OnLoginSuccess, OnErrorlogin);
    }



    public void ResetButton()
    {

        var request = new SendAccountRecoveryEmailRequest
        {

            Email = emailInput.text,
            TitleId = "1FFCB"
        };

        PlayFabClientAPI.SendAccountRecoveryEmail(request, OnPasswordReset, OnError);

    }
    public void SubmitNameButton( string name)
    {
        var request = new UpdateUserTitleDisplayNameRequest
        {
            DisplayName = name,

        };
        PlayFabClientAPI.UpdateUserTitleDisplayName(request, OnDisplayNameUpdate, OnError);

    }




    void OnDisplayNameUpdate(UpdateUserTitleDisplayNameResult result)
    {

        Debug.Log("Namesend to leaderBoard");


    }




    public void OnPasswordReset(SendAccountRecoveryEmailResult result)
    {

        messageText.text = " ﻲﻧﻭﺮﺘﻜﻟﻹﺍ ﻙﺪﻳﺮﺒﻟ ﺭﻭﺮﻤﻟﺍ ﺔﻤﻠﻛ ﻦﻴﻴﻌﺗ ﺓﺩﺎﻋﺍ ﻂﺑﺍﺭ ﻝﺎﺳﺭﺍ ﻢﺗ";
    }


    void OnLoginSuccess(LoginResult result)
    {
        

        loggedInplayfabID = result.PlayFabId;
        messageText.text = "Logged in !";
        GetsavedInfo();
        home();
        Debug.Log("Success login/account create!");
       // string name = null;
      //  if (result.InfoResultPayload.PlayerProfile != null)
      //  {
        //    name = result.InfoResultPayload.PlayerProfile.DisplayName;
        //}
    }

    void OnErrorlogin(PlayFabError error)
    {


        messageText.text = "  ﺢﻴﺤﺻ ﺮﻴﻏ ﻪﻟﺎﺧﺩﺇ ﻢﺗ ﻱﺬﻟﺍ ﺭﻭﺮﻤﻟﺍ ﺔﻤﻠﻛ/ﻲﻧﻭﺮﺘﻜﻟﻹﺍ ﺪﻳﺮﺒﻟﺍ ";

        //messageText.text =error.ErrorMessage; 

        Debug.Log(error.GenerateErrorReport());

    }
    void OnError(PlayFabError error)
    {



        messageText.text =error.ErrorMessage; 

        Debug.Log(error.GenerateErrorReport());

    }
    public void OnSuccess()
    {

        //  nameText = input.GetComponent<Text>().text;
        //    DisplayText.GetComponent<Text>().text="Welcome"+nameText+"to our System";
    }


    public void SendLeaderboard(int score)
    {
        Debug.Log("ar score inside the method"+ score);
        var request = new UpdatePlayerStatisticsRequest
        {

            Statistics = new List<StatisticUpdate>
            {
                new StatisticUpdate{
                    StatisticName="leader",
                    Value=score

                }
            }
        };
        PlayFabClientAPI.UpdatePlayerStatistics(request, OnLeaderboardUpdate, OnError);

    }
    void OnLeaderboardUpdate(UpdatePlayerStatisticsResult result)
    {

        Debug.Log("SendLeaderboard is doooone");
        GetLeaderboard();
    }
    public void GetLeaderboard()
    {
        Debug.Log("SendLeaderboard is shows");


        var request = new GetLeaderboardRequest
        {
            StatisticName = "leader",
            StartPosition = 0,
            MaxResultsCount = 100
        };
        PlayFabClientAPI.GetLeaderboard(request, OnLeaderboardGet, OnError);

    }
    void OnLeaderboardGet(GetLeaderboardResult result)
    {

        foreach (Transform item in rowsParent)
        {

            Destroy(item.gameObject);
        }

        foreach (var item in result.Leaderboard)
        {

            GameObject newGO = Instantiate(rowPrefab, rowsParent);
            Text[] texts = newGO.GetComponentsInChildren<Text>();
            texts[0].text = (item.Position + 1).ToString();
            texts[1].text = item.DisplayName;

            

            texts[2].text = item.StatValue.ToString();
            if (item.DisplayName == null)
            {
                texts[1].text = item.PlayFabId;
            }
            
            if (item.PlayFabId == loggedInplayfabID)
            {
                if (item.DisplayName == null)
                {
                    texts[1].text = GetInfo.getName;
                }
                Debug.Log("im in if color");
                Debug.Log("yourposion is"+ texts[0].text);
                if (imInAR == true)
                {
                    Debug.Log("im in AR ==TRUE");

                    getpositiontext(texts[0].text);
                   

                }
                //texts[0].color = Color.red;
                texts[1].color = Color.red;
                texts[2].color = Color.red;


            }


            Debug.Log(item.Position + "-" + item.PlayFabId + "-" + item.StatValue + "-" + loggedInplayfabID);

        }
    }


    public void Game1level1()
    {
        SceneManager.LoadScene("ARgame");
        Screen.orientation = ScreenOrientation.Portrait;

        showGroup.ShowHidden = true;
        Group1L1 = true;
        //  HiddenObject.ShowHidden = true;
        // unlocklevel2.ShowHidden = true;
        //   progresBar.ShowHidden = true;
        checkG1L1int++;

        if (checkG1L1 == checkG1L1int)
        {
            // scoreupdate = 5;
            //  PlayfabManager1.scoreNumber = scoreupdate;
            Update();
            SaveLevelG1L1();



            //progresBar.num += 7.2f;

            //Starcount.numG1 += 50.0f;
        }
    }
    public void Game1level2()
    {
        SceneManager.LoadScene("ARgame");
        Screen.orientation = ScreenOrientation.Portrait;

        showGroup.ShowHidden = true;
        Group1L2 = true;
        //  PlayfabManager1.Group1L1 = true;
        //  HiddenObject1.ShowHidden1 = true;
        unlocklevel3.ShowHidden = true;
        // progresBar.ShowHidden = true;
        checkG1L2int++;

        if (checkG1L2 == checkG1L2int)
        {
            //   scoreupdate = 5;
            //   PlayfabManager1.scoreNumber = scoreupdate;



            Update();
            SaveLevelG1L2();
            //progresBar.num += 7.2f;
            //  Starcount.numG1 += 50.0f;

        }

    }
    public void Game2level1()
    {
        SceneManager.LoadScene("ARgame");
        Screen.orientation = ScreenOrientation.Portrait;

        showGroup1.ShowHidden = true;
        Group2L1 = true;

        //  HiddenObject2.ShowHidden2 = true;
        //  progresBar.ShowHidden = true;
        checkG2L1int++;
        if (checkG2L1 == checkG2L1int)
        {
            Update();
            SaveLevelG2L1();
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
        Screen.orientation = ScreenOrientation.Portrait;

        showGroup1.ShowHidden = true;
        Group2L2 = true;

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
            Update();
            SaveLevelG2L2();
        }

    }


    public void Game3level1()
    {
        SceneManager.LoadScene("ARgame");
        Screen.orientation = ScreenOrientation.Portrait;

        showGroup2.ShowHidden = true;
        Group3L1 = true;

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
            Update();
            SaveLevelG3L1();
        }


    }
    public void Game3level2()
    {
        SceneManager.LoadScene("ARgame");
        Screen.orientation = ScreenOrientation.Portrait;

        showGroup2.ShowHidden = true;
        Group3L2 = true;

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
            Update();
            SaveLevelG3L2();
        }

    }






    public void Game4level1()
    {
        SceneManager.LoadScene("ARgame");
        Screen.orientation = ScreenOrientation.Portrait;

        showGroup3.ShowHidden = true;
        Group4L1 = true;

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
            Update();
            SaveLevelG4L1();
        }


    }

    public void Game4level2()
    {
        SceneManager.LoadScene("ARgame");
        Screen.orientation = ScreenOrientation.Portrait;

        showGroup3.ShowHidden = true;
        Group4L2 = true;

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
            Update();
            SaveLevelG4L2();
        }

    }



    public void Game5level1()
    {
        SceneManager.LoadScene("ARgame");
        Screen.orientation = ScreenOrientation.Portrait;

        showGroup4.ShowHidden = true;
        Group5L1 = true;

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
            Update();
            SaveLevelG5L1();
        }


    }


    public void Game5level2()
    {
        SceneManager.LoadScene("ARgame");
        Screen.orientation = ScreenOrientation.Portrait;

        showGroup4.ShowHidden = true;
        Group5L2 = true;

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
            Update();
            SaveLevelG5L2();
        }

    }

    public void Game6level1()
    {
        SceneManager.LoadScene("ARgame");
        Screen.orientation = ScreenOrientation.Portrait;

        showGroup5.ShowHidden = true;
        Group6L1 = true;

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
            Update();
            SaveLevelG6L1();
        }

    }

    public void Game6level2()
    {
        SceneManager.LoadScene("ARgame");
        Screen.orientation = ScreenOrientation.Portrait;

        showGroup5.ShowHidden = true;
        Group6L2 = true;

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
            Update();
            SaveLevelG6L2();
        }

    }




}



