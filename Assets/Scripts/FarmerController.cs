using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class FarmerController : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody2D rb;
    private float moveSpeed = 5f;
    private float boundary = 10f;
    private float fancingDerection = 1f;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        Vector3 moveDirection = new Vector3(moveInput, 0, 0);
        transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        Vector3 Currentposition = transform.position;

        if (Currentposition.x < -boundary)
        {
            Currentposition.x = -boundary;
        }
        else if (Currentposition.x > boundary)
        {
            Currentposition.x = boundary;
        }                                                
        if (Input.GetKey(KeyCode.A))
        {
            fancingDerection = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            fancingDerection = 1;
        }
        Vector3 newScale = transform.localScale;
        newScale.x = fancingDerection;
        transform.localScale = newScale;
        transform.position = Currentposition;
    }
}
                    