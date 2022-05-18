using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class SpawnNewInsect : MonoBehaviour
{
    public TrackableBehaviour theTrackable;
    public GameObject vButtonObj2;
    public GameObject prefabMoth;
    public GameObject prefabGnat;

    // Use this for initialization
    void Start() {
        vButtonObj2 = GameObject.Find("insectButton");
        vButtonObj2.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vButtonObj2.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);
    }

    // Update is called once per frame
    void Update() {
    }

    // when button is pressed
    public void OnButtonPressed(VirtualButtonBehaviour vButt2) {
        //Debug.Log("````````````````````````````````button pressed  " );
        Insect newbug;

        if (Random.value > 0.5f)
        {
            newbug = new Moth();                        // create new instance of flying insect
            newbug.SpawnSelf(prefabMoth, theTrackable); // spawn prefab so we can see this new bug
        }
        else
        {
            newbug = new Gnat();                        // create new instance of flying insect
            newbug.SpawnSelf(prefabGnat, theTrackable); // spawn prefab so we can see this new bug
        }

        CreatureManager.AddCreature(newbug);            // creature manager keeps track of all bugs
    }

    // when button is released
    public void OnButtonReleased(VirtualButtonBehaviour vButt2) {
    }
}