using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateZombie : MonoBehaviour
{
    [SerializeField]
    private GameObject zombie;
    int cont = 0;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("createZombie", 1);
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

    
}
