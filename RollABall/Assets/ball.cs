using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody sphereRigidbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

void Update()

 {
    Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);
    sphereRigidbody.AddForce(inputXZPlane);

 }
 }
