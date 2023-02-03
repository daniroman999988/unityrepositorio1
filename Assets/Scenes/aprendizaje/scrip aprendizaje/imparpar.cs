using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class imparpar : MonoBehaviour
{
    [SerializeField]

    private UnityEngine.UI.Text componenteTexto = null;
    private string dato1; //Aqui se almacenara la entrada ingresada




    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void IngresaDato1(string ingreso)
    {
        //Esta función la ejecuta el Imput Fild al escribir texto y presionar enter.
        //El dato de la entrada se alamacena en la variable correspondiente

        dato1 = ingreso;
        Debug.Log(dato1);
    }
    public void AlgoritmoEjercicio()
    {
        int entero = int.Parse(dato1);

        int resto = entero % 2;

        string resultado; 

        if( resto == 0)
        {
            resultado = "es par";


        }
        else
        {
            resultado = "es impar";
        }
        componenteTexto.text = resultado;

    }

}