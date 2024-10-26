using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour

{

    public float speed = 2000f;
    public Rigidbody rb;
    public int hitCount = 0;


    // Update is called once per frame
    void Update()
    {
            Vector3 moveVector = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
            // transform.Translate(moveVector * speed * Time.deltaTime);

            rb.velocity = moveVector.normalized * speed * Time.deltaTime;
        
    }
}   