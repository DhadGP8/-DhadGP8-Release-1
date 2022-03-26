using System.Collections; 

using System.Collections.Generic; 

using UnityEngine; 

using PlayFab; 

using PlayFab.ClientModels; 

using UnityEngine.UI; 

using UnityEngine.SceneManagement;

using System.Text.RegularExpressions;

public class PlayfabManager : MonoBehaviour 

{ 

      [Header("UI")] 

    public Text messageText;
     public Text helloText;
    public string nameText;
    public GameObject DisplayText;
    public GameObject input;


    public InputField nameInput;
    public InputField emailInput;
    public InputField passwordInput;
    public InputField cpasswordInput;






      public void RegisterButton (){   

          if (passwordInput.text.Length<8){ 

            messageText.text= "  ﺯﻮﻣﺭ  8 ﻰﻠﻋ ﺭﻭﺮﻤﻟﺍ ﺔﻤﻠﻛ ﻱﻮﺘﺤﺗ ﻥﺃ ﺐﺠﻳ"; 

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
     messageText.text = " ﺢﻴﺤﺻ ﺮﻴﻏ ﻲﻧﻭﺮﺘﻜﻟﻹﺍ ﺪﻳﺮﺒﻟﺍ";
        return ;
    }
    string number = nameInput.text;   
        Regex regex2 = new Regex(@"\d");   
        Match match2 = regex2.Match(number);
        if (!match2.Success)    
        {  
         messageText.text = " ﻡﺎﻗﺭﺍ ﻰﻠﻋ ﻡﺪﺨﺘﺴﻤﻟﺍ ﻢﺳﺍ ﻱﻮﺘﺤﻳ ﻥﺍ ﺐﺠﻳ";
        return ;
        }
        //pattern to find if there is any special character in string
        Regex alphaNumeric = new Regex("^[a-zA-Z0-9]*$");
        
        if(!alphaNumeric.IsMatch(nameInput.text))
        {   messageText.text = "  ﻡﺪﺨﺘﺴﻤﻟﺍ ﻢﺳﻹ ﻂﻘﻓ ﻡﺎﻗﺭﻻﺍﻭ ﻑﺮﺣﻷﺍ ﻡﺪﺨﺘﺳﺍ ";
             return ;
        }
        



   var request=new RegisterPlayFabUserRequest {
           Username = nameInput.text,

           Email = emailInput.text, 

           Password =passwordInput.text,

              RequireBothUsernameAndEmail = false,
    };

    PlayFabClientAPI.RegisterPlayFabUser(request, OnRegisterSuccess, OnError); 
    } 

  

      void OnRegisterSuccess(RegisterPlayFabUserResult result){ 

        messageText.text="Registered and logged in !"; 
        home();
        OnSuccess();




      } 

  

  

  
       public void home()
      {
        SceneManager.LoadScene("interface");
      }
  

      public void LoginButton (){ 

        var request=new LoginWithEmailAddressRequest { 

          Email = emailInput.text, 

          Password =passwordInput.text ,
        //  InfoRequestParameters=new GetPlayerCominedInfoRequestParams
          
              //GetPlayerProfile=true
          

        }; 

        PlayFabClientAPI.LoginWithEmailAddress(request, OnLoginSuccess, OnErrorlogin); 

      } 

  

      public void ResetButton (){

        var request=new SendAccountRecoveryEmailRequest { 

              Email = emailInput.text, 
              TitleId="1FFCB" }; 

        PlayFabClientAPI.SendAccountRecoveryEmail(request, OnPasswordReset, OnError); }
      
      

       public void OnPasswordReset(SendAccountRecoveryEmailResult result){ 

         messageText.text= " ﻲﻧﻭﺮﺘﻜﻟﻹﺍ ﻙﺪﻳﺮﺒﻟ ﺭﻭﺮﻤﻟﺍ ﺔﻤﻠﻛ ﻦﻴﻴﻌﺗ ﺓﺩﺎﻋﺍ ﻂﺑﺍﺭ ﻝﺎﺳﺭﺍ ﻢﺗ"; } 

      void Start()
      { 
      } 

      void OnLoginSuccess(LoginResult result){ 

        messageText.text = "Logged in !"; 
        home();
        Debug.Log("Success login/account create!");
        string name = null;
        if(result.InfoResultPayload.PlayerProfile!=null)
        name = result.InfoResultPayload.PlayerProfile.DisplayName;

      } 

      void OnErrorlogin(PlayFabError error){

        
       messageText.text = "  ﺢﻴﺤﺻ ﺮﻴﻏ ﻪﻟﺎﺧﺩﺇ ﻢﺗ ﻱﺬﻟﺍ ﺭﻭﺮﻤﻟﺍ ﺔﻤﻠﻛ/ﻲﻧﻭﺮﺘﻜﻟﻹﺍ ﺪﻳﺮﺒﻟﺍ ";
        
        //messageText.text =error.ErrorMessage; 
       
        Debug.Log(error.GenerateErrorReport()); 

      }
      void OnError(PlayFabError error){

        
      
        messageText.text =error.ErrorMessage; 
       
        Debug.Log(error.GenerateErrorReport()); 

      }
   public void OnSuccess( )
    {

        nameText = input.GetComponent<Text>().text;
        DisplayText.GetComponent<Text>().text="Welcome"+nameText+"to our System";
    }

    public  void SendLeaderboard(int score)
    {

        var request = new UpdatePlayerStatisticsRequest
        {

            Statistics = new List<StatisticUpdate>
            {
                new StatisticUpdate{
                    StatisticName="PlatformScore",
                    Value=score

                }
            }
        };
        PlayFabClientAPI.UpdatePlayerStatistics(request, OnLeaderboardUpdate, OnError);

    }
    void OnLeaderboardUpdate(UpdatePlayerStatisticsResult result)
    {

        Debug.Log("score sends");
    }

} 

 