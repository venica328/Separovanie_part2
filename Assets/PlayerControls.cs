// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Game"",
            ""id"": ""631ac154-645c-40a2-95c9-7ef11ee7284c"",
            ""actions"": [
                {
                    ""name"": ""Right"",
                    ""type"": ""PassThrough"",
                    ""id"": ""699ac630-1adc-4005-b32b-22234fd6a028"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Left"",
                    ""type"": ""PassThrough"",
                    ""id"": ""59ce9de3-6777-4c25-921a-7681275c3aea"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Separuj_Sklo"",
                    ""type"": ""Button"",
                    ""id"": ""8bb1b64e-e005-4696-b0b6-a3210cc98b67"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Separuj_Papier"",
                    ""type"": ""Button"",
                    ""id"": ""ed4d0cd1-d951-409e-a73a-20b46af1b08b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Separuj_Plasty"",
                    ""type"": ""Button"",
                    ""id"": ""1b01437b-8832-4965-a371-b514e3a60dc6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Game"",
                    ""type"": ""Button"",
                    ""id"": ""de8fd18a-c45b-45d2-8a79-66bd551fb197"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""End_Game"",
                    ""type"": ""Button"",
                    ""id"": ""78f37276-4ae9-46a3-9d8e-f9cf4ac30386"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""19017ee8-f286-4b34-afbd-128f52b5711b"",
                    ""path"": ""2DVector"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Right"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""right"",
                    ""id"": ""6e695f65-5a46-4284-af03-c82cd7260c99"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""Right"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5f339a8b-a2bb-446a-83c3-21872b2c0d79"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""Separuj_Sklo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""35ce94ab-7fe1-4952-bacc-39635b451c41"",
                    ""path"": ""<XInputController>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""Separuj_Plasty"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""970d0d09-998f-4021-a23e-1519f60676f7"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""End_Game"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""14167c0e-9c36-4c66-8f0e-c392e8cdd486"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Left"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""left"",
                    ""id"": ""d9c6cb2c-8206-409f-8c5b-40cbaa991de2"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""Left"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""9eb60082-27dc-4b43-b891-0f6497a5dc1a"",
                    ""path"": ""<XInputController>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox Control Scheme"",
                    ""action"": ""Separuj_Papier"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard"",
            ""id"": ""2d1e4298-9f80-4d4f-84c5-cd7db4713b69"",
            ""actions"": [
                {
                    ""name"": ""w"",
                    ""type"": ""Button"",
                    ""id"": ""dd811893-e854-4b33-b768-3af389a92e4a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1d6df6d7-229d-4c0f-a421-ec847a8bef62"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard control scheme"",
                    ""action"": ""w"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Xbox Control Scheme"",
            ""bindingGroup"": ""Xbox Control Scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<XboxOneGampadiOS>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Keyboard control scheme"",
            ""bindingGroup"": ""Keyboard control scheme"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Game
        m_Game = asset.FindActionMap("Game", throwIfNotFound: true);
        m_Game_Right = m_Game.FindAction("Right", throwIfNotFound: true);
        m_Game_Left = m_Game.FindAction("Left", throwIfNotFound: true);
        m_Game_Separuj_Sklo = m_Game.FindAction("Separuj_Sklo", throwIfNotFound: true);
        m_Game_Separuj_Papier = m_Game.FindAction("Separuj_Papier", throwIfNotFound: true);
        m_Game_Separuj_Plasty = m_Game.FindAction("Separuj_Plasty", throwIfNotFound: true);
        m_Game_Game = m_Game.FindAction("Game", throwIfNotFound: true);
        m_Game_End_Game = m_Game.FindAction("End_Game", throwIfNotFound: true);
        // Keyboard
        m_Keyboard = asset.FindActionMap("Keyboard", throwIfNotFound: true);
        m_Keyboard_w = m_Keyboard.FindAction("w", throwIfNotFound: true);
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

    // Game
    private readonly InputActionMap m_Game;
    private IGameActions m_GameActionsCallbackInterface;
    private readonly InputAction m_Game_Right;
    private readonly InputAction m_Game_Left;
    private readonly InputAction m_Game_Separuj_Sklo;
    private readonly InputAction m_Game_Separuj_Papier;
    private readonly InputAction m_Game_Separuj_Plasty;
    private readonly InputAction m_Game_Game;
    private readonly InputAction m_Game_End_Game;
    public struct GameActions
    {
        private @PlayerControls m_Wrapper;
        public GameActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Right => m_Wrapper.m_Game_Right;
        public InputAction @Left => m_Wrapper.m_Game_Left;
        public InputAction @Separuj_Sklo => m_Wrapper.m_Game_Separuj_Sklo;
        public InputAction @Separuj_Papier => m_Wrapper.m_Game_Separuj_Papier;
        public InputAction @Separuj_Plasty => m_Wrapper.m_Game_Separuj_Plasty;
        public InputAction @Game => m_Wrapper.m_Game_Game;
        public InputAction @End_Game => m_Wrapper.m_Game_End_Game;
        public InputActionMap Get() { return m_Wrapper.m_Game; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
        public void SetCallbacks(IGameActions instance)
        {
            if (m_Wrapper.m_GameActionsCallbackInterface != null)
            {
                @Right.started -= m_Wrapper.m_GameActionsCallbackInterface.OnRight;
                @Right.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnRight;
                @Right.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnRight;
                @Left.started -= m_Wrapper.m_GameActionsCallbackInterface.OnLeft;
                @Left.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnLeft;
                @Left.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnLeft;
                @Separuj_Sklo.started -= m_Wrapper.m_GameActionsCallbackInterface.OnSeparuj_Sklo;
                @Separuj_Sklo.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnSeparuj_Sklo;
                @Separuj_Sklo.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnSeparuj_Sklo;
                @Separuj_Papier.started -= m_Wrapper.m_GameActionsCallbackInterface.OnSeparuj_Papier;
                @Separuj_Papier.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnSeparuj_Papier;
                @Separuj_Papier.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnSeparuj_Papier;
                @Separuj_Plasty.started -= m_Wrapper.m_GameActionsCallbackInterface.OnSeparuj_Plasty;
                @Separuj_Plasty.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnSeparuj_Plasty;
                @Separuj_Plasty.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnSeparuj_Plasty;
                @Game.started -= m_Wrapper.m_GameActionsCallbackInterface.OnGame;
                @Game.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnGame;
                @Game.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnGame;
                @End_Game.started -= m_Wrapper.m_GameActionsCallbackInterface.OnEnd_Game;
                @End_Game.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnEnd_Game;
                @End_Game.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnEnd_Game;
            }
            m_Wrapper.m_GameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Right.started += instance.OnRight;
                @Right.performed += instance.OnRight;
                @Right.canceled += instance.OnRight;
                @Left.started += instance.OnLeft;
                @Left.performed += instance.OnLeft;
                @Left.canceled += instance.OnLeft;
                @Separuj_Sklo.started += instance.OnSeparuj_Sklo;
                @Separuj_Sklo.performed += instance.OnSeparuj_Sklo;
                @Separuj_Sklo.canceled += instance.OnSeparuj_Sklo;
                @Separuj_Papier.started += instance.OnSeparuj_Papier;
                @Separuj_Papier.performed += instance.OnSeparuj_Papier;
                @Separuj_Papier.canceled += instance.OnSeparuj_Papier;
                @Separuj_Plasty.started += instance.OnSeparuj_Plasty;
                @Separuj_Plasty.performed += instance.OnSeparuj_Plasty;
                @Separuj_Plasty.canceled += instance.OnSeparuj_Plasty;
                @Game.started += instance.OnGame;
                @Game.performed += instance.OnGame;
                @Game.canceled += instance.OnGame;
                @End_Game.started += instance.OnEnd_Game;
                @End_Game.performed += instance.OnEnd_Game;
                @End_Game.canceled += instance.OnEnd_Game;
            }
        }
    }
    public GameActions @Game => new GameActions(this);

    // Keyboard
    private readonly InputActionMap m_Keyboard;
    private IKeyboardActions m_KeyboardActionsCallbackInterface;
    private readonly InputAction m_Keyboard_w;
    public struct KeyboardActions
    {
        private @PlayerControls m_Wrapper;
        public KeyboardActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @w => m_Wrapper.m_Keyboard_w;
        public InputActionMap Get() { return m_Wrapper.m_Keyboard; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(KeyboardActions set) { return set.Get(); }
        public void SetCallbacks(IKeyboardActions instance)
        {
            if (m_Wrapper.m_KeyboardActionsCallbackInterface != null)
            {
                @w.started -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnW;
                @w.performed -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnW;
                @w.canceled -= m_Wrapper.m_KeyboardActionsCallbackInterface.OnW;
            }
            m_Wrapper.m_KeyboardActionsCallbackInterface = instance;
            if (instance != null)
            {
                @w.started += instance.OnW;
                @w.performed += instance.OnW;
                @w.canceled += instance.OnW;
            }
        }
    }
    public KeyboardActions @Keyboard => new KeyboardActions(this);
    private int m_XboxControlSchemeSchemeIndex = -1;
    public InputControlScheme XboxControlSchemeScheme
    {
        get
        {
            if (m_XboxControlSchemeSchemeIndex == -1) m_XboxControlSchemeSchemeIndex = asset.FindControlSchemeIndex("Xbox Control Scheme");
            return asset.controlSchemes[m_XboxControlSchemeSchemeIndex];
        }
    }
    private int m_KeyboardcontrolschemeSchemeIndex = -1;
    public InputControlScheme KeyboardcontrolschemeScheme
    {
        get
        {
            if (m_KeyboardcontrolschemeSchemeIndex == -1) m_KeyboardcontrolschemeSchemeIndex = asset.FindControlSchemeIndex("Keyboard control scheme");
            return asset.controlSchemes[m_KeyboardcontrolschemeSchemeIndex];
        }
    }
    public interface IGameActions
    {
        void OnRight(InputAction.CallbackContext context);
        void OnLeft(InputAction.CallbackContext context);
        void OnSeparuj_Sklo(InputAction.CallbackContext context);
        void OnSeparuj_Papier(InputAction.CallbackContext context);
        void OnSeparuj_Plasty(InputAction.CallbackContext context);
        void OnGame(InputAction.CallbackContext context);
        void OnEnd_Game(InputAction.CallbackContext context);
    }
    public interface IKeyboardActions
    {
        void OnW(InputAction.CallbackContext context);
    }
}
