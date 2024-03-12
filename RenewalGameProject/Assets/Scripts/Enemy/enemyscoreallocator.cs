using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyscoreallocator : MonoBehaviour
{
    [SerializeField]
    private int killscore;

    private scorecont scorec;

    private void Awake()
    {
        scorec=FindAnyObjectByType<scorecont>();
    }
  public void allocatescore()
    {
        scorec.addscore(killscore);
    }
}
