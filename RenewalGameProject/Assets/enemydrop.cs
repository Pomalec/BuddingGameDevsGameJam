using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemydrop : MonoBehaviour
{
    [SerializeField]
    private float chanceofdrop;

    private collectablespawner collectablespawner;
    private void Awake()
    {
        collectablespawner=FindObjectOfType<collectablespawner>();
    }

    public void randomdrop()
    {
        float rnd = Random.Range(0f, 1f);
        if (chanceofdrop>=rnd)
        {
            collectablespawner.spawncollectable(transform.position);
        }
    }
}
