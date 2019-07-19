using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public int Daño = 1;
    public float fireRate = .25f;
    public float gunRange = 50f;
    public float hitForce = 100f;
    public Transform trigger;
    public GameObject giorno;

    private Camera Cam;
    private WaitForSeconds shotDuration = new WaitForSeconds(0.07f);
    //private AudioSource gunAudio;
    private LineRenderer laserLine;
    private float nextFire; //siguiente disparo
    
    void Start()
    {
        laserLine = GetComponent<LineRenderer>();
        //gunAudio = GetComponent<AudioSource>();
        Cam = giorno.transform.GetChild(1).transform.GetChild(0).GetComponent<Camera>(); ;

    }

   
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            StartCoroutine(disparoFX());
            Vector3 rayOrigin = Cam.ViewportToWorldPoint(new Vector3(0.5f, 0.5f, 0));
            RaycastHit hit;

            laserLine.SetPosition(0, trigger.position);

            if (Physics.Raycast(rayOrigin,Cam.transform.forward,out hit, gunRange))
            {
                laserLine.SetPosition(1, hit.point);
            }
            else
            {

                laserLine.SetPosition(1, rayOrigin + (Cam.transform.forward * gunRange));
            }

        }
        
    }

    private IEnumerator disparoFX()
    {
        //gunAudio.Play();
        laserLine.enabled = true;
        yield return shotDuration;
        laserLine.enabled = false;
    }
}
