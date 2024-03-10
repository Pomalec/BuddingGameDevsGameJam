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
    public bool isinvicible {  get; set; }
    public UnityEvent Ondamaged;
    public UnityEvent onhealthchanged;
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
        if (isinvicible) { return; }
        currenthealth -= dmg;
        onhealthchanged.Invoke();
        if (currenthealth < 0) { currenthealth = 0; }
        if (currenthealth==0)
        {
            died.Invoke();
            
        }else
        {
            Ondamaged.Invoke();
        }
        
    }
    //just used for the enemies
    public void kys()
    {
        Destroy(gameObject);
    }
    public UnityEvent died;
    public void addhealth(float amount) { if (currenthealth==maxhealth) {
            return;
} 
    currenthealth += amount;
        onhealthchanged.Invoke();
        if (currenthealth>maxhealth)
        {
            currenthealth = maxhealth;
        }
        
    }
    
}
