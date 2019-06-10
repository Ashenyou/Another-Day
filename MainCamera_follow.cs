using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCamera_follow : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform mycat;//相机跟随的对象
    public float smoothing = 5f;
    public float start_position_x;
    public bool follow = false;
    Vector3 offset;
    void Start()
    {
        start_position_x = this.transform.position.x;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (mycat.position.x>=start_position_x)
        {
            follow = true;
        }
        if (follow)
        {
            offset = new Vector3(mycat.position.x-this.transform.position.x  , 0, 0);
            Vector3 target = this.transform.position + offset;
            transform.position = Vector3.Lerp(this.transform.position, target, smoothing * Time.deltaTime);
        }
        
    }
}
