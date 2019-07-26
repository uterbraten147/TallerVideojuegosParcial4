using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuernito : MonoBehaviour
{
    float speed = 5f;
    public bool crouch;
    bool presionado;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        presionado = false;

    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

       // int cont = 0;

        if (Input.GetButtonDown("Fire1") && !presionado )
        {
            Debug.Log("presionado");
            //cont = 1;
            crouch = true;
            presionado = true;
            
        }
        else if (Input.GetButtonDown("Fire1") && presionado)
        {
            
            crouch = false;
            Debug.Log("inpresionado");
            presionado = false;
            
        }

        if (crouch)
        {
            animator.SetBool("Crouch", true);
        }
        else if(!crouch)
        {
            animator.SetBool("Crouch", false);
        }


    }

    void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        animator.SetFloat("Speed", ver);
        animator.SetFloat("horiVer", hor);
        Vector3 playermove = new Vector3(hor, 0, ver) * speed * Time.deltaTime;
        transform.Translate(playermove, Space.Self);


        
    }
}
