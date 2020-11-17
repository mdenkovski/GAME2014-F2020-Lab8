using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class LOS : MonoBehaviour
{
    public Collider2D collidesWith;
    public ContactFilter2D contactFilter;
    public List<Collider2D> colliders;

    private BoxCollider2D LOSCollider;


    private void Start()
    {
        LOSCollider = GetComponent<BoxCollider2D>();
    }

    private void FixedUpdate()
    {
        Physics2D.GetContacts(LOSCollider, contactFilter, colliders);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        collidesWith = other;


    }
}
