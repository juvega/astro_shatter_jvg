using UnityEngine;

public class AsteroidGenerator : MonoBehaviour
{
    public GameObject AsteroidePrefab;
    public Transform[] GeneradorPuntos;
    public float GenerationVelocity;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("AsteroidsGenerator", GenerationVelocity, 1f);
    }

    private void AsteroidsGenerator()
    {
        Instantiate(AsteroidePrefab, GeneradorPuntos[Random.Range(0, GeneradorPuntos.Length)].position, Quaternion.identity);
    }
}
