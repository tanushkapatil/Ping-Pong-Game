using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class BallBounce : MonoBehaviour
{
    public BallMovement ballMovement ;

    private void Bounce(Collision2D collision) {
        Vector3 ballPosition  = transform.position ;
        Vector3 racketPosition = collision.transform.position ;
        float racketHeight = collision.collider.bounds.size.y ;
        
        float positionX ;
        if(collision.gameObject.name == "Player1") {
            positionX = 1 ;
        }
        else {
            positionX = -1 ;
        }

        float positionY = (ballPosition.y - racketPosition.y) / racketHeight ;

        ballMovement.IncreaseHitCounter() ;
        ballMovement.MoveBall(new Vector2(positionX, positionY)) ;
    }

    private void OnCollisionEnter2D(Collision2D collision) {
        if(collision.gameObject.name == "Player1" || collision.gameObject.name == "Player2") {
            Bounce(collision) ;
        }
    }
}
