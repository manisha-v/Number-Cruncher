using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumBehaviour : MonoBehaviour
{
    public static bool GameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(GameOver==false)
            transform.position += new Vector3(0, -0.27f, 0);   
            
    }
   
}
