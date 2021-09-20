// GENERATED AUTOMATICALLY FROM 'Assets/input system/PlayerInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerInputActions : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputActions()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputActions"",
    ""maps"": [
        {
            ""name"": ""Movment"",
            ""id"": ""e38a493b-cc9a-49e2-95f7-e41274a21ee2"",
            ""actions"": [
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""d3db0d22-61f9-4a13-9373-8a869eccd474"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Movment"",
                    ""type"": ""Value"",
                    ""id"": ""3e30c14d-20e0-4209-ac23-7781642e4d32"",
                    ""expectedControlType"": ""Axis"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""primary fire"",
                    ""type"": ""Button"",
                    ""id"": ""02ff8afb-fb1d-4e77-8f83-442c7404de72"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""alt fire"",
                    ""type"": ""Button"",
                    ""id"": ""a3993d85-a439-4a99-acc3-220c0105d634"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""9e960064-6bf2-4073-86db-3654783276a5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""1D Axis"",
                    ""id"": ""9b77f92d-b271-4119-bfc7-3589b56a5778"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movment"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""9d6d2fa2-e488-42ac-875f-6926172e19e7"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""36e7f00b-3964-48b1-8a30-63b5bd5888f4"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Movment"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5675e386-a3ee-4026-af72-fb0d7e7eca32"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""primary fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8999bca6-4e21-4a4f-876a-663b3c721066"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""alt fire"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Movment
        m_Movment = asset.FindActionMap("Movment", throwIfNotFound: true);
        m_Movment_Jump = m_Movment.FindAction("Jump", throwIfNotFound: true);
        m_Movment_Movment = m_Movment.FindAction("Movment", throwIfNotFound: true);
        m_Movment_primaryfire = m_Movment.FindAction("primary fire", throwIfNotFound: true);
        m_Movment_altfire = m_Movment.FindAction("alt fire", throwIfNotFound: true);
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

    // Movment
    private readonly InputActionMap m_Movment;
    private IMovmentActions m_MovmentActionsCallbackInterface;
    private readonly InputAction m_Movment_Jump;
    private readonly InputAction m_Movment_Movment;
    private readonly InputAction m_Movment_primaryfire;
    private readonly InputAction m_Movment_altfire;
    public struct MovmentActions
    {
        private @PlayerInputActions m_Wrapper;
        public MovmentActions(@PlayerInputActions wrapper) { m_Wrapper = wrapper; }
        public InputAction @Jump => m_Wrapper.m_Movment_Jump;
        public InputAction @Movment => m_Wrapper.m_Movment_Movment;
        public InputAction @primaryfire => m_Wrapper.m_Movment_primaryfire;
        public InputAction @altfire => m_Wrapper.m_Movment_altfire;
        public InputActionMap Get() { return m_Wrapper.m_Movment; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(MovmentActions set) { return set.Get(); }
        public void SetCallbacks(IMovmentActions instance)
        {
            if (m_Wrapper.m_MovmentActionsCallbackInterface != null)
            {
                @Jump.started -= m_Wrapper.m_MovmentActionsCallbackInterface.OnJump;
                @Jump.performed -= m_Wrapper.m_MovmentActionsCallbackInterface.OnJump;
                @Jump.canceled -= m_Wrapper.m_MovmentActionsCallbackInterface.OnJump;
                @Movment.started -= m_Wrapper.m_MovmentActionsCallbackInterface.OnMovment;
                @Movment.performed -= m_Wrapper.m_MovmentActionsCallbackInterface.OnMovment;
                @Movment.canceled -= m_Wrapper.m_MovmentActionsCallbackInterface.OnMovment;
                @primaryfire.started -= m_Wrapper.m_MovmentActionsCallbackInterface.OnPrimaryfire;
                @primaryfire.performed -= m_Wrapper.m_MovmentActionsCallbackInterface.OnPrimaryfire;
                @primaryfire.canceled -= m_Wrapper.m_MovmentActionsCallbackInterface.OnPrimaryfire;
                @altfire.started -= m_Wrapper.m_MovmentActionsCallbackInterface.OnAltfire;
                @altfire.performed -= m_Wrapper.m_MovmentActionsCallbackInterface.OnAltfire;
                @altfire.canceled -= m_Wrapper.m_MovmentActionsCallbackInterface.OnAltfire;
            }
            m_Wrapper.m_MovmentActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Jump.started += instance.OnJump;
                @Jump.performed += instance.OnJump;
                @Jump.canceled += instance.OnJump;
                @Movment.started += instance.OnMovment;
                @Movment.performed += instance.OnMovment;
                @Movment.canceled += instance.OnMovment;
                @primaryfire.started += instance.OnPrimaryfire;
                @primaryfire.performed += instance.OnPrimaryfire;
                @primaryfire.canceled += instance.OnPrimaryfire;
                @altfire.started += instance.OnAltfire;
                @altfire.performed += instance.OnAltfire;
                @altfire.canceled += instance.OnAltfire;
            }
        }
    }
    public MovmentActions @Movment => new MovmentActions(this);
    public interface IMovmentActions
    {
        void OnJump(InputAction.CallbackContext context);
        void OnMovment(InputAction.CallbackContext context);
        void OnPrimaryfire(InputAction.CallbackContext context);
        void OnAltfire(InputAction.CallbackContext context);
    }
}
