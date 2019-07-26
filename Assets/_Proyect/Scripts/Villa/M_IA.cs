using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_IA : MonoBehaviour
{
    public bool activo;
    Rigidbody cuerpo;
    public int vida;
    float randX, randZ;
    public Vector3 ruta;
    // Start is called before the first frame update
    void Start()
    {
        activo = false;
        cuerpo = GetComponent<Rigidbody>();
        vida = 10;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (activo)
        {
            if(Vector3.Distance(transform.position, ruta)<1.0f)
            {
                calcularRuta();
            }
            //Vector3 vectorDireccion = transform.position - new Vector3(randX, transform.position.y, randZ);
            //cuerpo.MovePosition(transform.position + transform.right * 20 * Time.deltaTime);
            cuerpo.AddForce(ruta * Time.deltaTime);
        }
    }
    public void calcularRuta()
    {
        randX = Random.Range(-14, 60);
        randZ = Random.Range(-120, -60);
        ruta = new Vector3(randX, transform.position.y, randZ);
    }
    private void OnCollisionEnter(Collision collision)
    {
        cuerpo.velocity = Vector3.zero;
        cuerpo.angularVelocity = Vector3.zero;
        vida -= 2;
        if (vida <= 0)
        {
            gameObject.SetActive(false);
        }
    }
}
