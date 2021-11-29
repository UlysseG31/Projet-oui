using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class B_gauche : MonoBehaviour
{
    public GameObject cam;
    public GameObject bouton1;
    public GameObject bouton2;
    public GameObject pierre_needed;
    public GameObject pierre_used;
    public GameObject txt_carriere;
    public GameObject txt_arene;
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
        pierre_needed.SetActive(true);
        pierre_used.SetActive(true);
        txt_carriere.SetActive(false);
        txt_arene.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
