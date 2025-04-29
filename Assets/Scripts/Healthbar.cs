using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Healthbar : MonoBehaviour
{
    public float Health;
    private Slider healthSlider;
    private TextMeshProUGUI hpText;

    void Start()
    {
        healthSlider = GetComponentInChildren<Slider>();
        hpText = GetComponentInChildren<TextMeshProUGUI>();
        healthSlider.value = healthSlider.maxValue;
    }

    void Update()
    {
        healthSlider.value = Health  / healthSlider.maxValue;
        hpText.text = "HP: " + Health;
    }
}
