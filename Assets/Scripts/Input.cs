//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Inputs/PinballInput.inputactions
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public partial class @PinballInput: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PinballInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PinballInput"",
    ""maps"": [
        {
            ""name"": ""Actions"",
            ""id"": ""178af9d5-dcb9-41a0-b977-0a7bd903072e"",
            ""actions"": [
                {
                    ""name"": ""lowerLives"",
                    ""type"": ""Button"",
                    ""id"": ""b45f36fb-4660-4b97-9161-b1b24cd6f4b7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""LaunchBall"",
                    ""type"": ""Button"",
                    ""id"": ""e74c9a0a-608d-41e7-a36c-f31487335d8d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FlipperLeft"",
                    ""type"": ""Button"",
                    ""id"": ""342a174d-d1e3-4a00-9fcf-f0bb5f1c6197"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""FlipperRight"",
                    ""type"": ""Button"",
                    ""id"": ""b3b79750-3a02-41ae-9af8-08e3af5d461d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d44abf3d-76c6-462b-a75f-6129c8640450"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""lowerLives"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dfe1646b-9c7c-4a30-9d44-0f8e53c72867"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""LaunchBall"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""0607823a-1fb6-4447-8993-7a138e45cad8"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipperLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4bd06740-4616-4d7a-b0f0-d8d0b3cd6fdd"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipperLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""756b6570-ff46-44eb-8a9d-94c78660243d"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipperRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""1deda1b9-e95b-43ca-8017-69882968934a"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""FlipperRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Actions
        m_Actions = asset.FindActionMap("Actions", throwIfNotFound: true);
        m_Actions_lowerLives = m_Actions.FindAction("lowerLives", throwIfNotFound: true);
        m_Actions_LaunchBall = m_Actions.FindAction("LaunchBall", throwIfNotFound: true);
        m_Actions_FlipperLeft = m_Actions.FindAction("FlipperLeft", throwIfNotFound: true);
        m_Actions_FlipperRight = m_Actions.FindAction("FlipperRight", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    public IEnumerable<InputBinding> bindings => asset.bindings;

    public InputAction FindAction(string actionNameOrId, bool throwIfNotFound = false)
    {
        return asset.FindAction(actionNameOrId, throwIfNotFound);
    }

    public int FindBinding(InputBinding bindingMask, out InputAction action)
    {
        return asset.FindBinding(bindingMask, out action);
    }

    // Actions
    private readonly InputActionMap m_Actions;
    private List<IActionsActions> m_ActionsActionsCallbackInterfaces = new List<IActionsActions>();
    private readonly InputAction m_Actions_lowerLives;
    private readonly InputAction m_Actions_LaunchBall;
    private readonly InputAction m_Actions_FlipperLeft;
    private readonly InputAction m_Actions_FlipperRight;
    public struct ActionsActions
    {
        private @PinballInput m_Wrapper;
        public ActionsActions(@PinballInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @lowerLives => m_Wrapper.m_Actions_lowerLives;
        public InputAction @LaunchBall => m_Wrapper.m_Actions_LaunchBall;
        public InputAction @FlipperLeft => m_Wrapper.m_Actions_FlipperLeft;
        public InputAction @FlipperRight => m_Wrapper.m_Actions_FlipperRight;
        public InputActionMap Get() { return m_Wrapper.m_Actions; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(ActionsActions set) { return set.Get(); }
        public void AddCallbacks(IActionsActions instance)
        {
            if (instance == null || m_Wrapper.m_ActionsActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_ActionsActionsCallbackInterfaces.Add(instance);
            @lowerLives.started += instance.OnLowerLives;
            @lowerLives.performed += instance.OnLowerLives;
            @lowerLives.canceled += instance.OnLowerLives;
            @LaunchBall.started += instance.OnLaunchBall;
            @LaunchBall.performed += instance.OnLaunchBall;
            @LaunchBall.canceled += instance.OnLaunchBall;
            @FlipperLeft.started += instance.OnFlipperLeft;
            @FlipperLeft.performed += instance.OnFlipperLeft;
            @FlipperLeft.canceled += instance.OnFlipperLeft;
            @FlipperRight.started += instance.OnFlipperRight;
            @FlipperRight.performed += instance.OnFlipperRight;
            @FlipperRight.canceled += instance.OnFlipperRight;
        }

        private void UnregisterCallbacks(IActionsActions instance)
        {
            @lowerLives.started -= instance.OnLowerLives;
            @lowerLives.performed -= instance.OnLowerLives;
            @lowerLives.canceled -= instance.OnLowerLives;
            @LaunchBall.started -= instance.OnLaunchBall;
            @LaunchBall.performed -= instance.OnLaunchBall;
            @LaunchBall.canceled -= instance.OnLaunchBall;
            @FlipperLeft.started -= instance.OnFlipperLeft;
            @FlipperLeft.performed -= instance.OnFlipperLeft;
            @FlipperLeft.canceled -= instance.OnFlipperLeft;
            @FlipperRight.started -= instance.OnFlipperRight;
            @FlipperRight.performed -= instance.OnFlipperRight;
            @FlipperRight.canceled -= instance.OnFlipperRight;
        }

        public void RemoveCallbacks(IActionsActions instance)
        {
            if (m_Wrapper.m_ActionsActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IActionsActions instance)
        {
            foreach (var item in m_Wrapper.m_ActionsActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_ActionsActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public ActionsActions @Actions => new ActionsActions(this);
    public interface IActionsActions
    {
        void OnLowerLives(InputAction.CallbackContext context);
        void OnLaunchBall(InputAction.CallbackContext context);
        void OnFlipperLeft(InputAction.CallbackContext context);
        void OnFlipperRight(InputAction.CallbackContext context);
    }
}
