﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Choco_bar : MonoBehaviour
{
    public const int CALORIES = 406, FAT = 4, VITAMINS = 0, ENERGY = 5;
    public Stats stats;
    public AudioSource audio5;
    public FoodDataDisplay F5;

    // Start is called before the first frame update
    void Start()
    {
        stats = GameObject.FindWithTag("GameController").GetComponent<Stats>();

    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "Player")
        {
            audio5.Play();
            F5.FoodDataShow(VITAMINS, CALORIES, FAT);

            stats.IncreaseCalories(CALORIES);
            stats.IncreaseFat(FAT);
            stats.IncreaseVitamins(VITAMINS);
            stats.IncreaseEnergy(ENERGY);
            Destroy(gameObject);
        }
    }
}
