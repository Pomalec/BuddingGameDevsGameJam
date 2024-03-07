using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class playershoot : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletprehab;

    [SerializeField]
    private float bulletspeed;

    [SerializeField]
    private Transform gunoffset;

    [SerializeField]
    private float timebetween;
    private float lasttimefire;
    private bool firecontinuosly;
    // Start is called before the first frame update
 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float timesincelast=Time.time-lasttimefire;
            if (timesincelast > timebetween)
            {
                firebullet();
                lasttimefire = Time.time;
            }
        }
    }

    private void firebullet()
    {
        GameObject bullet=Instantiate(bulletprehab,gunoffset.position,transform.rotation);
        Rigidbody2D rb=bullet.GetComponent<Rigidbody2D>();

        rb.velocity = bulletspeed*transform.up;
    }

    private void onfire()
    {
       
    }
}
