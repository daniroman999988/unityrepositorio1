using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array : MonoBehaviour
{
    public int[] myarrayOfInts;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {

            Debug.Log(i); // Print numbers from 0 to 9 (check i < 10, never 10)
        }
        for (int i = 0; i < myarrayOfInts.Length; i++)
        {
            Debug.Log(myarrayOfInts[i]); 
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
