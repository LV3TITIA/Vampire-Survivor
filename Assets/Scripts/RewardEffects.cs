using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

public class RewardEffects : MonoBehaviour
{
    public static UnityEvent AfterEnemyDeath;
    public static UnityEvent AfterPlayerAttack;

    // Start is called before the first frame update
    void Start()
    {
        AfterEnemyDeath = new UnityEvent();
        AfterEnemyDeath.AddListener(CreateBonusBullet);
  
        AfterPlayerAttack= new UnityEvent();
        AfterPlayerAttack.AddListener(DoubleAttack);
    }

    // Update is called once per frame
    void Update()
    {
        //AfterPlayerAttack.Invoke();
        //AfterEnemyDeath.Invoke();
    }

    public void CreateBonusBullet()
    {
        Debug.Log("CreatedBonysBullet");

    }

    public void DoubleAttack() 
    {
        Debug.Log("DoubleAttack");
    }
}
