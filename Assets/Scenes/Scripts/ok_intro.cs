using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ok_intro : MonoBehaviour
{
    public GameObject okIntro;
    public GameObject Intro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMouseDown()
    {
        okIntro.SetActive(false);
        Intro.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
