using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Racket solRaket, sagRaket;
    Rigidbody2D rb2;
    public float moveSpeed=10; //topun değerini daha sonra yarlayabilelim diye
    // Start is called before the first frame update
    void Start()
    {
        rb2 = GetComponent<Rigidbody2D>();  //(değişkene atama yaptık) buna ait olan rigidboy'i al demektir.
        //rb2 =gameObject.GetComponent<Rigidbody2D>(); şeklindede yapılabilir. //Bu objeye ait olan component'i al demek.
        rb2.velocity = new Vector2(1, 0)*moveSpeed;
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)// collision topun çarptığı obje neyse o
    {
        TagManager tagManager = collision.gameObject.GetComponent<TagManager>(); //çarpılan objenin game objesinin componentini alıcaz, yoksa null değder döndürücek.

        GetComponent<AudioSource>().Play();

        if (tagManager == null) return;
        Tag tag = tagManager.myTag;

        if(tag.Equals(Tag.SAG_DUVAR))  //if(tag == Tag.SAG_DUVAR) da yazılabilirdi. Equals daha hızlıdır.
        {
            //sol raket skor yapıcak.
            solRaket.SkorYap();
        }

        else if (tag.Equals(Tag.SOL_DUVAR))
        {
            //sağ raket skor yapıcak.
            sagRaket.SkorYap();
        }

      
        if(tag.Equals(Tag.SAG_RAKET))
        {
            DonusYonHesapla(collision, -1);

        }

        else if (tag.Equals(Tag.SOL_RAKET))
        {
            DonusYonHesapla(collision, +1);
        }

    }

    private void DonusYonHesapla(Collision2D collision, int x)
    {
        float a = transform.position.y - collision.gameObject.transform.position.y; // topun y si (-) raketin y si
        float b = collision.collider.bounds.size.y;  // raketin büyüklüğü
        float y = a / b;
        rb2.velocity = new Vector2(x, y) * moveSpeed;
    }
}
