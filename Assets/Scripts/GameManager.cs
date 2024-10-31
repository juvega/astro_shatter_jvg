using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public enum GameState { PREPARADO, JUGANDO, COMPLETADO, GAMEOVER }
    public GameState state;    

    public GameObject player;
    public GameObject generadorAsteroides;
    

    // Start is called before the first frame update
    void Start()
    {
        state = GameState.PREPARADO;
    }

    // Update is called once per frame
    void Update()
    {
        switch (state)
        {
            case GameState.PREPARADO:                
                player.SetActive(false);
                generadorAsteroides.SetActive(false);                

                if (Input.GetKeyDown(KeyCode.Space))
                {
                    state = GameState.JUGANDO;
                    player.SetActive(true);
                    generadorAsteroides.SetActive(true);
                }
                break;
            case GameState.JUGANDO:                               
            case GameState.COMPLETADO:                
                generadorAsteroides.SetActive(false);                
                break;
            case GameState.GAMEOVER:                
                generadorAsteroides.SetActive(false);                
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    SceneManager.LoadScene(0);
                }
                break;
            default:
                break;
        }
    }
}
