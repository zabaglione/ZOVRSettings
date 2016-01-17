using UnityEngine;
using UnityEngine.VR;

public class ZOVRVRSettings : MonoBehaviour {

    [SerializeField]
    private KeyCode renderScaleDownKey = KeyCode.Alpha1;

    [SerializeField]
    private KeyCode renderScaleUpKey = KeyCode.Alpha2;

    [SerializeField]
    private KeyCode renderScaleResetKey = KeyCode.Alpha3;

    [SerializeField]
    private float scaleValue = 0.1f;

    void Start () {
    
    }
    void Update () {
        if (Input.GetKeyDown(renderScaleDownKey))
        {
            VRSettings.renderScale -= scaleValue;
        }
        if (Input.GetKeyDown(renderScaleUpKey))
        {
            VRSettings.renderScale += scaleValue;
        }
        if (Input.GetKeyDown(renderScaleResetKey))
        {
            VRSettings.renderScale = 1.0f;
        }
    }
}
