using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicional : MonoBehaviour
{
    public int EdadUno = 5;
    public float EdadDos = 3.6f;


    // Start is called before the first frame update
    void Start()
    {
        if (EdadUno >= 3.6f)

        {

            Debug.Log("EdadUno es mayor que 3.6");
        }
        else
        {
            Debug.Log("EdadUno es menor que 3.6");

        }

        if (miSobrante == 0)
        {
            Debug.Log("El sobrante es par");
        }
        else
        {
            Debug.Log("El sobrante es impar");
        }
    }
        
        
        //Prueba operador modulo %

        public int miSobrante = 5 % 2;

        // Update is called once per frame
        void Update()
        {

        }
    
}

