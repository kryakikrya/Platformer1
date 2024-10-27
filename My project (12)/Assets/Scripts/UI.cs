using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UI : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] PlayerMovement player;
    [SerializeField] TextMeshProUGUI tmp;
    private void Update()
    {
        tmp.text = "HP: " + player.lives;
    }
}
