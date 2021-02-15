﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision bullet)
    {
        if(bullet.gameObject.tag == "Bullet")
        {
            SceneManager.LoadScene("start");
            Destroy(gameObject);
        }
    }
}
