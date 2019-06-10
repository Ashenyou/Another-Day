using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCat : MonoBehaviour
{
    // Start is called before the first frame update
    public class Condition
    {
        int health = 100;
        int walkspeed = 10;
        bool isInjured = false;
        public class Disease
        {
            bool isEarAcarid = false;
            bool isfeaver = false;
            bool isFlea = false;
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(this.transform.position.y!= -8.15d)
        {
            float y = this.transform.position.y;
            transform.Translate(0,-8.15f-y, 0);
        }
    }
}
