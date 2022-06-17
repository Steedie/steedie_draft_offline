using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour
{
    public float tilt, heading;
    public float camDistance, camHeight;
    public Transform target;
    public float turnSpeed;

    void Start()
    {
        
    }

    void Update()
    {
        SetCamPos();

        if (Input.GetKey(KeyCode.Keypad8))
        {
            camDistance -= 0.1f;
        }
        if (Input.GetKey(KeyCode.Keypad2))
        {
            camDistance += 0.1f;
        }

        if (Input.GetKey(KeyCode.Keypad6))
        {
            turnSpeed -= 0.05f;
        }
        if (Input.GetKey(KeyCode.Keypad4))
        {
            turnSpeed += 0.05f;
        }

        if (Input.GetKey(KeyCode.Keypad9))
        {
            camHeight += 0.1f;
        }
        if (Input.GetKey(KeyCode.Keypad3))
        {
            camHeight -= 0.1f;
        }

        camDistance = Mathf.Clamp(camDistance, 0.5f, 150);
        turnSpeed = Mathf.Clamp(turnSpeed, -5f, 5);
        camHeight = Mathf.Clamp(camHeight, -10f, 30);
    }

    private void SetCamPos()
    {
        heading += Time.deltaTime * turnSpeed;
       // tilt += Time.deltaTime * -5;

        tilt = Mathf.Clamp(tilt, -55, 55);
        transform.rotation = Quaternion.Euler(tilt, heading, 0);
        transform.position = target.position - transform.forward * camDistance + Vector3.up * camHeight;
    }
}
