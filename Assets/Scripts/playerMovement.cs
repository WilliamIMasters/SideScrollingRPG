using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public float speed = 10f;

    private Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetAxisRaw("Horizontal") >= 0.2f)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        } else if(Input.GetAxisRaw("Horizontal") <= -0.2f)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }

    private void FixedUpdate()
    {
        if (Mathf.Abs(Input.GetAxisRaw("Horizontal")) >= 0.25f)
        {
            rb.MovePosition(transform.position + transform.right * Time.fixedDeltaTime * speed * Input.GetAxis("Horizontal"));
        }
    }
}
