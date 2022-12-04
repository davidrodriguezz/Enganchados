using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class ZombieMov : MonoBehaviour
{
    public int lifes = 14;
    public AudioSource death;
    public AudioSource shoot;
    public SpriteRenderer blood;
    public SpriteRenderer health;
    bool once = true;
    bool bloodActivate = false;
    float timer;
    float healthPart;

    private void Start()
    {
        healthPart = health.transform.localScale.x / lifes;
    }
    void Update()
    {
        transform.Translate(new Vector2(2 * Time.deltaTime, 0));
        if(bloodActivate)
            timer += Time.deltaTime;
        if(0.3f < timer)
        {
            blood.gameObject.SetActive(false);
            bloodActivate = false;
        }
    }
    private void OnMouseDown()
    {
        if (lifes > 0)
        {
            timer = 0;
            bloodActivate = true;
            blood.gameObject.SetActive(true);
            shoot.Play();
            health.transform.localScale -= new Vector3(healthPart,0,0);
            lifes--;
        }
        else if (lifes <= 0 && once)
        {
            blood.gameObject.SetActive(false);
            death.Play();
            this.GetComponent<SpriteRenderer>().enabled = false;
            Destroy(this.gameObject, 0.5f);
            once = false;
        }
    }
}
