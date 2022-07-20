﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemFloater : MonoBehaviour
{
    // Inputs de usuario
    public float degreesPerSecond = 15.0f;
    public float amplitude = 25.0f;
    public float frequency = 1.0f;
 
    // Variables que almacenan posición
    Vector3 posOffset = new Vector3 ();
    Vector3 tempPos = new Vector3 ();
 
    // Start is called before the first frame update / INICIALIZACIÓN
    void Start()
    {
        // Guarda la posición inicial y rotación del objeto
        posOffset = transform.position;    
    }

    // Update is called once per frame
    void Update()
    {
        // Spin object around Y-Axis
        transform.Rotate(new Vector3(0f, 0f, Time.deltaTime * degreesPerSecond), Space.World);
 
        // Float up/down with a Sin()
        tempPos = posOffset;
        tempPos.z += Mathf.Sin (Time.fixedTime * Mathf.PI * frequency) * amplitude;
 
        transform.position = tempPos;
    }
}