using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*Let´s check some´
         *input from keyboard
         *and change colors! */
        if (Input.GetKeyDown(KeyCode.R))
            
        {
            this.GetComponent<SpriteRenderer>().color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.R))
       {
            this.GetComponent<SpriteRenderer>().color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.R))

        {
            this.GetComponent<SpriteRenderer>().color = Color.yellow;
        }




    }



}
