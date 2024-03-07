using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<enemymove>())
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
