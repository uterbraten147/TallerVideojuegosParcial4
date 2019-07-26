using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_Manager : MonoBehaviour
{
    public GameObject[] menus;
    public Transform[] posCamara;
    public GameObject camaraAlterna;
    public M_Camara[] jugador;
    public GameObject[] go_jugador;
    public GameObject[] prefabs;
    private int EtapaActual,prefabActual;
    // Start is called before the first frame update
    void Start()
    {
        EtapaActual = 0;
        prefabActual = 0;
    }

    public void cambioDeEtapa(int nueva)
    {
        switch (nueva)
        {
            case 0:
                go_jugador[0].transform.position = posCamara[0].position;
                //menus[3].SetActive(false);                
                cambioDeEtapa(1);
                break;
            case 1:
                go_jugador[0].transform.position = posCamara[0].position;
                menus[0].SetActive(false);
                menus[1].SetActive(true);
                jugador[0].activar();
                camaraAlterna.SetActive(false);
                break;
            case 2:
                //jugador[0].desactivar();
                go_jugador[0].SetActive(false);
                menus[1].SetActive(false);
                menus[2].SetActive(true);
                camaraAlterna.SetActive(true);
                camaraAlterna.transform.position = posCamara[1].position;
                camaraAlterna.transform.rotation = posCamara[1].rotation;
                go_jugador[1] = Instantiate(prefabs[0], new Vector3(-11, 0, 140), Quaternion.identity);
                break;
            case 3:
                menus[2].SetActive(false);
                camaraAlterna.transform.position = posCamara[2].position;
                camaraAlterna.transform.rotation = posCamara[2].rotation;
                //go_jugador[1].AddComponent<Animator>();
                go_jugador[1].GetComponent<Animator>().SetTrigger("Iniciar");
                GameObject.Find("Animador").GetComponent<Animator>().SetTrigger("Iniciar");
                break;
            case 4:
                jugador[1] = go_jugador[1].GetComponent<M_Camara>();
                camaraAlterna.SetActive(false);
                jugador[1].activar();
                jugador[1].speed = 150;
                break;
            case 5:
                break;
        }
        EtapaActual = nueva;
    }
    public void cambioCarro(int dir)
    {
        prefabActual += dir;
        if (prefabActual == -1)
        {
            prefabActual = 4;
        }
        else if(prefabActual==5)
        {
            prefabActual = 0;
        }
        Destroy(go_jugador[1]);
        go_jugador[1] = Instantiate(prefabs[prefabActual], new Vector3(-11, 0, 140), Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
