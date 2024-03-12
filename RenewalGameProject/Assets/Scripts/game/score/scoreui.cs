using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreui : MonoBehaviour
{
    private TMP_Text scoretext;
    private void Awake()
    {
        scoretext = GetComponent<TMP_Text>();
    }
    public void Updatescore(scorecont scon)
    {
        scoretext.text = $"Kills:{scon.score}";
    }
}
