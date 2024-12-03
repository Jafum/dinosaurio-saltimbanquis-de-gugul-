using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoControl : MonoBehaviour
{
    [SerializeField] Camera camara;
    [SerializeField] Vector2 posicionInicial;
    [SerializeField] Vector2 posicionFinal;
    [SerializeField] float velocidad;
    // Start is called before the first frame update
    void Start()
    {
        camara = Camera.main;
        posicionFinal = camara.ViewportToWorldPoint(new Vector2(0,0));
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(velocidad * Time.deltaTime * Vector2.left);
        if (transform.position.x< posicionFinal.x)
            {
            transform.position = posicionInicial;
            velocidad = velocidad + 1;
        }
    }
}
