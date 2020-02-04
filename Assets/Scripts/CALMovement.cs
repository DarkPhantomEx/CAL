using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CALMovement : MonoBehaviour
{
    public float HoriAxis;
    public float VertAxis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        VertAxis = Input.GetAxis("Vertical");
        HoriAxis = Input.GetAxis("Horizontal");
        
        transform.position += new Vector3(HoriAxis * 6.0f * Time.deltaTime, VertAxis * 4.0f * Time.deltaTime, 0);
        // -0.44 < y <-4.4, -6.8 < x < 10.226
    }
}
