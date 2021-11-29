using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carrière : MonoBehaviour
{
    public int pierre = 0;

    // Start is called before the first frame update
    void OnMouseDown()
    {
        pierre += 1;
        Debug.Log (pierre + " pierre") ;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
