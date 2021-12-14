using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class B_droit_2 : MonoBehaviour
{
    public GameObject cam;
    public GameObject boutonD2;
    public GameObject boutonG;
    public GameObject pierreT;
    public GameObject Taille1;
    public GameObject Taille2;
    public GameObject Taille3;
    public GameObject Taille4;
    public GameObject boutonG2;
    public GameObject txt_carriere;
    public Vector3 camera2 = new Vector3(-206f, 21.8f, 34.7f);
    // Start is called before the first frame update
    void Start()
    {

    }
    public void OnMouseDown()
    {
        cam.transform.position = camera2;
        boutonD2.SetActive(false);
        boutonG.SetActive(false);
        txt_carriere.SetActive(false);
        boutonG2.SetActive(true);
        Taille1.SetActive(true);
        Taille2.SetActive(true);
        Taille3.SetActive(true);
        Taille4.SetActive(true);
        pierreT.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}