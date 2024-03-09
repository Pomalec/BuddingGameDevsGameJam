using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyattack : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float dmg;
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag=="Player")
        {
            var healthcont = collision.gameObject.GetComponent<health>();
            healthcont.takedmg(dmg);
        }
    }
}
