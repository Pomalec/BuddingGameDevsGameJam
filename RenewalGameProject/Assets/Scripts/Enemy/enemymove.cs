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

    private Rigidbody2D _rigidbody;
    private playerawareness playerawarenesscont;
    private Vector2 targetdirection;
    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        playerawarenesscont=GetComponent<playerawareness>();
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
        if (playerawarenesscont.awareofplayer)
        {
            targetdirection = playerawarenesscont.directionplayer;
        }else
        {
            targetdirection = Vector2.zero;
        }
    }
    private void rotatetotarget()
    {
        if (targetdirection==Vector2.zero)
        {
            return;
        }
        Quaternion targetrot= Quaternion.LookRotation(transform.forward, targetdirection);
        Quaternion rot= Quaternion.RotateTowards(transform.rotation, targetrot, rotationspeed*Time.deltaTime);
        _rigidbody.SetRotation(rot);
    }
    private void setvelocity()
    {
        if (targetdirection==Vector2.zero)
        {
            _rigidbody.velocity = Vector2.zero;
        }
        else
        {
            _rigidbody.velocity = transform.up * speed;
        }
    }
}
