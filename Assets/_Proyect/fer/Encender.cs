using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Encender : MonoBehaviour
{
   
    public GameObject Fogata;
    public GameObject Fuejo;
    public GameObject Fuego;
    public GameObject Fp;
    public GameObject Text0;
    public bool Encendida;
    public float speed;
    

    // Start is called before the first frame update
    private void Awake()
    {
        Fuejo.SetActive(false);
        Encendida = false;
        Fuego.SetActive(false);
        Fp.SetActive(false);
        Text0.SetActive(false);
    }

    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Encendida)
        {
            Fuejo.transform.Rotate(Vector3.up, speed * Time.deltaTime);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        if (Input.GetKeyDown("g")&& !Encendida)
        {
           
            Encendida = true;
            
            Fuejo.SetActive(true);
            Fuego.SetActive(true);
            Fp.SetActive(true);
            Text0.SetActive(true);
            StartCoroutine(Esperar(30));
            StartCoroutine(EsperarT(6));


        }


        IEnumerator Esperar(float i)
        {
            yield return new WaitForSeconds(i);
            Fuejo.SetActive(false);
            Fuego.SetActive(false);
            Fp.SetActive(false);
        }

        IEnumerator EsperarT(float i)
        {
            yield return new WaitForSeconds(i);
            Text0.SetActive(false);
        }




    }
}
