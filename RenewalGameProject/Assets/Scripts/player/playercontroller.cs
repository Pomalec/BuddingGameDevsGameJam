using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playercontroller : MonoBehaviour
{
    Rigidbody2D rb;
    float walkspeed = 4f;
    float speedlimiter = 0.7f;
    float inputh;
    float inputv;
    [SerializeField]
    private float rotation;
    // Start is called before the first frame update
    void Start()
    {
        rb=gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        inputh = Input.GetAxisRaw("Horizontal"); 
        inputv = Input.GetAxisRaw("Vertical");
    }
    void FixedUpdate()
    {
        Setplayervelocity();
        rotationinput();
    }
    private void rotationinput() {
        if (inputh != 0 || inputv != 0)
        {
            Quaternion targetrot = Quaternion.LookRotation(transform.forward, rb.velocity);
            Quaternion rotation=Quaternion.RotateTowards(transform.rotation, targetrot, speedlimiter*Time.deltaTime);

            rb.MoveRotation(rotation);
        }
    }
    private void Setplayervelocity()
    {
        if (inputh != 0 || inputv != 0)
        {
            if (inputh != 0 && inputv != 0)
            {
                inputh *= speedlimiter;
                inputv *= speedlimiter;
            }
            rb.velocity = new Vector2(inputh * walkspeed, inputv * walkspeed);
        }
        else { rb.velocity = new Vector2(0f, 0f); }
    }
}
