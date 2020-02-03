using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringControllerOne : MonoBehaviour
{


	private bool readyToShoot = false;
	private Stack playerString = new Stack();
    private int stringLength = 0;
    private System.Random rand = new System.Random();
    public PlayerOne playerOne;

    // Start is called before the first frame update
    void Start()
    {
    	
    }

    public void initialize(int sl){
        readyToShoot = false;
        playerString = createRandomString();
        stringLength = sl;
    }

    // Update is called once per frame
    void Update()
    {
    	if(Input.anyKey){
    		checkInput();   
    	}
    }

    //Creates a random string
    private Stack createRandomString(){
    	playerString = new Stack();
        
    	for(var i = 0; i < stringLength; i++){
            playerString.Push(rand.Next(4));
    	}

        return playerString;
    }

    private void checkInput()
    {

        int correctInput = -1;

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
    	else if(Input.GetKeyDown(KeyCode.D)){
    		correctInput = 3;
    	}
    	else if(Input.GetKeyDown(KeyCode.LeftShift)){
    		if(readyToShoot){
                playerOne.shoot();
    		}
    		else{
    			reset();
    		}
    	}
    	

    	//Check if the input is correct
    	if(playerString.Pop().Equals(correctInput)){
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
