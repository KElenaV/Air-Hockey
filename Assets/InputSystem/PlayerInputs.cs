//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/InputSystem/PlayerInputs.inputactions
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

public partial class @PlayerInputs: IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerInputs()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerInputs"",
    ""maps"": [
        {
            ""name"": ""Paddle"",
            ""id"": ""2b2df2c5-317b-452d-a244-88ac19fce3db"",
            ""actions"": [
                {
                    ""name"": ""PlayerOneMove"",
                    ""type"": ""Value"",
                    ""id"": ""c05d6dbb-f1f6-4cbf-bc74-906c185ff12e"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""PlayerTwoMove"",
                    ""type"": ""Value"",
                    ""id"": ""8ca25bfe-7e34-49f0-ae3d-3374690b000a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""58ad5df3-ff90-4c39-add2-8a0af27bfa38"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerOneMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""059c465f-f675-4047-87af-dbb8df74923d"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerOneMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""e9badbb5-b124-4e28-a8a7-260c072c29b5"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerOneMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6f8da165-bd30-40fc-8b49-cd5c565645fb"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerOneMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a06b4e0c-49af-4222-9dc6-48f91500eea2"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerOneMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""ae400805-5bfe-4adb-a241-ea754eb88833"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerTwoMove"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""45d2845b-67a1-46b7-a573-679e8aa8f808"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerTwoMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""3a93d8a2-cff0-4a06-bbbe-8a93e414d1ce"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerTwoMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""12fafcb9-49ac-4568-8779-301fffab492e"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerTwoMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""a7441a95-bac3-459d-96d7-1dc3f618e8ef"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""PlayerTwoMove"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Paddle
        m_Paddle = asset.FindActionMap("Paddle", throwIfNotFound: true);
        m_Paddle_PlayerOneMove = m_Paddle.FindAction("PlayerOneMove", throwIfNotFound: true);
        m_Paddle_PlayerTwoMove = m_Paddle.FindAction("PlayerTwoMove", throwIfNotFound: true);
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

    // Paddle
    private readonly InputActionMap m_Paddle;
    private List<IPaddleActions> m_PaddleActionsCallbackInterfaces = new List<IPaddleActions>();
    private readonly InputAction m_Paddle_PlayerOneMove;
    private readonly InputAction m_Paddle_PlayerTwoMove;
    public struct PaddleActions
    {
        private @PlayerInputs m_Wrapper;
        public PaddleActions(@PlayerInputs wrapper) { m_Wrapper = wrapper; }
        public InputAction @PlayerOneMove => m_Wrapper.m_Paddle_PlayerOneMove;
        public InputAction @PlayerTwoMove => m_Wrapper.m_Paddle_PlayerTwoMove;
        public InputActionMap Get() { return m_Wrapper.m_Paddle; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(PaddleActions set) { return set.Get(); }
        public void AddCallbacks(IPaddleActions instance)
        {
            if (instance == null || m_Wrapper.m_PaddleActionsCallbackInterfaces.Contains(instance)) return;
            m_Wrapper.m_PaddleActionsCallbackInterfaces.Add(instance);
            @PlayerOneMove.started += instance.OnPlayerOneMove;
            @PlayerOneMove.performed += instance.OnPlayerOneMove;
            @PlayerOneMove.canceled += instance.OnPlayerOneMove;
            @PlayerTwoMove.started += instance.OnPlayerTwoMove;
            @PlayerTwoMove.performed += instance.OnPlayerTwoMove;
            @PlayerTwoMove.canceled += instance.OnPlayerTwoMove;
        }

        private void UnregisterCallbacks(IPaddleActions instance)
        {
            @PlayerOneMove.started -= instance.OnPlayerOneMove;
            @PlayerOneMove.performed -= instance.OnPlayerOneMove;
            @PlayerOneMove.canceled -= instance.OnPlayerOneMove;
            @PlayerTwoMove.started -= instance.OnPlayerTwoMove;
            @PlayerTwoMove.performed -= instance.OnPlayerTwoMove;
            @PlayerTwoMove.canceled -= instance.OnPlayerTwoMove;
        }

        public void RemoveCallbacks(IPaddleActions instance)
        {
            if (m_Wrapper.m_PaddleActionsCallbackInterfaces.Remove(instance))
                UnregisterCallbacks(instance);
        }

        public void SetCallbacks(IPaddleActions instance)
        {
            foreach (var item in m_Wrapper.m_PaddleActionsCallbackInterfaces)
                UnregisterCallbacks(item);
            m_Wrapper.m_PaddleActionsCallbackInterfaces.Clear();
            AddCallbacks(instance);
        }
    }
    public PaddleActions @Paddle => new PaddleActions(this);
    public interface IPaddleActions
    {
        void OnPlayerOneMove(InputAction.CallbackContext context);
        void OnPlayerTwoMove(InputAction.CallbackContext context);
    }
}
