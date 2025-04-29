using UnityEngine;
using UnityEngine.InputSystem;

public class Accordion : MonoBehaviour
{
    public Healthbar enemyHealthBar;

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            enemyHealthBar.Health -= 0.1f;
        }
    }
}
