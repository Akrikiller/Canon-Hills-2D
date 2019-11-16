using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public enum GameState{start,building, shooting, waiting, transition}
    private int currentPlayer;
    GameState currentPhase = GameState.start;
    private float timeToNextPhase;
    // Start is called before the first frame update
    void Start()
    {
        currentPlayer = 0;
        startNextPhase();
        
    }

    // Update is called once per frame
    void Update()
    {
        timeToNextPhase -= Time.deltaTime;
        if(timeToNextPhase <= 0)
        startNextPhase();
    }

    public void startNextPhase(){
        switch (currentPhase)
      {
          case GameState.start:
          currentPlayer = 1;
              startBuildingPhase(currentPlayer);
              break;
          case GameState.building:
              startShootingPhase(currentPlayer);
              break;
          case GameState.shooting:
              startTransitioningPhase(currentPlayer);
              break;

      }
   
        
    }

    public void startBuildingPhase(int currentPlayer){
        timeToNextPhase = 30;

    }
    public void startTransitioningPhase(int currentPlayer)
    {
        timeToNextPhase= 5;
    }
    public void startShootingPhase(int currentPlayer){
        timeToNextPhase = 15;

    }
}
