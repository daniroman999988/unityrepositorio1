using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class menujuego : MonoBehaviour
{

   
    void Update()
    {
        
    }

    public void juego()
    {
        SceneManager.LoadScene("juego");

    }
    public void CargarNivel(string bolo)
    {

        SceneManager.LoadScene(bolo);
    }
    public void Salir()
    {
        Application.Quit();
    }


}

