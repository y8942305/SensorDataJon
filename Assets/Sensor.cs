using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    Gyroscope m_Gyro;
    bool ifButtonPressed = false;
    void start()
    {
        //Set up and enable the Gyroscope (check if your device has one)
        m_Gyro = Input.gyro;
        m_Gyro.enabled = true;
    }
    private void Update()
    {
        //Checks if the gyroscope is recording data, when button is pressed it sets it to true
        if (ifButtonPressed){
            Debug.Log(m_Gyro.attitude);
        }
    }
    public void setButtonPressed(){
        ifButtonPressed = !ifButtonPressed;
    }
    
}
