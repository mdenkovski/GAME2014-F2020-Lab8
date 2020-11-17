﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour, IApplyDamage
{
    public float verticalSpeed;
    public float verticalBoundary;
    public int damage;
    
    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(0.0f, verticalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        if (transform.position.y > verticalBoundary)
        {
            BulletManager.Instance().ReturnBullet(gameObject);
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {

        switch (other.gameObject.tag)
        {
            case "Player":
                BulletManager.Instance().ReturnBullet(gameObject);
                break;
            case "Enemy":
                BulletManager.Instance().ReturnBullet(gameObject);
                break;
            default:
                break;
        }

        ////Debug.Log(other.gameObject.name);
        //if(other.gameObject.CompareTag("Enemy"))
        //{
        //    BulletManager.Instance().ReturnBullet(gameObject);

        //}
    }

    public int ApplyDamage()
    {
        return damage;
    }
}
