using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;


public class BoneButton : MonoBehaviour
{
	public Animator myAnim;
	public GameObject vButtonObj;
    public GameObject myGraphic;
    // Start is called before the first frame update
    void Start()
    {
        vButtonObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vButtonObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
        myGraphic.SetActive(false);
    }

    void Update()
    {
    	myGraphic.SetActive(myAnim.GetBool("Bone"));
    }

    // Update is called once per frame
    public void OnButtonPressed(VirtualButtonBehaviour vButt) 
    {
        myGraphic.SetActive(true);
        myAnim.SetBool("Bone", true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vButt) {
    
    }
}
