using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameControl : MonoBehaviour
{
    public GameObject SearchBin;
    //string hitName="";
    // Start is called before the first frame update
    void Start()
    {

    }


    // Update is called once per frame
    void Update()
    {
       Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        /*if (Physics.Raycast(ray,out hit))
        {
            hitName = hit.collider.gameObject.name;
            switch (hitName){
                case "":
                    Instantiate(SearchBin.);
                break;
            }
        }*/
    }
}
