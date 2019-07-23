using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class WalkNPC : MonoBehaviour
{
    public Transform[] walkPoints; //puntos de recorrido 
    public float walkSpeed = 1f; //velocidad caminando
    public bool isIdle; //Estamos en idle o no ?


    //variables privadas
    private int walkIndex; //indice de patrolling

    private NavMeshAgent navAgent; //Referencia del componente NavMeshAgent 
    private Animator anim; //referencia del componente Animator


    private void Awake()
    {
        //Inicializacio de referencias
        anim = GetComponent<Animator>();
        navAgent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        if (isIdle)
        {
            anim.Play("Idle");
        }
        else
        {
            anim.Play("Walk");
        }


    }


    private void Update()
    {
        if (!isIdle)
        {
            ChooseWalkPoint();
        }

    }

    void ChooseWalkPoint()
    {
        if (navAgent.remainingDistance <= 0.1f)
        {
            navAgent.SetDestination(walkPoints[walkIndex].position);

            if (walkIndex == walkPoints.Length - 1)
            {
                walkIndex = 0;
            }

            else
            {
                walkIndex++;
            }
        }
    }
}
