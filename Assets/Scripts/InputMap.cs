//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.1.0
//     from Assets/Scripts/InputMap.inputactions
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

public partial class @InputMap : IInputActionCollection2, IDisposable
{
    public InputActionAsset asset { get; }
    public @InputMap()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""InputMap"",
    ""maps"": [
        {
            ""name"": ""c"",
            ""id"": ""af8c9161-05d7-4954-9742-6df710026a49"",
            ""actions"": [
                {
                    ""name"": ""moveUp"",
                    ""type"": ""Button"",
                    ""id"": ""7f9a2e99-c0c7-4155-b4a3-e72fe2bac91e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""moveRight"",
                    ""type"": ""Button"",
                    ""id"": ""410a9b3f-7f71-48fe-b126-8b00d7acb793"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""moveDown"",
                    ""type"": ""Button"",
                    ""id"": ""64cc3023-237a-4b17-96e1-5fcf9b66b09f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""moveLeft"",
                    ""type"": ""Button"",
                    ""id"": ""aeaeaf7e-09ca-45b8-9827-b4f920ec288a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""quit"",
                    ""type"": ""Button"",
                    ""id"": ""1a32effd-d6b3-4a66-81a4-b8c248e09428"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""restart"",
                    ""type"": ""Button"",
                    ""id"": ""476f0911-2dc7-49f9-8220-f49a2e5192a9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""level1"",
                    ""type"": ""Button"",
                    ""id"": ""2319b2f3-566f-41bc-87af-ad43852f26a7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""level2"",
                    ""type"": ""Button"",
                    ""id"": ""1edd2a77-88ff-464e-991f-3e177475b85c"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""level3"",
                    ""type"": ""Button"",
                    ""id"": ""5e409bc2-6f67-48c8-a982-704594c720a7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""d77555d1-e624-425b-a78f-438fa88061b2"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveUp"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8bbf047d-6d8e-44c6-899e-4213859ab580"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveRight"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d0e8bbf1-50e2-4202-990f-cd0be4a2eed4"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveDown"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""cbcbd0be-b4c9-4027-b4f8-6510d776ffe8"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""moveLeft"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""54ed4350-35dd-4863-824f-52cf5dc2a9b5"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""restart"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c68b4325-1a03-4c07-b7fc-dd47177171d9"",
                    ""path"": ""<Keyboard>/f1"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""level1"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5b5bbf43-a7db-4f92-ab14-e5b6a53eb3f6"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""quit"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8fb5cbbb-aba0-4dfc-8097-51ef462e5546"",
                    ""path"": ""<Keyboard>/f2"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""level2"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86e66251-fb53-42ea-8fe5-0b1ee2c6c6eb"",
                    ""path"": ""<Keyboard>/f3"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""level3"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // c
        m_c = asset.FindActionMap("c", throwIfNotFound: true);
        m_c_moveUp = m_c.FindAction("moveUp", throwIfNotFound: true);
        m_c_moveRight = m_c.FindAction("moveRight", throwIfNotFound: true);
        m_c_moveDown = m_c.FindAction("moveDown", throwIfNotFound: true);
        m_c_moveLeft = m_c.FindAction("moveLeft", throwIfNotFound: true);
        m_c_quit = m_c.FindAction("quit", throwIfNotFound: true);
        m_c_restart = m_c.FindAction("restart", throwIfNotFound: true);
        m_c_level1 = m_c.FindAction("level1", throwIfNotFound: true);
        m_c_level2 = m_c.FindAction("level2", throwIfNotFound: true);
        m_c_level3 = m_c.FindAction("level3", throwIfNotFound: true);
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

    // c
    private readonly InputActionMap m_c;
    private ICActions m_CActionsCallbackInterface;
    private readonly InputAction m_c_moveUp;
    private readonly InputAction m_c_moveRight;
    private readonly InputAction m_c_moveDown;
    private readonly InputAction m_c_moveLeft;
    private readonly InputAction m_c_quit;
    private readonly InputAction m_c_restart;
    private readonly InputAction m_c_level1;
    private readonly InputAction m_c_level2;
    private readonly InputAction m_c_level3;
    public struct CActions
    {
        private @InputMap m_Wrapper;
        public CActions(@InputMap wrapper) { m_Wrapper = wrapper; }
        public InputAction @moveUp => m_Wrapper.m_c_moveUp;
        public InputAction @moveRight => m_Wrapper.m_c_moveRight;
        public InputAction @moveDown => m_Wrapper.m_c_moveDown;
        public InputAction @moveLeft => m_Wrapper.m_c_moveLeft;
        public InputAction @quit => m_Wrapper.m_c_quit;
        public InputAction @restart => m_Wrapper.m_c_restart;
        public InputAction @level1 => m_Wrapper.m_c_level1;
        public InputAction @level2 => m_Wrapper.m_c_level2;
        public InputAction @level3 => m_Wrapper.m_c_level3;
        public InputActionMap Get() { return m_Wrapper.m_c; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(CActions set) { return set.Get(); }
        public void SetCallbacks(ICActions instance)
        {
            if (m_Wrapper.m_CActionsCallbackInterface != null)
            {
                @moveUp.started -= m_Wrapper.m_CActionsCallbackInterface.OnMoveUp;
                @moveUp.performed -= m_Wrapper.m_CActionsCallbackInterface.OnMoveUp;
                @moveUp.canceled -= m_Wrapper.m_CActionsCallbackInterface.OnMoveUp;
                @moveRight.started -= m_Wrapper.m_CActionsCallbackInterface.OnMoveRight;
                @moveRight.performed -= m_Wrapper.m_CActionsCallbackInterface.OnMoveRight;
                @moveRight.canceled -= m_Wrapper.m_CActionsCallbackInterface.OnMoveRight;
                @moveDown.started -= m_Wrapper.m_CActionsCallbackInterface.OnMoveDown;
                @moveDown.performed -= m_Wrapper.m_CActionsCallbackInterface.OnMoveDown;
                @moveDown.canceled -= m_Wrapper.m_CActionsCallbackInterface.OnMoveDown;
                @moveLeft.started -= m_Wrapper.m_CActionsCallbackInterface.OnMoveLeft;
                @moveLeft.performed -= m_Wrapper.m_CActionsCallbackInterface.OnMoveLeft;
                @moveLeft.canceled -= m_Wrapper.m_CActionsCallbackInterface.OnMoveLeft;
                @quit.started -= m_Wrapper.m_CActionsCallbackInterface.OnQuit;
                @quit.performed -= m_Wrapper.m_CActionsCallbackInterface.OnQuit;
                @quit.canceled -= m_Wrapper.m_CActionsCallbackInterface.OnQuit;
                @restart.started -= m_Wrapper.m_CActionsCallbackInterface.OnRestart;
                @restart.performed -= m_Wrapper.m_CActionsCallbackInterface.OnRestart;
                @restart.canceled -= m_Wrapper.m_CActionsCallbackInterface.OnRestart;
                @level1.started -= m_Wrapper.m_CActionsCallbackInterface.OnLevel1;
                @level1.performed -= m_Wrapper.m_CActionsCallbackInterface.OnLevel1;
                @level1.canceled -= m_Wrapper.m_CActionsCallbackInterface.OnLevel1;
                @level2.started -= m_Wrapper.m_CActionsCallbackInterface.OnLevel2;
                @level2.performed -= m_Wrapper.m_CActionsCallbackInterface.OnLevel2;
                @level2.canceled -= m_Wrapper.m_CActionsCallbackInterface.OnLevel2;
                @level3.started -= m_Wrapper.m_CActionsCallbackInterface.OnLevel3;
                @level3.performed -= m_Wrapper.m_CActionsCallbackInterface.OnLevel3;
                @level3.canceled -= m_Wrapper.m_CActionsCallbackInterface.OnLevel3;
            }
            m_Wrapper.m_CActionsCallbackInterface = instance;
            if (instance != null)
            {
                @moveUp.started += instance.OnMoveUp;
                @moveUp.performed += instance.OnMoveUp;
                @moveUp.canceled += instance.OnMoveUp;
                @moveRight.started += instance.OnMoveRight;
                @moveRight.performed += instance.OnMoveRight;
                @moveRight.canceled += instance.OnMoveRight;
                @moveDown.started += instance.OnMoveDown;
                @moveDown.performed += instance.OnMoveDown;
                @moveDown.canceled += instance.OnMoveDown;
                @moveLeft.started += instance.OnMoveLeft;
                @moveLeft.performed += instance.OnMoveLeft;
                @moveLeft.canceled += instance.OnMoveLeft;
                @quit.started += instance.OnQuit;
                @quit.performed += instance.OnQuit;
                @quit.canceled += instance.OnQuit;
                @restart.started += instance.OnRestart;
                @restart.performed += instance.OnRestart;
                @restart.canceled += instance.OnRestart;
                @level1.started += instance.OnLevel1;
                @level1.performed += instance.OnLevel1;
                @level1.canceled += instance.OnLevel1;
                @level2.started += instance.OnLevel2;
                @level2.performed += instance.OnLevel2;
                @level2.canceled += instance.OnLevel2;
                @level3.started += instance.OnLevel3;
                @level3.performed += instance.OnLevel3;
                @level3.canceled += instance.OnLevel3;
            }
        }
    }
    public CActions @c => new CActions(this);
    public interface ICActions
    {
        void OnMoveUp(InputAction.CallbackContext context);
        void OnMoveRight(InputAction.CallbackContext context);
        void OnMoveDown(InputAction.CallbackContext context);
        void OnMoveLeft(InputAction.CallbackContext context);
        void OnQuit(InputAction.CallbackContext context);
        void OnRestart(InputAction.CallbackContext context);
        void OnLevel1(InputAction.CallbackContext context);
        void OnLevel2(InputAction.CallbackContext context);
        void OnLevel3(InputAction.CallbackContext context);
    }
}