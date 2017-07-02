using System.Collections;
using UnityEngine;

public class CoinPickupCSharp : MonoBehaviour {

    public Transform CoinEffect;
    public float CoinRotationSpeed = 2;

    public void OnTriggerEnter(Collider info)
    {
        Transform effect = Instantiate(CoinEffect, transform.position, transform.rotation); // var вместо tranform
        GuimMuniger.currentScore++;
        Destroy(effect.gameObject, 2);
        Destroy(gameObject);

    }
    // Update is called once per frame
    void FixedUpdate () {
        transform.Rotate(Vector3.up * CoinRotationSpeed);
    }
}
