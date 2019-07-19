using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Example : MonoBehaviour

{ [SerializeField]
    public GameObject Character;
    public GameObject Wolf;
    public GameObject Text;
    public GameObject target;
    private bool Acariciar;
    public Animator animator;


    private void Awake()
    {
        Text.SetActive(false);
        Acariciar = false ;

    }

    
    private void OnCollisionStay(Collision collision)
    {
        if (Input.GetKey("g"))
        {


            Debug.Log("Acariciado");
            animator.SetBool("Acariciar", true);
            Text.SetActive(true);
            //Lookat();

        }

    }

    private void OnCollisionExit(Collision collision)
    {
        Text.SetActive(false);
        Acariciar = false;
        animator.SetBool("Acariciar", false);

    }

    public void Lookat()
    {
        Character.transform.LookAt(target.transform);
        Acariciar = true;
        animator.SetBool("Acariciar", true);
    }
}

