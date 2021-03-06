using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Arènes : MonoBehaviour
{
    [SerializeField] private Carrière carrière ;
    public int pierreUsed = 0;
    public int étapeFinie = 0;
    public int phase2End = 0;
    public int phase3End = 0;
    public GameObject Arène1;
    public GameObject Arène2;
    public GameObject Arène3;
    public GameObject Arène4;
    public GameObject Phase2;
    public GameObject B_Phase2;
    public GameObject Phase3;
    public GameObject B_Phase3;
    public GameObject Fin;
    Vector3 visible = new Vector3(3f, 2.5f, -1.5f);
    Vector3 invisible = new Vector3(2000f, 0, 0);

    void OnMouseDown()
    {
        if (carrière.pierre >= 10)
        {
            pierreUsed += 10; 
            carrière.pierre = carrière.pierre - 10;
            Debug.Log(carrière.pierre + " pierre") ;
            Debug.Log(pierreUsed + " pierre utilisée");
        }
        
        if (pierreUsed >= 500)
        {
            étapeFinie += 1;
            pierreUsed = 0;
        }
    }
    public void addPierre()
    {
        if (carrière.pierre >= 10)
        {
            pierreUsed += 10;
            carrière.pierre = carrière.pierre - 10;
            Debug.Log(carrière.pierre + " pierre");
            Debug.Log(pierreUsed + " pierre utilisée");
        }

        if (pierreUsed >= 100)
        {
            étapeFinie += 1;
            pierreUsed = 0;
        }

        if (étapeFinie == 1)
        {
            Arène1.transform.position = invisible;
            Arène2.transform.position = visible;
            if (phase2End == 0) {
                Phase2.SetActive(true);
                B_Phase2.SetActive(true);
                phase2End = 1;
            }
            
        }

        if (étapeFinie == 2)
        {
            Arène2.transform.position = invisible;
            Arène3.transform.position = visible;
            if (phase3End == 0)
            {
                Phase3.SetActive(true);
                B_Phase3.SetActive(true);
                phase3End = 1;
            }
        }

        if (étapeFinie == 3)
        {
            Arène3.transform.position = invisible;
            Arène4.transform.position = visible;
            Fin.SetActive(true);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
