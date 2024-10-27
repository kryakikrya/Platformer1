using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDirection : MonoBehaviour
{
    private Transform firePoint;
    [SerializeField] GameObject summonBullet;
    private float offset;
    void Start()
    {
        firePoint = transform;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotateZ + offset);
        if (Input.GetKey(KeyCode.Mouse1))
        {
            Shoot();
        }
    }
    void Shoot()
    {
        Instantiate(summonBullet, transform.position, transform.rotation);
    }
}