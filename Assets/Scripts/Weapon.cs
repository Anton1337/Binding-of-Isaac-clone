using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    [SerializeField] private GameObject bulletPrefab;
    [SerializeField] private float startTimeInbetweenShots = 0.5f;
    private float timeInbetweenShots;

    public bool canShoot() {
        return timeInbetweenShots <= 0;
    }
}
