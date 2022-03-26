using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class L9GameMAnager1 : MonoBehaviour {

    public GameObject carrot, car, grapes, dog, carrotBlack, carBlack, grapesBlack, dogBlack,blockPanel;


    Vector3 initialCarrotPosition, initialCarPosition, initialGrapesPosition, initialDogPosition;

    bool carrotBool, carBool, grapesBool, dogBool = false;

    public AudioSource source;
    public AudioClip[] correct;
    public AudioClip incorrect;



    public GameObject PausePanel;
    public static bool gameIsPaused;

    void Start()
    {
        initialCarrotPosition = carrot.transform.position;
        initialCarPosition = car.transform.position;
        initialGrapesPosition = grapes.transform.position;
        initialDogPosition = dog.transform.position;

    }


 


    public void DragCarrot()
    {

        
        carrot.transform.position = Input.mousePosition;

    }


    public void DragCar()
    {

       
        car.transform.position = Input.mousePosition;

    }

    public void DragGrapes()
    {

       
        grapes.transform.position = Input.mousePosition;

    }
 
    public void DragDog()
    {

       
        dog.transform.position = Input.mousePosition;

    }




    


    public void DropCarrot()
    {

        float distance = Vector3.Distance(carrot.transform.position, carrotBlack.transform.position);
        if (distance < 50)
        {
            carrot.transform.position = carrotBlack.transform.position;
            Score.scoreNumber += 1;
            carrotBool = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
            
        }
        else

        {
            carrot.transform.position = initialCarrotPosition;
            source.clip = incorrect;
            source.Play();
        }




    }

    public void DropCar()
    {

        float distance = Vector3.Distance(car.transform.position, carBlack.transform.position);
        if (distance < 50)
        {
            car.transform.position = carBlack.transform.position;
            Score.scoreNumber += 1;
            carBool = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            car.transform.position = initialCarPosition;
            source.clip = incorrect;
            source.Play();
        }

    }

    public void DropGrapes()
    {

        float distance = Vector3.Distance(grapes.transform.position, grapesBlack.transform.position);
        if (distance < 50)
        {
            grapes.transform.position = grapesBlack.transform.position;
            Score.scoreNumber += 1;
            grapesBool = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            grapes.transform.position = initialGrapesPosition;
            source.clip = incorrect;
            source.Play();
        }

    }


    public void DropDog()
    {

        float distance = Vector3.Distance(dog.transform.position, dogBlack.transform.position);
        if (distance < 50)
        {
            dog.transform.position = dogBlack.transform.position;
            dog.transform.localScale = dogBlack.transform.localScale;
            Score.scoreNumber += 1;
            dogBool = true;
            source.clip = correct[Random.Range(0, correct.Length)];
            source.Play();
        }
        else
        {
            dog.transform.position = initialDogPosition;
            source.clip = incorrect;
            source.Play();
        }



    }


     void Update()
    {
        if(carrotBool && carBool && grapesBool && dogBool  || Timer.time<=0)
        {
            
            StartCoroutine(LoadNextScene());
        }
    }

    IEnumerator LoadNextScene()
    {
        Score.scoreNumber = 0;
        blockPanel.SetActive(true);
        yield return new WaitForSeconds(60f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

    }


    public void Setting()
    {
        if (gameIsPaused)
        {
            Resume();
        }
        else
        {
            Pause();
        }


    }

    public void Resume()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }
    public void Pause()
    {
        PausePanel.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }

    public void Exit()
    {
        Application.Quit();
    }
}
