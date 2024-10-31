using UnityEngine;

public class AsteroidMovement : MonoBehaviour
{
    public float RotationMinVelocity = 45f;
    public float RotationMaxVelocity = 100f;
    public float RotationVelocity;

    public float GravityMinScale = 0.1f;
    public float GravityMaxScale = 0.5f;
    public float GravityScale;

    public float MinSize = 2f;
    public float MaxSize = 12f;

    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        valoresAleatorios();
        Destroy(gameObject, 12f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, RotationVelocity * Time.deltaTime);
    }

    private void valoresAleatorios()
    {
        float randomScale = Random.Range(MinSize, MaxSize);
        this.transform.localScale = new Vector3(randomScale, randomScale, randomScale);

        RotationVelocity = Random.Range(RotationMinVelocity, RotationMaxVelocity);

        rb.gravityScale = Random.Range(GravityMinScale, GravityMaxScale);
    }
}
