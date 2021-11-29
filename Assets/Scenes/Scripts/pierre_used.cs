using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pierre_used : MonoBehaviour
{
    public Text pierreUsedTxt;
    public Arènes myArène;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pierreUsedTxt.text = myArène.pierreUsed.ToString();
    }
}
