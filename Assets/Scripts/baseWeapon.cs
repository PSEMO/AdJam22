using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class baseWeapon : MonoBehaviour
{

    public Transform muzzle;
    public GameObject bulletPrefab;
    public float bulletSpeed = 10f;
    public float fireRate = 0.1f;
    public bool canShoot = true;
    public float nextFire;

    public WeaponSO weaponSO;

    public float currentAmmo;
    public TMP_Text ammoText, magSize;

    void Awake()
    {
        magSize.text = weaponSO.magSize.ToString();
        ammoText.text = currentAmmo.ToString();
        currentAmmo = weaponSO.ammo;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) & Time.time >= nextFire & currentAmmo > 0)
        {
            nextFire = weaponSO.fireRate + Time.time;

            var bullet = Instantiate(bulletPrefab, muzzle.position, muzzle.rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = -muzzle.up * bulletSpeed;

            currentAmmo -= 1;
            if (currentAmmo == 0) { StartCoroutine(Reloading()); }

            ammoText.text = currentAmmo.ToString();
        }

    }

    private IEnumerator Reloading()
    {
        yield return new WaitForSeconds(weaponSO.reloadTime);
        currentAmmo = weaponSO.ammo;
    }
}
