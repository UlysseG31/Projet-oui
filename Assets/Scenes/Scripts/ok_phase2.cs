using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ok_phase2 : MonoBehaviour
{
    public GameObject phase2B;
    public GameObject phase2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMouseDown()
    {
        phase2B.SetActive(false);
        phase2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
