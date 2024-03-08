using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

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
    private void Update()
    {
		inputh = Input.GetAxisRaw("Horizontal"); 
        inputv = Input.GetAxisRaw("Vertical");
		Setplayervelocity();
		rotationinput();
	}

    private void rotationinput() {
		Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
		Vector2 direction = new Vector2(mousePosition.x - transform.position.x, mousePosition.y - transform.position.y);
		float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
		transform.rotation = Quaternion.Euler(new Vector3(0, 0, angle - 90));
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
