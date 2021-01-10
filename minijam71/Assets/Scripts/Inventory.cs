using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private GameObject[] keys;

    public void EnableInventoryKey(int n)
    {
        keys[n].SetActive(true);
    }

    // public int nSlots = 5;
    // public int sizeslot = 50;
    // [SerializeField] private GameObject parentInv;
    // [SerializeField] private GameObject inventorySprite;

    // void Awake() 
    // {
    //     float x = -(sizeslot/2*(nSlots-1));
    //     for (int i = 0; i < nSlots; i++)
    //     {
    //         x = x + sizeslot;
    //         GameObject keyInv = Instantiate(inventorySprite) as GameObject;
    //         keyInv.transform.parent = parentInv.transform;
    //         keyInv.transform.localPosition = new Vector3(x,0f,0f);
    //         //keyInv.transform.GetChild().gameObject.SetActive(false);
    //     }
    // }
}

