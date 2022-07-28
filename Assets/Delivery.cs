using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] Color32 hasPackageColor = new(0,255,0,255);
    [SerializeField] Color32 noPackageColor = new(255, 255, 255, 255);
    [SerializeField] float packageDestructionDelay = 0.5f;

    SpriteRenderer spriteRenderer;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Package") && !hasPackage)
        {
            Debug.Log("Picked up Package");
            hasPackage = true;
            spriteRenderer.color = hasPackageColor;
            Destroy(collision.gameObject, packageDestructionDelay);
        }
        else if (collision.CompareTag("Customer") && hasPackage == true)
        {
            Debug.Log("Delivered Package");
            hasPackage = false;
            spriteRenderer.color = noPackageColor;
        }
    }
}
