using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bin : MonoBehaviour
{

    public Animator bin;
    public Collider collider;
    // public GameObject button;
    Button _btn;
    // Start is called before the first frame update
    void Start()
    {
        bin = this.GetComponent<Animator>();
        collider = this.GetComponent<Collider>();
        //button = this.button;

    }
    void Rubbish()
    {
        Debug.Log("成功");
    }
    // Update is called once per frame
    void Update()
    {
     
    }
    private void OnCollisionEnter(Collision collision)
    {
        collider.isTrigger = true;
        bin.SetBool("cat_touch",true);
        _btn = this.GetComponent<Button>();
        _btn.image.sprite = Resources.Load<Sprite>("buttom_rubbishbin");
        //canvas = new GameObject("Canvas", typeof(Canvas), typeof(RectTransform), typeof(CanvasScaler), typeof(GraphicRaycaster));
        //button = new GameObject("Button", typeof(Button), typeof(RectTransform), typeof(Image));
       // button.transform.position = this.transform.position;
        //_btn = button.GetComponent<Button>();
        //_btn.onClick.AddListener(Rubbish);
        //_btn.onClick.RemoveListener(Rubbish);
        
    }

}
