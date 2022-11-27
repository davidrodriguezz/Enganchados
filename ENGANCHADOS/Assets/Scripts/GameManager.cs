using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int monedas = 5;
    [SerializeField]
    private Text textMonedas;

    void Awake() //  Comprobar que solo hay un GameManager.
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else Destroy(this.gameObject);

        textMonedas.text = monedas.ToString();
    }

    public void addMonedas(int a)
    {
        monedas += a;
        textMonedas.text = monedas.ToString();
    }

    public void substractMonedas(int a)
    {
        monedas -= a;
        textMonedas.text = monedas.ToString();
    }

    public int getMonedas() { return monedas; }
}
