using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerdminv : MonoBehaviour
{
    // Start is called before the first frame update
    private invincibiltycont invcont;
    [SerializeField]  
    private float invduration;
    public void Awake()
    {
        invcont=GetComponent<invincibiltycont>();
    }
    public void startinvcibilty()
    {
        invcont.startinvicibility(invduration);
    }
   
}
