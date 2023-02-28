using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automatic_Movement : MonoBehaviour
{
    public float ySpeed = -5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * ySpeed * Time.deltaTime);
    }
}
