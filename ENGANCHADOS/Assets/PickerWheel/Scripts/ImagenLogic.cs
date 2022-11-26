using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImagenLogic : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnMouseDown()
    {
        this.gameObject.GetComponent<Image>().enabled = false;
    }
    // Update is called once per frame
    void Update()
    {

    }
}
