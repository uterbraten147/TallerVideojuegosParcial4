using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class salirse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine(EsperarT(10));

    }
    IEnumerator EsperarT(float i)
    {
        yield return new WaitForSeconds(i);
        SceneManager.LoadScene(6);
    }


}
