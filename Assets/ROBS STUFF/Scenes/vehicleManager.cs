using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class vehicleManager : MonoBehaviour
{

    public GameObject car, bike, boat, fourplayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1)) {
            ChangeVehicle(1);
        }


        if (Input.GetKey(KeyCode.Alpha2)) {
            ChangeVehicle(2);
        }


        if (Input.GetKey(KeyCode.Alpha3)) {
            ChangeVehicle(3);
        }
    
        if (Input.GetKey(KeyCode.Alpha4)) {
            ChangeVehicle(4);
        }

        if (Input.GetKey(KeyCode.Alpha0)) {
            SceneManager.LoadScene("playground");
        }


    }


    void ChangeVehicle(int number){
        if (number == 1) {
            car.SetActive (true);
            bike.SetActive (false);
            boat.SetActive (false);
            fourplayer.SetActive (false);
        } else if (number == 2) {
            car.SetActive (false);
            bike.SetActive (true);
            boat.SetActive (false);  
            fourplayer.SetActive (false);         
        } else if (number == 3) {
            car.SetActive (false);
            bike.SetActive (false);
            boat.SetActive (true);
            fourplayer.SetActive (false);           
        } else if (number == 4) {
            car.SetActive (false);
            bike.SetActive (false);
            boat.SetActive (false);
            fourplayer.SetActive (true);           
        }
    }



}
