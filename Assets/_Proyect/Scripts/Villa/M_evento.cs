using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_evento : MonoBehaviour
{
    public void iniciarPartida()
    {
        GameObject.Find("Manager").GetComponent<M_Manager>().cambioDeEtapa(4);
        Destroy(GameObject.Find("Manager").GetComponent<M_Manager>().go_jugador[1].GetComponent<Animator>());
        Destroy(GetComponent<Animator>());
    }
}
