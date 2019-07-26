using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tocar : MonoBehaviour
{
    public Animator animator;
    public GameObject Text0;

    // Start is called before the first frame update
    private void Awake()
    {
        animator.SetBool("Tocar", false);
        Text0.SetActive(false);
    }
    private void OnCollisionStay(Collision collision)
    {
        if (Input.GetKeyDown("g"))
        {
            animator.SetBool("Tocar", true);
            StartCoroutine(Esperar(1));
            Text0.SetActive(true);
            StartCoroutine(EsperarT(15));
        }

    }

   

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Esperar(float i)
    {
        yield return new WaitForSeconds(i);
        animator.SetBool("Tocar", false);
        Text0.SetActive(false);
    }

    IEnumerator EsperarT(float i)
    {
        yield return new WaitForSeconds(i);
        Text0.SetActive(false);
    }
}
