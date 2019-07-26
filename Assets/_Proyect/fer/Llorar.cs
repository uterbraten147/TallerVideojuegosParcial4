using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Llorar : MonoBehaviour
{
    public GameObject Lapida;
    public Animator animator;
    public GameObject Text0;
    public AudioClip clipi;

    private void Awake()
    {
        animator.SetBool("Acariciar", false);
        Text0.SetActive(false);
    }



    private void OnCollisionStay(Collision collision)
    {
        if (Input.GetKeyDown("g"))
        {
            animator.SetBool("Crying", true);
            Text0.SetActive(true);
            AudioSource audio = GetComponent<AudioSource>();

            audio.Play();
            audio.clip = clipi;
            audio.Play();
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        animator.SetBool("Crying", false);
        Text0.SetActive(false);

    }
}
