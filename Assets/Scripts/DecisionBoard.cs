using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecisionBoard : MonoBehaviour
{
    Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    private void OnMouseDown()
    {
        anim.SetTrigger("isClicked");
     
    }


}
