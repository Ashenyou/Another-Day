using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class streetwalker_lookaround : MonoBehaviour
{
    public Animator streetwalker;
    // Start is called before the first frame update
    void Start()
    {
        streetwalker = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Time.realtimeSinceStartup % 10 = "+ Time.realtimeSinceStartup % 10);
        if (Time.realtimeSinceStartup % 10 <= 0.5)
        {
            streetwalker.ResetTrigger("lookaround");
            streetwalker.SetTrigger("lookaround");
            
        }
    }
}
