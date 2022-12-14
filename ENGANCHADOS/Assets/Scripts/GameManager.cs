using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    private int monedas = 5;

    void Awake() //  Comprobar que solo hay un GameManager.
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else Destroy(this.gameObject);

        //textMonedas.text = monedas.ToString();
    }

    public void addMonedas(int a)
    {
        monedas += a;
    }

    public void substractMonedas(int a)
    {
        monedas -= a;
    }

    public int getMonedas() { return monedas; }
}
