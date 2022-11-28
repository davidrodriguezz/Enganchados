using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateZombie : MonoBehaviour
{
    [SerializeField] GameObject zombie;
    [SerializeField] Button bResult;
    [SerializeField] Text txtResult;
    [SerializeField] endZone ez;
    int cont = 0;

    void Start()
    {
        Invoke("createZombie", 1);
        Invoke("showResult", 23);
    }

    void createZombie()
    {
        if (cont < 15)
        {
            cont++;
            Instantiate(zombie, new Vector3(-5, -0.5f,-5), Quaternion.identity);
            Invoke("createZombie", 1);
        }
    }
    void showResult()
    {
        bResult.gameObject.SetActive(true);
        txtResult.text = "HAS MATADO A "+ ez.getResult() +" DE 15 ZOMBIES\n\nPULSA PARA CONTINUAR";
    }
}
