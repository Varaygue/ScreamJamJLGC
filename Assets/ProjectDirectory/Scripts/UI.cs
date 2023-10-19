using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI staminaText=default;
    [SerializeField] private Slider staminaBar;

    private void OnEnable()
    {
        FirstPersonController.OnStaminaChange += UpdateStamina;
    }
    private void OnDisable()
    {
        FirstPersonController.OnStaminaChange -= UpdateStamina;
    }
    // Start is called before the first frame update
    private void Start()
    {
        UpdateStamina(100);
    }

    public void UpdateStamina(float currentStamina)
    {
        staminaText.text = currentStamina.ToString("00");
        staminaBar.value = currentStamina;
    }
}
