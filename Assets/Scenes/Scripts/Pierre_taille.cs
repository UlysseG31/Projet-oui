using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pierre_taille : MonoBehaviour
{

    public List<Taillage> l_tail;
    public Carrière car;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (l_tail[0] == true && l_tail[1] == true && l_tail[2] == true && l_tail[3] == true && car.pierre >= 10)
        {

        }
    }
}
