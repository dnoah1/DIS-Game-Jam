using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game : MonoBehaviour
{

	private int roundNumber = 1;

	public GameObject gameObject1;
	public GameObject gameObject2;
    private StringControllerOne stringControllerOne;
    private StringControllerTwo stringControllerTwo;



    // Start is called before the first frame update
    void Start()
    {
        stringControllerOne = gameObject1.GetComponent<StringControllerOne>();
        stringControllerTwo = gameObject2.GetComponent<StringControllerTwo>();
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

    public void resetRound(){
        resetGame();
    }

    private void endGame(){
        //exit
    }
}
