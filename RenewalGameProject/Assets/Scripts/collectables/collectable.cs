using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectable : MonoBehaviour
{
    private Icollectablebehavoiur colbe;
    private void Awake()
    {
        colbe=GetComponent<Icollectablebehavoiur>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        var player = collision.GetComponent<playercontroller>();
        if (player!=null)
        {
            colbe.uncollected(player.gameObject);
            Destroy(gameObject);
        }
    }
}
