using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class anaCemberkod : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject kucukCember;

    public GameObject donenCember;

    public GameObject anaCember_;

    public int atisSayisi = 8;

    public GameObject oyunuYöneticisi;


    void Start()
    {
        oyunuYöneticisi = GameObject.FindGameObjectWithTag("oyunYoneticisi");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(kucukCember,transform.position,transform.rotation);

            for (int i = 0; i < transform.childCount; i++)
            {
                int sayi = Convert.ToInt32(transform.GetChild(i).GetComponentInChildren<Text>().text);
                sayi--;
                
                if (sayi > 0)
                {
                 transform.GetChild(i).GetComponentInChildren<Text>().text = sayi.ToString();
                }
                else
                {
                    Destroy(transform.GetChild(i).gameObject);
                }
                
            }
            atisSayisi--;
            if (atisSayisi == 0)
            {
                oyunuYöneticisi.transform.GetComponent<oyunYoneticisi>().OyunKazandý();
            }
        }
    }
        
    
}
