using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HumanRacket : Racket
{

    public string axisName = "Vertical1";

    protected override void HareketEt()
    {
        float moveAxis = Input.GetAxis(axisName) * moveSpeed;
        GetComponent<Rigidbody2D>().velocity = new Vector2(0, moveAxis);
    }
}
