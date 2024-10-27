using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class Shooting : MonoBehaviour
{
    [SerializeField] GameObject summonBullet;
    [SerializeField] Transform spawnPoint;
    bool canShoot = true;
    float reloads = 0;
    bool isReloading = false;

    void Update()
    {
        if (Input.GetKey(KeyCode.Mouse0) && canShoot)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        Instantiate(summonBullet, spawnPoint.position, spawnPoint.rotation);
        StartCoroutine(Reload());
    }
    private IEnumerator Reload()
    {
        canShoot = false;
        isReloading = true;
        yield return new WaitForSeconds(1);
        reloads = 0;
        isReloading = false;
        canShoot = true;
    }
}
