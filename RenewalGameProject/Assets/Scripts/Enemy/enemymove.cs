using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemymove : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField]
    private float speed;
    [SerializeField]
    private float rotationspeed;
    [SerializeField]
    private float levelborder;
    private Rigidbody2D _rigidbody;
    private playerawareness playerawarenesscont;
    private Vector2 targetdirection;
    [SerializeField]
    private float chnagedirectioncooldown;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        playerawarenesscont=GetComponent<playerawareness>();
        // float rnd = Random.Range(0f, 1f);
        // switch(rnd) {
        //     case 0:
        //         targetdirection = transform.up;break;
        //     case 1:
        //         targetdirection = transform.right; break;
        //    
        // }
        targetdirection = transform.up;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        updatetargetdirection();
        rotatetotarget();
        setvelocity();
    }

    private void updatetargetdirection()
    {
        rnddirection();
       handleplayertarget();
    }
    private void rnddirection()
    {
        chnagedirectioncooldown-=Time.deltaTime;
        if (chnagedirectioncooldown<=0)
        {
            float anglechange = Random.Range(-90f, 90f);
            Quaternion rot = Quaternion.AngleAxis(anglechange, transform.forward);
            targetdirection = rot * targetdirection;
            chnagedirectioncooldown = Random.Range(1f, 5f);
        }
    }
    private void handleplayertarget()
    {
        if (playerawarenesscont.awareofplayer)
        {
            targetdirection = playerawarenesscont.directionplayer;
        }
       
    }
    private void rotatetotarget()
    {
       
        Quaternion targetrot= Quaternion.LookRotation(transform.forward, targetdirection);
        Quaternion rot= Quaternion.RotateTowards(transform.rotation, targetrot, rotationspeed*Time.deltaTime);
        _rigidbody.SetRotation(rot);
    }
    private void setvelocity()
    {
        
            _rigidbody.velocity = transform.up * speed;
        
    }
}
