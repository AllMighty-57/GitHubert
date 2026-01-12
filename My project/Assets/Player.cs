using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private void Start()
    {


    }
    private void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.forward * 0.5f;
        }

        if (Input.GetKey(KeyCode.S))
        {
            transform.position += Vector3.back * 0.5f;
        }
    }

}
