using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerawareness : MonoBehaviour
{
    // Start is called before the first frame update
    public bool awareofplayer { get; private set; }

    public Vector2 directionplayer { get; private set; }

    [SerializeField]
    private float playerawaredist;


    [SerializeField]
    private Vector3 playerdist;
    private Transform player;

    private void Awake()
    {
        player=FindObjectOfType<playercontroller>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 enemytoplayer= player.position-transform.position;
        directionplayer = enemytoplayer.normalized;

        if (enemytoplayer.magnitude<=playerawaredist)
        {
            awareofplayer = true;
        }
        else
        {
            awareofplayer = false;
        }
    }
}
