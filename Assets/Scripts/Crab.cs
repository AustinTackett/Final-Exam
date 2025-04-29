using UnityEngine;

public class Crab : MonoBehaviour
{
    public Healthbar enemyHealthBar;
    public Accordion accordion;
    public GameObject GameOverText;

    [HideInInspector] public bool CanAttack = true;
    public float AttackCooldown = 2;
    private float timeLastAttack;

    void Start()
    {
        timeLastAttack = Time.time;
    }

    void Update()
    {
        if(Time.time - timeLastAttack > AttackCooldown && CanAttack)
        {
            timeLastAttack = Time.time;
            enemyHealthBar.Health -= 0.1f;
            enemyHealthBar.Health = Mathf.Max(0, enemyHealthBar.Health);
        }

        if(enemyHealthBar.Health <= 0)
        {
            accordion.CanAttack = false;
            GameOverText.gameObject.SetActive(true);
        }
    }
}
