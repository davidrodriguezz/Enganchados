using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class endZone : MonoBehaviour
{
    int sinMatar = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        sinMatar++;
        Destroy(collision.gameObject);
    }
    public int getResult()
    {
        return 15 - sinMatar;
    }
}