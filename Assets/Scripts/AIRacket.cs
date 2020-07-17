using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIRacket : Racket
{
    public Transform ball; // Bana sadece topun konumu lazım. Ekstra bilgiler de isteseydim Ball olarak alabilirdim, Transform olarak değil.
    protected override void HareketEt()
    {
        float mesafe = Mathf.Abs(ball.position.y - transform.position.y); // Bu bize dikey farkı vericektir.
        if(mesafe > 3)
        {
            if(ball.position.y > transform.position.y) //eğer top yukarıdaysa
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, 1) * moveSpeed;
                // GetComponent<Rigidbody2D>().velocity = new Vector2(0, moveSpeed); şeklinde de yazabilirdik çünkü vektör*skaler vektörü vericektir. İkisi de aynı şey.
            }
            else
            {
                GetComponent<Rigidbody2D>().velocity = new Vector2(0, -1) * moveSpeed;

            }
        }
        
    }

}
