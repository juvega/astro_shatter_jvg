using UnityEngine;

public class Shoot : MonoBehaviour
{
    public float ShootVelocity;        
    void Start()
    {
        Destroy(gameObject, 5f);        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * ShootVelocity * Time.deltaTime;
    }

    private void OnCollisionEnter2D(Collision2D objectCollition)
    {
        if (objectCollition.gameObject.tag == "Asteroid")        
        {            
            Destroy(objectCollition.gameObject);
            Invoke("destroyShoot", 0.2f);
        }
    }

    private void destroyShoot()
    {
        Destroy(gameObject);
    }
}
