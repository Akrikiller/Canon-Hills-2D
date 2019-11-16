using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplicationStateManager : MonoBehaviour
{

    enum ApplicationState {menue, singlePlayerGame,endOfGame};
   
   private ApplicationState currentApplicationState;
    
    // Start is called before the first frame update
    void Start()
    {
        setApplicationState(ApplicationState.singlePlayerGame);
        
    }

    // Update is called once per frame
    void setApplicationState(ApplicationState newApplicationState){
        currentApplicationState = newApplicationState;
    }
   
}
