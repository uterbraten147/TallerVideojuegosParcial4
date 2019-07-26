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
        for(int i=0;i< transform.childCount; i++)
        {
            if (transform.GetChild(i).GetComponent<M_IA>()) {
                transform.GetChild(i).GetComponent<M_IA>().activo = true;
                transform.GetChild(i).GetComponent<M_IA>().calcularRuta();
            }
        }
    }
}
