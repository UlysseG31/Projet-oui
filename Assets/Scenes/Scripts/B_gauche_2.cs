using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class B_gauche_2 : MonoBehaviour
{
    public GameObject cam;
    public GameObject boutonD2;
    public GameObject boutonG2;
    public GameObject boutonG;
    public GameObject Taille1;
    public GameObject Taille2;
    public GameObject Taille3;
    public GameObject Taille4;
    public GameObject pierreT;
    public GameObject txt_carriere;
    public Vector3 camera2 = new Vector3(-106f, 21.8f, 34.7f);
    // Start is called before the first frame update
    void Start()
    {

    }
    public void OnMouseDown()
    {
        cam.transform.position = camera2;
        boutonD2.SetActive(true);
        boutonG.SetActive(true);
        txt_carriere.SetActive(true);
        boutonG2.SetActive(false);
        Taille1.SetActive(false);
        Taille2.SetActive(false);
        Taille3.SetActive(false);
        Taille4.SetActive(false);
        pierreT.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
