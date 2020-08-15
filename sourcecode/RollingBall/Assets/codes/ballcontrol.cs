using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballcontrol : MonoBehaviour
{
    Rigidbody phy;
    public int speed;
    public int toplanacakobjesayisi;
    int sayac = 0;

    public Text oyunbittiText;
    public Text sayacText;
    // Start is called before the first frame update
    void Start()
    {
        phy = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float hor = Input.GetAxisRaw("Horizontal");
        float ver = Input.GetAxisRaw("Vertical");

        Vector3 vec = new Vector3(hor, 0, ver);

        phy.AddForce(vec*speed);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "engel")
        {
            //Destroy(other.gameObject);
            other.gameObject.SetActive(false);
            sayac++;
            sayacText.text = "" + sayac;
        }

        if (sayac == toplanacakobjesayisi)
        {
            oyunbittiText.text = "OYUN BİTTİ";
        }
    }
}
