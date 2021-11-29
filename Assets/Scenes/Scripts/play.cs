using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class play : MonoBehaviour
{
    public GameObject playB;
    public GameObject Menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void OnMouseDown()
    {
        playB.SetActive(false);
        Menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
