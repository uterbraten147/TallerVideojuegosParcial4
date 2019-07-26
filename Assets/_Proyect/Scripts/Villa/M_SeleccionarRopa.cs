using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class M_SeleccionarRopa : MonoBehaviour
{
    //public Texture2D[] texturas;
    public Material[] materiales;
    private Material[] materialesActuales;
    int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        materialesActuales = GetComponent<SkinnedMeshRenderer>().materials;
        materialesActuales[3] = materiales[index];
        GetComponent<SkinnedMeshRenderer>().materials=materialesActuales;
    }

    public void cambiarRopa(int dir)
    {
        index+=dir;
        if (index == 7)
        {
            index = 0;
        }
        else if(index==-1)
        {
            index = 6;
        }
        materialesActuales = GetComponent<SkinnedMeshRenderer>().materials;
        materialesActuales[3] = materiales[index];
        GetComponent<SkinnedMeshRenderer>().materials = materialesActuales;
    }
    // Update is called once per frame
    void Update()
    {
        /*if (Input.GetKeyDown(KeyCode.D))
        {
            index++;
            if (index == 7)
            {
                index = 0;
            }
            Debug.Log("Cambio de ropa:  " + index);
            Debug.Log("Actual:  " + GetComponent<SkinnedMeshRenderer>().materials[3].name);
            Debug.Log("Cambio de ropa nuevo: "+materiales[index].name);

            materialesActuales = GetComponent<SkinnedMeshRenderer>().materials;
            materialesActuales[3] = materiales[index];
            GetComponent<SkinnedMeshRenderer>().materials = materialesActuales;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            index--;
            if (index == -1)
            {
                index = 6;
            }
            Debug.Log("Cambio de ropa:  " + index);
            Debug.Log("Actual:  " + GetComponent<SkinnedMeshRenderer>().materials[3].name);
            Debug.Log("Cambio de ropa nuevo: " + materiales[index].name);

            materialesActuales = GetComponent<SkinnedMeshRenderer>().materials;
            materialesActuales[3] = materiales[index];
            GetComponent<SkinnedMeshRenderer>().materials = materialesActuales;
        }*/
    }
}
