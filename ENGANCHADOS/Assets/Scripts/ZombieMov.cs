using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieMov : MonoBehaviour
{
    int lifes = 14;

    void Update()
    {
        transform.Translate(new Vector2(2 * Time.deltaTime, 0));
    }
    private void OnMouseDown()
    {
        if (lifes > 0)
        {
            lifes--;
            Debug.Log("Vidas: " + lifes);
        }
        else Destroy(this.gameObject);
    }
}
