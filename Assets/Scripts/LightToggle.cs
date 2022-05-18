using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class LightToggle : MonoBehaviour {

    // public variables will be exposed in the properties panel
    public GameObject vButtonObj;
    public GameObject myGraphic;
    public GameObject myGraphic2;

    private bool _onOff;
    
    // Use this for initialization
    void Start() {
        //vButtonObj = GameObject.Find("onOffSwitch");
        vButtonObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vButtonObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        myGraphic.SetActive(false);
        myGraphic2.SetActive(false);
        _onOff = false;
        CreatureManager.ChangeLightState(_onOff);

        Debug.Log("*********INIT*********  " + _onOff);
    }

    // Update is called once per frame
    void Update() {
        
    }

    // when the button is pressed
    public void OnButtonPressed(VirtualButtonBehaviour vButt) {
        _onOff = !_onOff;                           // toggle onOff variable
        myGraphic.SetActive(_onOff);                // set light object on or off
        myGraphic2.SetActive(_onOff);
        CreatureManager.ChangeLightState(_onOff); // better to be a broadcast event

        Debug.Log("******************  " + _onOff);
    }

    // when button is released
    public void OnButtonReleased(VirtualButtonBehaviour vButt) {
    
    }
}