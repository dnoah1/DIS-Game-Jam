using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class Player2Animator : MonoBehaviour
{
    public Sprite[] shootAnimationFrames;
    public float framesPerSecond = 5;

    SpriteRenderer spriteRenderer;
    int currentFrameIndex = 0;
    float frameTimer;

    public bool shootAnimation = false;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        frameTimer = (1f / framesPerSecond);
        currentFrameIndex = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (shootAnimation)
        {
            frameTimer -= Time.deltaTime;
            Debug.Log(frameTimer);


            if (frameTimer <= 0)
            {
                Debug.Log("hey");
                currentFrameIndex++;
                if (currentFrameIndex >= shootAnimationFrames.Length)
                {
                    shootAnimation = false;
                    return;
                }
                frameTimer = (1f / framesPerSecond);
                spriteRenderer.sprite = shootAnimationFrames[currentFrameIndex];
            }
        }
    }
}
