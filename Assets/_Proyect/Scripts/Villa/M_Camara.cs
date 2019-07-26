using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_Camara : MonoBehaviour
{
    public GameObject camara,interactuable;
    public float rotationSpeed, speed;
    float rotation, rotationCamara, translation;
    public bool activo;
    private Rigidbody cuerpo;
    // Start is called before the first frame update
    void Start()
    {
        activo = false;
        rotationSpeed = 20;
        //speed = 1f;
        speed = 50f;
        cuerpo = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (activo)
        {
            rotation = 0;
            rotationCamara = 0;
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                rotationCamara = -10 * rotationSpeed;
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {
                rotationCamara = 10 * rotationSpeed;
            }
            if (Input.GetKey(KeyCode.A))
            {
                rotation = -10 * rotationSpeed;
            }
            else if (Input.GetKey(KeyCode.D))
            {
                rotation = 10 * rotationSpeed;
            }
            translation = Input.GetAxis("Vertical") * speed;
            rotation *= Time.deltaTime;
            rotationCamara *= Time.deltaTime;
            transform.Rotate(0, rotation, 0);
            //transform.Translate(translation,0, 0);
            cuerpo.AddForce(transform.right * translation);
            camara.transform.Rotate(0, rotationCamara, 0);
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (name == "M_Player")
        {
            interactuable.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (name == "M_Player")
        {
            interactuable.SetActive(false);
        }
    }
    public void activar()
    {
        Debug.Log("Encendido");
        camara.SetActive(true);
        activo = true;
    }
    public void desactivar()
    {
        camara.SetActive(false);
        activo = false;
    }
}
