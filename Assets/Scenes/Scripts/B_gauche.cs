using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class B_gauche : MonoBehaviour
{
    public GameObject cam;
    public GameObject bouton1;
    public GameObject bouton2;
    public GameObject hitbox;
    public Vector3 camera1 = new Vector3(-109.31f, 102.5f, -125.45f);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void OnMouseDown()
    {
        cam.transform.position = camera1;
        bouton2.SetActive(true);
        bouton1.SetActive(false);
        hitbox.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
