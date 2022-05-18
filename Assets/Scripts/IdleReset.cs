using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleReset : MonoBehaviour
{
	private Animator myAnim;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Reseting Animation");
        myAnim = GetComponent<Animator>();
    }

    void Reset()
    {
        myAnim.SetBool("Bone", false);
        myAnim.SetBool("Roll", false);
        myAnim.SetBool("Jump", false);
        myAnim.SetBool("Play", false);
    }
}
