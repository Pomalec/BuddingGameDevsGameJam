using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyspwaner : MonoBehaviour
{
    [SerializeField]
    private GameObject enemyprehab;
    // Start is called before the first frame update
    [SerializeField]
    private float minspwantime;
    [SerializeField]
    private float maxspwantime;

    private float timeuntilspawn;
    private void Awake()
    {
        settimeuntilspawn();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeuntilspawn-=Time.deltaTime;
        if (timeuntilspawn<=0)
        {
            Instantiate(enemyprehab, transform.position, Quaternion.identity);
            settimeuntilspawn();
        }
    }
    private void settimeuntilspawn() { 
        timeuntilspawn=Random.Range(minspwantime,maxspwantime);
    }
}
