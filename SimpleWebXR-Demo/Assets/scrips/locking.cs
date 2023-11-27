using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class locking : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator animator;

    public void Lock()
    {
        animator.SetBool("locking",false);
    }
    public void Unlock()
    {
        animator.SetBool("locking",true);
    }
}
