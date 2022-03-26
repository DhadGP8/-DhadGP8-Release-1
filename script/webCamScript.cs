using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class webCamScript : MonoBehaviour {

    //public GameObject webCameraPlane; 
    // public GameObject projectile; 
    //public Button fireButton;
    // public float shootForce=700.0f;
    // public Transform Camera;

    // Use this for initialization
    void Start () {

      //  if (Application.isMobilePlatform) {
    //GameObject cameraParent = new GameObject ("camParent");
    //cameraParent.transform.position = this.transform.position;
    //this.transform.parent = cameraParent.transform;
  //  cameraParent.transform.Rotate (Vector3.right, 180);
//   }

    Input.gyro.enabled = true;

    //OnButtonDown();


    //WebCamTexture webCameraTexture = new WebCamTexture();
    //webCameraPlane.GetComponent<MeshRenderer>().material.mainTexture = webCameraTexture;
    //webCameraTexture.Play();




  }

   public void OnButtonDown(){
   //GameObject bullet = Instantiate(projectile, arCamera.position, arCamera.rotation) as GameObject;

    GameObject bullet =Instantiate(Resources.Load("bullet", typeof(GameObject))) as GameObject;
    Rigidbody rb = bullet.GetComponent<Rigidbody>();
    bullet.transform.rotation = Camera.main.transform.rotation;
    bullet.transform.position = Camera.main.transform.position;
    rb.AddForce(Camera.main.transform.forward * 500f);
    Destroy (bullet, 3);

   GetComponent<AudioSource> ().Play ();


   }
  
  
  
  // Update is called once per frame
  void Update () {

  Quaternion cameraRotation = new Quaternion (Input.gyro.attitude.x, Input.gyro.attitude.y, -Input.gyro.attitude.z, -Input.gyro.attitude.w);
  this.transform.localRotation = cameraRotation;
       


    }
}
