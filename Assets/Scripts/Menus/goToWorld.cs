using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goToWorld : MonoBehaviour
{
    public int escena;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    private void OnTriggerEnter(Collider other)
    {
       if( other.gameObject.tag == "Player"){

            SceneManager.LoadScene(escena);
        }
    }


}
