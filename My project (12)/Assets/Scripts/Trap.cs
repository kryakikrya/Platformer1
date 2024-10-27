using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Trap : MonoBehaviour
{

    [SerializeField] PlayerMovement player;
    public bool isActive;
    public int lives;

    private void Start()
    {
        lives = 3;
        isActive =  true;
}
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Player" && isActive == true)
        {
            player.GetDamage();
        }
    }

    public void GetDamage()
    {
        lives -= 1;
        Debug.Log(lives);
        if (lives <= 0)
        {
            isActive = false;
        }
    }

}
