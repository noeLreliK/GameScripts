using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 10;
    private int coins;
    public GameObject fireballprefab;
    public Transform attackpoint;
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("�������� ������: " + health); 
    }
    public void CollectCoins()
    {
        coins++;
        print("��������� �������: " + coins);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) {
            Instantiate(fireballprefab, attackpoint.position, attackpoint.rotation);
        } 
    }
}
