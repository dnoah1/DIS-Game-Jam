using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerOne : MonoBehaviour
{

	public int score;
	public Sprite shootingSprite;
	public Sprite standingSprite;
	public GameObject background;
	public float shootingDelay;
    public AudioClip loadSound;
    public AudioClip shootSound;
    public AudioClip yeehawSound;

    public GameObject scoreObject;
    public Sprite[] scoreSpriteArray;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        GetComponent<SpriteRenderer>().sprite = standingSprite;
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void shoot(){

        AudioSource.PlayClipAtPoint(loadSound, transform.position);
        AudioSource.PlayClipAtPoint(shootSound, transform.position);
        AudioSource.PlayClipAtPoint(yeehawSound, transform.position);


        RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y), Vector2.right);
    	GetComponent<SpriteRenderer>().sprite = shootingSprite;

        if (hit.collider != null)
        {

            Debug.Log("player hit!");
            score += 1;
            updateScore(score);
            background.GetComponent<Game>().increaseRound();
            GetComponent<Player1Animator>().shootAnimation = true;
        }

        Debug.Log(GetComponent<Player1Animator>().shootAnimation);
    }   

    public void updateScore(int score)
    {
        scoreObject.GetComponent<SpriteRenderer>().sprite = scoreSpriteArray[score];
    }
    
}
