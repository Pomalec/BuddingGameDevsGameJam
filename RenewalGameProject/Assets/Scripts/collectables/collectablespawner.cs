using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectablespawner : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> collectprehab;

    public void spawncollectable(Vector2 pos)
    {
        int index =Random.Range(0, collectprehab.Count);
        var selectedcol = collectprehab[index];

        Instantiate(selectedcol,pos,Quaternion.identity);
    }
}
