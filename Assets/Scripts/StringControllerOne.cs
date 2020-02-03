using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringControllerOne : MonoBehaviour
{


	private bool readyToShoot = false;
	private Stack playerString = new Stack();


    // Start is called before the first frame update
    void Start()
    {
    	
    }

    void initialize(stringLength){
        readyToShoot = false;
        playerString = createRandomString();
    }

    // Update is called once per frame
    void Update()
    {
    	if(Input.anyKey){
    		checkInput();   
    	}
    }

    //Creates a random string
    private String createRandomString(){
    	playerString = new Stack();

    	foreach(var i in stringLength){
    		playerString.Push(Random.Next(4));
    	}
    }

    private void checkInput(){
    	private int correctInput;

    	//WASD set correct input
    	if(Input.GetKeyDown(KeyCode.W)){
    		correctInput = 0;
    	}
    	else if(Input.GetKeyDown(KeyCode.A)){
    		correctInput = 1;
    	}
    	else if(Input.GetKeyDown(KeyCode.S)){
    		correctInput = 2;
    	}
    	else if(Input.GetKeyDown(KeyCode.D){
    		correctInput = 3;
    	}
    	else if(Input.GetKeyDown(KeyCode.LeftShift)){
    		if(readyToShoot){
    			//Player.shoot
    		}
    		else{
    			reset();
    		}
    	}
    	else{
    		correctInput = -1;
    	}

    	//Check if the input is correct
    	if(playerString.Pop() == correctInput){
    		if(playerString.Count == 0){ //no more characters
    			readyToShoot = true;
    		}

    		//update string sprite
    	}
    	else{ //wrong input
    		reset();
    	}

    }


    private void reset(){
    	createRandomString();
    }

}
