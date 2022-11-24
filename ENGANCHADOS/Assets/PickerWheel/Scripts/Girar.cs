using EasyUI.PickerWheelUI;
using UnityEngine;
using UnityEngine.UI;

public class Girar : MonoBehaviour {
    [SerializeField] private Button uiSpinButton;

    [SerializeField] private PickerWheel pickerWheel;

    private void Start()
    {
        uiSpinButton.onClick.AddListener(() =>
        {
            pickerWheel.Spin();
        });
    } 
}