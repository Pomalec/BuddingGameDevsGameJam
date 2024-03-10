using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bullet : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float dmg;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            var healthcont = collision.gameObject.GetComponent<health>();
            healthcont.takedmg(dmg);
          
            Destroy(gameObject);
        }
       
    }
}
