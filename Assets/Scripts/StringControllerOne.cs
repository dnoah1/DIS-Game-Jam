using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringControllerOne : MonoBehaviour
{


	private bool readyToShoot = false;
	private Queue playerString = new Queue();
    private int stringLength;

    private System.Random rand = new System.Random();
    public PlayerOne playerOne;
    public GameObject[] objectArray;
    public Sprite[] spriteArray;

    private int currentLetter = 0;

    // Start is called before the first fr1ame update
    void Start()
    {
    	
    }

    public void initialize(int sl){
        currentLetter = 0;
        stringLength = sl;
        readyToShoot = false;
        playerString = createRandomString();
        resetAlpha();
        displayString(playerString);
    }

    // Update is called once per frame
    void Update()
    {

    	//WASD set correct input
        if(Input.GetKeyDown(KeyCode.W)){
            checkInput(0);
        }
        else if(Input.GetKeyDown(KeyCode.A)){
            checkInput(1);
        }
        else if(Input.GetKeyDown(KeyCode.S)){
            checkInput(2);
        }
        else if(Input.GetKeyDown(KeyCode.D)){
            checkInput(3);
        }
        else if(Input.GetKeyDown(KeyCode.LeftShift)){
            if(readyToShoot){
                playerOne.shoot();
            }
            else{
                this.reset();
            }
        }
   

    }

    //Creates a random string
    private Queue createRandomString(){
    	playerString = new Queue();
        
    	for(var i = 0; i < stringLength; i++){
            int n = rand.Next(4);
            playerString.Enqueue(n);
    	}

        return playerString;
    }

    private void displayString(Queue playerString)
    {

        Queue tmp = new Queue(playerString);

        for (var i = 0; i < stringLength; i++)
        {
            int number = (int)tmp.Dequeue();

            objectArray[i].GetComponent<SpriteRenderer>().sprite = spriteArray[number];
        }
        for(var i = stringLength; i < 15; i++){
            objectArray[i].GetComponent<SpriteRenderer>().sprite = null;
        }
    }


    private void checkInput(int correctInput)
    {

    	//Check if the input is correct
    	if(playerString.Dequeue().Equals(correctInput)){
    		if(playerString.Count == 0){ //no more characters
    			readyToShoot = true;
    		}

            Debug.Log(currentLetter);

            Color tmp = objectArray[currentLetter].GetComponent<SpriteRenderer>().color;
            tmp.a = 0.3f;
            objectArray[currentLetter].GetComponent<SpriteRenderer>().color = tmp;
            currentLetter += 1;
    		//update string sprite
    	}
    	else{ //wrong input
            Debug.Log("Wrong input");
    		reset();
    	}

    }

    private void resetAlpha(){
        for(var i = 0; i < stringLength; i++){
            Color tmp = objectArray[i].GetComponent<SpriteRenderer>().color;
            tmp.a = 1f;
            objectArray[i].GetComponent<SpriteRenderer>().color = tmp;
        }
    }


    private void reset(){
        currentLetter = 0;
    	playerString = createRandomString();
        displayString(playerString);
        resetAlpha();
        
    }

}
