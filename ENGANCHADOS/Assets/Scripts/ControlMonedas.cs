using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControlMonedas : MonoBehaviour
{
    // Start is called before the first frame update
    private Text monedah;
    public int monedas;
    void Start()
    {
        GameManager.instance.addMonedas(monedas);
        monedah = this.gameObject.GetComponent<Text>();
        monedah.text = GameManager.instance.getMonedas().ToString();

    }

    // Update is called once per frame
    void Update()
    {
        monedah.text = GameManager.instance.getMonedas().ToString();
    }
}
