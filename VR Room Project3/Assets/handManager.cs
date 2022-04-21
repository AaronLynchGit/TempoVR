using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class handManager : MonoBehaviour
{
    [Tooltip("Actions to check")]
    public InputAction action = null;

    // When the button is pressed
    public UnityEvent OnPress = new UnityEvent();

    // When the button is released
    public UnityEvent OnRelease = new UnityEvent();

    public GameObject handModelPrefab;
    public GameObject handModelClosed;

    private bool handBool = true;

    private GameObject spawnedHandModel;
    private GameObject spawnedClosedHand;

    // Start is called before the first frame update
    void Start()
    {
        spawnedHandModel = Instantiate(handModelPrefab, transform);
        spawnedClosedHand = Instantiate(handModelClosed, transform);
        spawnedHandModel.SetActive(true);
        spawnedClosedHand.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if(handBool)
        {
            spawnedHandModel.SetActive(true);
            spawnedClosedHand.SetActive(false);
            
        }
        else if(!handBool)
        {
            spawnedHandModel.SetActive(false);
            spawnedClosedHand.SetActive(true);
        }
          
    }

    public void toggleHandsClosed()
    {
        
       
        handBool = false;
        

    }

    public void toggleHandsOpen()
    {
        
        handBool = true;
        

    }



    private void Awake()
    {
        action.started += Pressed;
        action.canceled += Released;
    }

    private void OnDestroy()
    {
        action.started -= Pressed;
        action.canceled -= Released;
    }

    private void OnEnable()
    {
        action.Enable();
    }

    private void OnDisable()
    {
        action.Disable();
    }

    private void Pressed(InputAction.CallbackContext context)
    {
        OnPress.Invoke();
    }

    private void Released(InputAction.CallbackContext context)
    {
        OnRelease.Invoke();
    }
}
