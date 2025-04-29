using UnityEngine;
using UnityEngine.InputSystem;

public class Accordion : MonoBehaviour
{
    public Healthbar enemyHealthBar;
    public Crab crab;
    public GameObject WinText;
    
    [HideInInspector] public bool CanAttack = true;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && CanAttack)
        {
            enemyHealthBar.Health -= 0.1f;
            enemyHealthBar.Health = Mathf.Max(0, enemyHealthBar.Health);
        }

        if(enemyHealthBar.Health <= 0)
        {
            crab.CanAttack = false;
            WinText.gameObject.SetActive(true);
        }
    }
}
