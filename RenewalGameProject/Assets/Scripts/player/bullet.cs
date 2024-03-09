using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            print("hooray");
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
        else
        {
            print(collision.gameObject.tag);
        }
    }
}
