using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    float speed = 3f;

    public Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMovement();

    }

    void PlayerMovement()
    {
        float hor = Input.GetAxis("Horizontal");
        float ver = Input.GetAxis("Vertical");
        animator.SetFloat("Speed", ver);
        Vector3 playermove = new Vector3(hor, 0, ver) * speed * Time.deltaTime;
        transform.Translate(playermove,Space.Self);


        
    }
}
