using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pierre_taille : MonoBehaviour
{

    public List<Taillage> l_tail;
    public Carrière car;
    public Text pierreTailleTxt;
    public int pierreTaille;
    // Start is called before the first frame update
    void Start()
    {
        pierreTailleTxt.text = "0";
    }

    // Update is called once per frame
    void Update()
    {
        if (l_tail[0].clicked == true && l_tail[1].clicked == true && l_tail[2].clicked == true && l_tail[3].clicked == true && car.pierre >= 10)
        {
            pierreTaille += 10;
            l_tail[0].clicked = false;
            l_tail[1].clicked = false;
            l_tail[2].clicked = false;
            l_tail[3].clicked = false;
        }
        pierreTailleTxt.text = "" + pierreTaille;
    }
}
