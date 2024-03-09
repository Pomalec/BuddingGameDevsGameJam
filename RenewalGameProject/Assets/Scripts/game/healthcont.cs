using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class health : MonoBehaviour
{
    [SerializeField]
    private float currenthealth;
    [SerializeField]
    private float maxhealth;

    // Start is called before the first frame update
    public float remaininghealth
    {
        get { return currenthealth / maxhealth; }
    }
    public void takedmg(float dmg)
    {
        if (currenthealth==0)
        {
            return;
        }
        currenthealth -= dmg;
        if (currenthealth < 0) { currenthealth = 0; }
        if (currenthealth==0)
        {
            died.Invoke();
        }
    }
    public UnityEvent died;
    public void addhealth(float amount) { if (currenthealth==maxhealth) {
            return;
} 
    currenthealth += amount;
        if (currenthealth>maxhealth)
        {
            currenthealth = maxhealth;
        }
    }
    
}
