using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public GameObject hitSFX;

    public BallMovement ballMovement;
    public ScoreManager scoreManager;

    public void Bounce (Collision2D collision)
    {
        Vector3 ballPosition = transform.position;
        Vector3 racketPosition = collision.transform.position;
        float racketHeight = collision.collider.bounds.size.y;

        float positionX;
        if(collision.gameObject.name == " Player1 1")
        {
            positionX = 1;
        }


    else
        {
            positionX = -1;
        }

        float positionY = (ballPosition.y - racketPosition.y)/ racketHeight;

        ballMovement.IncreasehitCounter();
        ballMovement.MoveBall(new Vector2 (positionX, positionY));
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player 1" || collision.gameObject.name == "Player 2")
        {
            Bounce(collision);
        }

        else if(collision.gameObject.name == "RightBorder")
        {
            scoreManager.Player1Goal();
            ballMovement.Player1Start = false;
            StartCoroutine(ballMovement.Launch());

        }
        else if(collision.gameObject.name == "LeftBorder")
        {
            scoreManager.Player2Goal();
            ballMovement.Player1Start = true;
            StartCoroutine(ballMovement.Launch());
        }

        Instantiate(hitSFX, transform.position, transform.rotation);

    }





}
