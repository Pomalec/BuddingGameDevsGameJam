using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invincibiltycont : MonoBehaviour
{
    private health healthcont;
    // Start is called before the first frame update
    private void Awake()
    {
        healthcont = GetComponent<health>();
    }
    public void startinvicibility(float duration)
    {
        StartCoroutine(invicibiltycoroutine(duration));
    }
    private IEnumerator invicibiltycoroutine(float duration)
    {
        healthcont.isinvicible = true;
        yield return new WaitForSeconds(duration);
        healthcont.isinvicible = false;
    }
}
