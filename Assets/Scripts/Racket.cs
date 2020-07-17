using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //arayüz kütüphanesi

public abstract class Racket : MonoBehaviour
{

    public float moveSpeed = 10;
    public Text scoreText; // skorun yazılacağı yerdeki obje

    public int Score { get; private set; }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate() //update yerine fixedupdate yaptık. Çünkü rigidbody ile ilgili işler yapıyoruz.
    {
        HareketEt();

    }

    protected abstract void HareketEt();
    
    public void SkorYap()
    {
        Score++;
        scoreText.text = Score.ToString(); // int bir değer olduğu için text'e çevirmem gerek, o yüzden ToString() yazdık.
    }


}
