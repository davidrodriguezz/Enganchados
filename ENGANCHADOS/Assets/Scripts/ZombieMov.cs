using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ZombieMov : MonoBehaviour
{
    public int lifes = 14;
    public AudioSource death;
    public AudioSource shoot;
    bool once = true;
    void Update()
    {
        transform.Translate(new Vector2(2 * Time.deltaTime, 0));
    }
    private void OnMouseDown()
    {
        if (lifes > 0)
        {
            shoot.Play();
            lifes--;
        }
        else if( lifes <= 0 && once)
        {
            death.Play();
            this.GetComponent<SpriteRenderer>().enabled = false;
            Destroy(this.gameObject, 3f);
            once = false;
        }
    }
}
