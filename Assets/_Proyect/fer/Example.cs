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
    public AudioClip clipi;
    public AudioClip last;
    public GameObject Text0;


    private void Awake()
    {
        Text.SetActive(false);
        Acariciar = false ;
        acariciado = false;
        Text0.SetActive(false);

    }

    public void Update()
    {

        if (acariciado)
        {
            transform.LookAt(target.transform);
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
            StartCoroutine(Esperar(5));
            animator.SetBool("Acariciar", true);
            Text.SetActive(true);


            
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
        target.transform.LookAt(target.transform);
        Acariciar = true;
        animator.SetBool("Acariciar", true);
    }

    IEnumerator Esperar(float i)
    {
        
        yield return  new WaitForSeconds(i);
        acariciado = true;
        StartCoroutine(EsperarMS(16));
        StartCoroutine(EsperarM(18));
        AudioSource audio = GetComponent<AudioSource>();

        audio.Play();
        audio.clip = clipi;
        audio.Play();
        Text0.SetActive(true);

    }
   

    IEnumerator EsperarMS(float i)
    {
        yield return new WaitForSeconds(i);

        AudioSource audio = GetComponent<AudioSource>();
        audio.Play();
        audio.clip = last;
        audio.Play();
        Text0.SetActive(false);



    }
    IEnumerator EsperarM(float i)
    {
        yield return new WaitForSeconds(i);
        Wolf.SetActive(false);


    }
}

