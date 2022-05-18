using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class RollButton : MonoBehaviour
{
    public Animator myAnim;
	public GameObject vButtonObj;
    // Start is called before the first frame update
    void Start()
    {
        vButtonObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vButtonObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    // Update is called once per frame
    public void OnButtonPressed(VirtualButtonBehaviour vButt) 
    {
        myAnim.SetBool("Roll", true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vButt) {
    
    }
}
