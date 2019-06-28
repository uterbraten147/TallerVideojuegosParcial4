using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraScript : MonoBehaviour
{
    public float rotacionSpeed = 1f; 
    public Transform target, player;

    float mouseX, mouseY;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

     void LateUpdate()
    {
        CamaraControl();
    }

    void CamaraControl()
    {
        mouseX += Input.GetAxis("Mouse X") * rotacionSpeed;
        mouseY -= Input.GetAxis("Mouse Y") * rotacionSpeed;
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        transform.LookAt(target);
        target.rotation = Quaternion.Euler(mouseX, mouseX, 0);
        player.rotation = Quaternion.Euler(0, mouseY, 0);

    }
}
