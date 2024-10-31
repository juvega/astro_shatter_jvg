using UnityEngine;

public class ShipMovement : MonoBehaviour
{
    public float Velocity = 0;
    public GameObject shootPrefab;            

    Vector3 posTemp;
    float dirX, dirY;
    Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();                
    }

    // Update is called once per frame
    void Update()
    {
        positionMovement();
    }
    private void positionMovement()
    {
        posTemp = transform.position;
        dirX = Input.GetAxis("Horizontal");
        dirY = Input.GetAxis("Vertical");
        posTemp.x += dirX * Velocity * Time.deltaTime;
        posTemp.y += dirY * Velocity * Time.deltaTime;
        this.transform.position = posTemp;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(shootPrefab, transform.position, Quaternion.identity);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Asteroid")
        {            
            Destroy(collision.gameObject);
            Invoke("ShipDestroy", 0.2f);
        }
    }

    private void ShipDestroy()
    {
        Destroy(gameObject);
    }
}
