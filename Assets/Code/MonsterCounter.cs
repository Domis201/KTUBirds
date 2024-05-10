using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MonsterCounter : MonoBehaviour
{
    [SerializeField] Text monsters;

    public int count;

    private void Awake()
    {
        UpdateHUD();
    }

    private void UpdateHUD()
    {
        GameObject[] monster = GameObject.FindGameObjectsWithTag("Monster");
        count = monster.Length;
        monsters.text = count.ToString();
    }
    void Update()
    {
        UpdateHUD();
    }

}
