using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Proyectil : MonoBehaviour

{
    public int prota = 100;
    public int lux = 47;


    // Start is called before the first frame update
    void Start()
    {
        daniArea();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void daniArea()
    {

        int Proyectil = prota - lux;
        Debug.Log("Daño que quita lux es:" + Proyectil);
    }

} 
