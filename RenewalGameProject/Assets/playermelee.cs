using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class playermelee : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float dmg;
    public UnityEvent attackback;
    public UnityEvent attackbackd;
    [SerializeField]
    private float timebetween;
    private float lasttimepunch;

    private bool punchactive;
    private void Awake()
    {
        dmg = 20;
        punchactive = false;
    }
    private void Update()
    {
        if (Input.GetMouseButton(1))
        {
            float timesincelast = Time.time - lasttimepunch;
            if (timesincelast > timebetween)
            {
                punchactive = true;
                lasttimepunch = Time.time;
            }
        }
    }

   
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (punchactive)
        {
            if (collision.gameObject.tag == "Enemy")
            {
                attackback.Invoke();
                var healthcont = collision.gameObject.GetComponent<health>();
                healthcont.takedmg(dmg);
                attackbackd.Invoke();
            }
            punchactive=false;
        }

        
    }
}

