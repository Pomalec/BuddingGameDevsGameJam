using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthcolbehavoir : MonoBehaviour,Icollectablebehavoiur
{
    // Start is called before the first frame update
    [SerializeField]
    private float healthamount;
    public void uncollected(GameObject player)
    {
        player.GetComponent<health>().addhealth(healthamount);
    }
    
}
