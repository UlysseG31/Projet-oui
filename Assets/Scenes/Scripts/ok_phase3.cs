using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ok_phase3 : MonoBehaviour
{
    public GameObject phase3B;
    public GameObject phase3;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void OnMouseDown()
    {
        phase3B.SetActive(false);
        phase3.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}