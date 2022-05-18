using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoneReset : MonoBehaviour
{
    private Animator myAnim;
    // Start is called before the first frame update
    void Start()
    {
        myAnim = GetComponent<Animator>();
    }

    void ResetBone()
    {
        myAnim.SetBool("Bone", false);
    }
}
