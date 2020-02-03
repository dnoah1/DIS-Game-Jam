using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOne : MonoBehaviour
{

	private int score;
	public Sprite shootingSprite;
	public Sprite standingSprite;
	public Game gameScript;
	public float shootingDelay;

	
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<SpriteRenderer>().sprite = standingSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void shoot(){
    	RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y), Vector2.right);
    	GetComponent<SpriteRenderer>().sprite = shootingSprite;

    	if(hit.collider != null){
    		if(hit.collider.tag == "bullet"){
    			//yield return new WaitForSeconds(shootingDelay);
    			GetComponent<SpriteRenderer>().sprite = standingSprite;
    			gameScript.resetRound();
    		}
    		else{
    			Debug.Log("player hit!");
    			score += 1;
    			gameScript.increaseRound();
    		}
    	}
    }

}
