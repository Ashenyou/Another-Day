using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyCat_behaviour : MonoBehaviour
{
    // Start is called before the first frame update
    public Animator MyCat_animator;
    public float speed = 1.0f;
    void Start()
    {
        MyCat_animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetKey("d"))
        {
            transform.Translate(Vector3.right * Time.smoothDeltaTime * speed);
            MyCat_animator.SetBool("cat_move_right", true);
        }
        if (Input.GetKeyUp("d"))
        {
            MyCat_animator.SetBool("cat_move_right", false);
        }
        if (Input.GetKey("a"))
        {
            transform.Translate(Vector3.right * Time.smoothDeltaTime *(-1)*speed);
        }
        if (Input.GetKeyUp("a"))
        {
        }
    }
}
