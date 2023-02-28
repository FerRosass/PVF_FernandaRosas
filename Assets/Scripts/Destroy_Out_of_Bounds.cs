using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy_Out_of_Bounds : MonoBehaviour
{
    private float LowerBound = -10;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position.y < LowerBound)
        {
            Destroy(gameObject);
        }
        
    }
}
