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
    public AudioClip music;



    // Start is called before the first frame update
    void Start()
    {
        AudioSource.PlayClipAtPoint(music, transform.position);
        stringControllerOne = gameObject1.GetComponent<StringControllerOne>();
        stringControllerTwo = gameObject2.GetComponent<StringControllerTwo>();
        resetGame();

   	}

    // Update is called once per frame
    void Update()
    {
        
    }

    private void resetGame(){
        int numberOfLetters = roundNumber*5;
        if(numberOfLetters > 15){ numberOfLetters = 15; }
    	stringControllerOne.initialize(numberOfLetters);
    	stringControllerTwo.initialize(numberOfLetters);
    	//other setup
    }

    public void increaseRound(){
    	roundNumber++;

    	// if(roundNumber == 4){
    	// 	endGame();
    	// 	return;
    	// }
    	resetGame();
    }

    public void resetRound(){
        resetGame();
    }

    private void endGame(){
        //exit
    }
}
