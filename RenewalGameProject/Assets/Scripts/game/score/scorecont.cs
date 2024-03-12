using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class scorecont : MonoBehaviour
{
    [SerializeField] GameObject upgrademenu;
    public UnityEvent onscorechange;

   
    // Start is called before the first frame update
    public int score {  get; private set; }

    public void addscore(int amount)
    {
        score += amount;
        onscorechange.Invoke();
        upgrademenu.SetActive(true);
        Time.timeScale = 0;
    }
   
}
