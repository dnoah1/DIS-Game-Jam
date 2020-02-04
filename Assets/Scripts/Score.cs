using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Sprite[] numberSprites;
    private GameObject playerOne;
    private GameObject playerTwo;
    private int playerOneScore;
    private int playerTwoScore;

    public GameObject playerOneSprite;
    public GameObject playerTwoSprite;

    // Start is called before the first frame update
    void Start()
    {
        playerOne = GameObject.FindGameObjectWithTag("PlayerOne");
        playerTwo = GameObject.FindGameObjectWithTag("PlayerTwo");

        playerOneScore = playerOne.GetComponent<PlayerOne>().score;
        playerTwoScore = playerTwo.GetComponent <PlayerTwo>().score;



        if(playerOneScore == 0)
        {
            Debug.Log(playerOneScore);
            playerOneSprite.GetComponent<SpriteRenderer>().sprite = numberSprites[0];
        }
        else if(playerOneScore == 1){
            playerOneSprite.GetComponent<SpriteRenderer>().sprite = numberSprites[1];
        }
        else if (playerOneScore == 2)
        {
            playerOneSprite.GetComponent<SpriteRenderer>().sprite = numberSprites[2];
        }
        else if (playerOneScore == 3)
        {
            playerOneSprite.GetComponent<SpriteRenderer>().sprite = numberSprites[3];
        }


        if (playerTwoScore == 0)
        {
            playerTwoSprite.GetComponent<SpriteRenderer>().sprite = numberSprites[0];
        }
        else if (playerOneScore == 1)
        {
            playerTwoSprite.GetComponent<SpriteRenderer>().sprite = numberSprites[1];
        }
        else if (playerOneScore == 2)
        {
            playerTwoSprite.GetComponent<SpriteRenderer>().sprite = numberSprites[2];
        }
        else if (playerOneScore == 3)
        {
            playerTwoSprite.GetComponent<SpriteRenderer>().sprite = numberSprites[3];
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
