using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnEnemys : MonoBehaviour
{
    public  GameObject enemigo1;
    public GameObject enemigo2;
    public GameObject enemigo3;


    // Start is called before the first frame update
    float timeSpwan=0.0f;

    private void Update()
    {
        timeSpwan += Time.deltaTime;
       

        if (timeSpwan >= 5)
        {
            Debug.Log("holaaa");
            StartCoroutine(enemigosSpawn());
            timeSpwan = 0;
        }
      
        
    }




    IEnumerator enemigosSpawn()
    {
        
        
        float posX = Random.Range(-10f, 25f);
        float posZ = Random.Range(-10f, 25f);
        float posY = 0.02f;
        Vector3 posEnemigo1 = new Vector3(posX, posY, posZ);
        Transform transfomhaha = enemigo1.transform;
        transfomhaha.position = posEnemigo1;
        Instantiate(enemigo1, transfomhaha );


        yield return new WaitForSeconds(0.2f);



    }
}
