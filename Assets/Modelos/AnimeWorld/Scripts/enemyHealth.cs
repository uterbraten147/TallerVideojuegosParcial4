using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHealth : MonoBehaviour
{

    private int EnemyHealth = 100;
    // Start is called before the first frame update
    void Start()
    {
        EnemyHealth = 100;
    }

    // Update is called once per frame
    void Update()
    {
        if(EnemyHealth <= 0)
        {
            Destroy(gameObject);
        }
        
    }

    public void takeDamage(int dmg)
    {
        this.EnemyHealth -= dmg;
    }
}
