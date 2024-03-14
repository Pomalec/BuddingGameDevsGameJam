using UnityEngine;

public class playershoot : MonoBehaviour
{
    [SerializeField]
    private GameObject bulletprehab;

    
    private float bulletspeed=5;

    [SerializeField]
    private Transform gunoffset;

    [SerializeField]
    private float timebetween;

    [SerializeField] 
    private float destroyTime = 5;

    private float lasttimefire;

 

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            float timesincelast=Time.time-lasttimefire;
            if (timesincelast > timebetween)
            {
                firebullet();
                lasttimefire = Time.time;
            }
        }
    }

    private void firebullet()
    {
        GameObject bullet=Instantiate(bulletprehab,gunoffset.position,transform.rotation);
        
        Rigidbody2D rb=bullet.GetComponent<Rigidbody2D>();
		
		rb.velocity = bulletspeed*transform.up;
		Destroy(bullet, destroyTime);
	}

	public void upgrade()
    {
        bulletspeed += 5;

    }
}
