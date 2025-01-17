using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public Rigidbody sphereRigidbody;
    public float ballSpeed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

void Update()

 {
    Vector2 inputVector = Vector2.zero; // intialize our input vector
 if (Input.GetKey(KeyCode.W))
{
    inputVector += Vector2.up; // "a += b" <=> "a = a + b"
 }

 if (Input.GetKey(KeyCode.S))
 {
    inputVector += Vector2.down;

 }

if (Input.GetKey(KeyCode.D))
 {
    inputVector += Vector2.right;

 }

 if (Input.GetKey(KeyCode.A))
 {
    inputVector += Vector2.left;

 }
 Debug.Log("Resultant Vector: " + inputVector);
    Vector3 inputXZPlane = new Vector3(inputVector.x, 0, inputVector.y);
    sphereRigidbody.AddForce(inputXZPlane);
 }
 }
