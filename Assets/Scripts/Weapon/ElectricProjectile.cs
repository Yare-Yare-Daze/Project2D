﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElectricProjectile : MonoBehaviour
{
    GameObject parent;

    // Start is called before the first frame update
    void Start()
    {
        parent = gameObject.transform.root.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        CharacterStatsSystem statsSystem = collision.GetComponent<CharacterStatsSystem>();
        if (statsSystem != null)
            statsSystem.TakeDamage(parent.GetComponent<EnemyStatsSystem>().GiveDamage());
    }
}
