using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    
    public static GameManager Instance;
    public GameState state;
    //public static event Action<GameState> onGameStateChange;

    private void Awake()
    {
        if(Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }
    }

    void Start()
    {
        UpdateGameState(GameState.exploration);
    }
    
    public void UpdateGameState(GameState newState)
    {
        switch (newState)
        {
            case GameState.exploration:
                //function call
                break;
            case GameState.treeRootRest:
                //function call
                break;
            case GameState.playerDeath:
                //function call
                break;
            case GameState.merchantInteraction:
                //function call
                break;
            case GameState.bossEncounter:
                //function call
                break;
        }

        //onGameStateChange(newState);

    }

    public enum GameState
    {
        exploration,
        treeRootRest,
        merchantInteraction,
        playerDeath,
        bossEncounter
    }
}
