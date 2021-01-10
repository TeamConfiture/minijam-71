using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{
    public int keyNumber;
    [SerializeField] private Inventory inventory;
    [SerializeField] private GameObject inGameKey;
    private bool isInInventory = false;

    public void TakeKey()
    {
        if (!isInInventory)
        {
        isInInventory = true;
        inGameKey.SetActive(false);
        inventory.EnableInventoryKey(keyNumber);
        }
        else Debug.Log("Key is already picked up. are you sure you assigned keyNumber correctly?");
    } 

    public bool GetKeyStatus()
    {
        return isInInventory;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
