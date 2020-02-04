using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerTwo: MonoBehaviour
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


    public void shoot()
    {

        AudioSource.PlayClipAtPoint(loadSound, transform.position);
        AudioSource.PlayClipAtPoint(shootSound, transform.position);
        AudioSource.PlayClipAtPoint(yeehawSound, transform.position);

        RaycastHit2D hit = Physics2D.Raycast(new Vector2(transform.position.x, transform.position.y), Vector2.left);
        GetComponent<SpriteRenderer>().sprite = shootingSprite;

        if (hit.collider != null)
        {

            Debug.Log("player hit!");
            //System.Threading.Thread.Sleep(2000)
            score += 1;
            updateScore(score);
            background.GetComponent<Game>().increaseRound();
            GetComponent<Player2Animator>().shootAnimation = true;
        }
    }

    public void stand(){
        GetComponent<Player2Animator>().shootAnimation = false;
        GetComponent<SpriteRenderer>().sprite = standingSprite;
    }

    public void updateScore(int score)
    {
        if(score == 3){
            background.GetComponent<Game>().increaseRound();
        }
        scoreObject.GetComponent<SpriteRenderer>().sprite = scoreSpriteArray[score];
    }

}
