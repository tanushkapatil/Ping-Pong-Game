using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMovement : MonoBehaviour
{
    public float startSpeed ;
    public float extraSpeed ;
    public float maxExtraSpeed ;
    private int hitCounter ;
    private Rigidbody2D rb ;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>() ;
    }

    public IEnumerator Launch () {
        hitCounter = 0 ;
        yield return new WaitForSeconds(1) ;
    }
    public void MoveBall(Vector2 direction) {
        direction = direction.normalized ;
        float ballSpeed = startSpeed + hitCounter * extraSpeed ;
        rb.velocity = direction * ballSpeed ;
    }


}
