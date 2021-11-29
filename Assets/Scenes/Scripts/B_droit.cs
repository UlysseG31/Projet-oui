using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class B_droit : MonoBehaviour
{
    public GameObject cam;
    public GameObject bouton1;
    public GameObject bouton2;
    public GameObject pierre_needed;
    public GameObject pierre_used;
    public GameObject txt_carriere;
    public GameObject txt_arene;
    public GameObject hitbox;
    public Vector3 camera2 = new Vector3(-106f, 21.8f, 34.7f);
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnMouseDown()
    {
        cam.transform.position = camera2;
        bouton1.SetActive(true);
        bouton2.SetActive(false);
        hitbox.SetActive(false);
        pierre_needed.SetActive(false);
        pierre_used.SetActive(false);
        txt_carriere.SetActive(true);
        txt_arene.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
