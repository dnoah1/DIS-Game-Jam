using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

	private int roundNumber = 1;

	public StringControllerOne stringControllerOne;
	public StringControllerTwo stringControllerTwo;



    // Start is called before the first frame update
    void Start()
    {
    	resetGame();

   	}

    // Update is called once per frame
    void Update()
    {
        
    }

    private void resetGame(){
    	stringControllerOne.initialize(roundNumber*5);
    	stringControllerTwo.initialize(roundNumber*5);
    	//other setup
    }

    public void increaseRound(){
    	roundNumber++;
    	if(roundNumber == 3){
    		endGame();
    		return;
    	}
    	resetGame();
    }

}
