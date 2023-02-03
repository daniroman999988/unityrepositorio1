using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carlos : MonoBehaviour
{
    // La cantidad de salud inicial de nuestro personaje
    public int SaludPersonaje = 100;
    //El deterioro de salud que recibe nuestro perosnaje
    public  int deterioroSalud = 10;

    public string nombrePersonaje = "Carlos";

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Salud Inicial: " + SaludPersonaje);

        Debug.Log("Daño que recibe: " + deterioroSalud);
        Debug.Log(SaludPersonaje - deterioroSalud);
        Debug.Log("El nombre del personaje es: " + nombrePersonaje);



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
