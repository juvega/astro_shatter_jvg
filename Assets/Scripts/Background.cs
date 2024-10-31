using UnityEngine;

public class Background : MonoBehaviour
{
    public float Velocity;
    private Renderer space;
    void Start()
    {
        space = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(0, Velocity * Time.deltaTime);
        space.material.mainTextureOffset += movement;
    }
}
