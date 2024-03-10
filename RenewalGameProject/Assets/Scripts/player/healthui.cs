using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class healthui : MonoBehaviour
{
    [SerializeField]
    private UnityEngine.UI.Image healthbarforeground;
    public void updatehealth(health healthcont)
    {
        healthbarforeground.fillAmount = healthcont.remaininghealth;
    }
}
