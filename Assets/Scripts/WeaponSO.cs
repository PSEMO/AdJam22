using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "WeaponSO", order = 1)]
public class WeaponSO : ScriptableObject
{
    public string WeaponName, Description;
    public float damage, range, ammo, magSize, fireRate, reloadTime;

    [SerializeField]
    public GameObject weapon;

}
