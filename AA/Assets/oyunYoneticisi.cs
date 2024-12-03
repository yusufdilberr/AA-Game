using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class oyunYoneticisi : MonoBehaviour
{
    GameObject anaCember;

    GameObject donenCember;

    public Animator animator;
    

    void Start()
    {
        anaCember = GameObject.FindGameObjectWithTag("anaCember");
        donenCember = GameObject.FindGameObjectWithTag("donenCember");
        
    }

    
    void Update()
    {
        
    }
    public void OyunBitti()
    {
        //Debug.Log("oyun bitti");

        donenCember.GetComponent<donenCemberKod>().enabled= false;
        //
        anaCember.GetComponent<anaCemberkod>().enabled= false;
        animator.SetTrigger("oyunbitti");
        
    }
    public void OyunKazandý()
    {
        Debug.Log("oyun kazandý");
        Time.timeScale = 0;
    }

}
