using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pierre : MonoBehaviour
{
    public Carrière myCarrière;
    public Text pierreTxt;
    // Start is called before the first frame update
    void Start()
    {
        pierreTxt.text = "5";
    }

    // Update is called once per frame
    void Update()
    {
        pierreTxt.text = myCarrière.pierre.ToString();
    }
}
