using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelDoors : MonoBehaviour
{
    [Header("Torch elements")]
    [SerializeField] GameObject fire, spark, glow;

    [Header("Doors")]
    [SerializeField] GameObject nextLevelDoors;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            fire.SetActive(true);
            spark.SetActive(true);
            glow.SetActive(true);
            nextLevelDoors.SetActive(true);
        }
    }

}
