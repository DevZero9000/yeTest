using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trapDamage : MonoBehaviour
{
    [SerializeField] private float damage;
    public AudioClip hitSound;

    void Start()
    {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = hitSound;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            collision.GetComponent<Health>().TakeDamage(damage);
            GetComponent<AudioSource>().Play();
        }
    }
}
