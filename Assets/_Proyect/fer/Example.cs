using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Example : MonoBehaviour

{ 
    public GameObject Character;
    public GameObject Wolf;
    public GameObject Text;
    public GameObject target;
    [SerializeField]
    private bool Acariciar;
    public Animator animator;
    public float movementSpeed = 4;
    public bool acariciado;


    private void Awake()
    {
        Text.SetActive(false);
        Acariciar = false ;
        acariciado = false;

    }

    public void Update()
    {

        if (acariciado)
        {
            transform.LookAt(Character.transform);
            transform.position += transform.forward * movementSpeed * Time.deltaTime;
            //acariciado = false;
        }
        if (Input.GetKey("x"))
        {
            acariciado = false;
        }



    }


    private void OnCollisionStay(Collision collision)
    {
        if (Input.GetKey("g"))
        {


            Debug.Log("Acariciado");
            StartCoroutine(Esperar(30));
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

    IEnumerator Esperar(float i)
    {
        Debug.Log("Entro pero aextra");
        yield return  new WaitForSeconds(i);
        acariciado = true;




    }
}

