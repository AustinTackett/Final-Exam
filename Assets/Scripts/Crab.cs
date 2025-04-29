using UnityEngine;

public class Crab : MonoBehaviour
{
    public Healthbar enemyHealthBar;
    public float AttackCooldown = 2;
    private float timeLastAttack;

    void Start()
    {
        timeLastAttack = Time.time;
    }

    void Update()
    {
       if(Time.time - timeLastAttack > AttackCooldown)
       {
            Debug.Log(Time.time - timeLastAttack);
            timeLastAttack = Time.time;
            enemyHealthBar.Health -= 0.1f;
       }
    }
}
