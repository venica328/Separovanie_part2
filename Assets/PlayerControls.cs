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
                    ""name"": ""R_Move"",
                    ""type"": ""Button"",
                    ""id"": ""699ac630-1adc-4005-b32b-22234fd6a028"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""L_Move"",
                    ""type"": ""Button"",
                    ""id"": ""59ce9de3-6777-4c25-921a-7681275c3aea"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Separuj_Sklo"",
                    ""type"": ""Button"",
                    ""id"": ""8bb1b64e-e005-4696-b0b6-a3210cc98b67"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Separuj_Papier"",
                    ""type"": ""Button"",
                    ""id"": ""ed4d0cd1-d951-409e-a73a-20b46af1b08b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Separuj_Plasty"",
                    ""type"": ""Button"",
                    ""id"": ""1b01437b-8832-4965-a371-b514e3a60dc6"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Start_Game"",
                    ""type"": ""Button"",
                    ""id"": ""de8fd18a-c45b-45d2-8a79-66bd551fb197"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""End_Game"",
                    ""type"": ""Button"",
                    ""id"": ""78f37276-4ae9-46a3-9d8e-f9cf4ac30386"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""1cd39ebd-0e0b-415a-bd96-a459e8776304"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""R_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a9f481bd-e047-4d2d-943f-b12a7c0f7c2b"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""L_Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5f339a8b-a2bb-446a-83c3-21872b2c0d79"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Separuj_Sklo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""22a231c6-e151-40bd-9bf2-f7373435b1ba"",
                    ""path"": ""<Gamepad>/buttonWest"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Separuj_Papier"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""35ce94ab-7fe1-4952-bacc-39635b451c41"",
                    ""path"": ""<Gamepad>/buttonNorth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Separuj_Plasty"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""405a5928-3363-4385-960a-aa08924634c0"",
                    ""path"": ""<XboxOneGampadiOS>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Start_Game"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""970d0d09-998f-4021-a23e-1519f60676f7"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""End_Game"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
        // Game
        m_Game = asset.FindActionMap("Game", throwIfNotFound: true);
        m_Game_R_Move = m_Game.FindAction("R_Move", throwIfNotFound: true);
        m_Game_L_Move = m_Game.FindAction("L_Move", throwIfNotFound: true);
        m_Game_Separuj_Sklo = m_Game.FindAction("Separuj_Sklo", throwIfNotFound: true);
        m_Game_Separuj_Papier = m_Game.FindAction("Separuj_Papier", throwIfNotFound: true);
        m_Game_Separuj_Plasty = m_Game.FindAction("Separuj_Plasty", throwIfNotFound: true);
        m_Game_Start_Game = m_Game.FindAction("Start_Game", throwIfNotFound: true);
        m_Game_End_Game = m_Game.FindAction("End_Game", throwIfNotFound: true);
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
    private readonly InputAction m_Game_R_Move;
    private readonly InputAction m_Game_L_Move;
    private readonly InputAction m_Game_Separuj_Sklo;
    private readonly InputAction m_Game_Separuj_Papier;
    private readonly InputAction m_Game_Separuj_Plasty;
    private readonly InputAction m_Game_Start_Game;
    private readonly InputAction m_Game_End_Game;
    public struct GameActions
    {
        private @PlayerControls m_Wrapper;
        public GameActions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @R_Move => m_Wrapper.m_Game_R_Move;
        public InputAction @L_Move => m_Wrapper.m_Game_L_Move;
        public InputAction @Separuj_Sklo => m_Wrapper.m_Game_Separuj_Sklo;
        public InputAction @Separuj_Papier => m_Wrapper.m_Game_Separuj_Papier;
        public InputAction @Separuj_Plasty => m_Wrapper.m_Game_Separuj_Plasty;
        public InputAction @Start_Game => m_Wrapper.m_Game_Start_Game;
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
                @R_Move.started -= m_Wrapper.m_GameActionsCallbackInterface.OnR_Move;
                @R_Move.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnR_Move;
                @R_Move.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnR_Move;
                @L_Move.started -= m_Wrapper.m_GameActionsCallbackInterface.OnL_Move;
                @L_Move.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnL_Move;
                @L_Move.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnL_Move;
                @Separuj_Sklo.started -= m_Wrapper.m_GameActionsCallbackInterface.OnSeparuj_Sklo;
                @Separuj_Sklo.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnSeparuj_Sklo;
                @Separuj_Sklo.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnSeparuj_Sklo;
                @Separuj_Papier.started -= m_Wrapper.m_GameActionsCallbackInterface.OnSeparuj_Papier;
                @Separuj_Papier.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnSeparuj_Papier;
                @Separuj_Papier.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnSeparuj_Papier;
                @Separuj_Plasty.started -= m_Wrapper.m_GameActionsCallbackInterface.OnSeparuj_Plasty;
                @Separuj_Plasty.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnSeparuj_Plasty;
                @Separuj_Plasty.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnSeparuj_Plasty;
                @Start_Game.started -= m_Wrapper.m_GameActionsCallbackInterface.OnStart_Game;
                @Start_Game.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnStart_Game;
                @Start_Game.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnStart_Game;
                @End_Game.started -= m_Wrapper.m_GameActionsCallbackInterface.OnEnd_Game;
                @End_Game.performed -= m_Wrapper.m_GameActionsCallbackInterface.OnEnd_Game;
                @End_Game.canceled -= m_Wrapper.m_GameActionsCallbackInterface.OnEnd_Game;
            }
            m_Wrapper.m_GameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @R_Move.started += instance.OnR_Move;
                @R_Move.performed += instance.OnR_Move;
                @R_Move.canceled += instance.OnR_Move;
                @L_Move.started += instance.OnL_Move;
                @L_Move.performed += instance.OnL_Move;
                @L_Move.canceled += instance.OnL_Move;
                @Separuj_Sklo.started += instance.OnSeparuj_Sklo;
                @Separuj_Sklo.performed += instance.OnSeparuj_Sklo;
                @Separuj_Sklo.canceled += instance.OnSeparuj_Sklo;
                @Separuj_Papier.started += instance.OnSeparuj_Papier;
                @Separuj_Papier.performed += instance.OnSeparuj_Papier;
                @Separuj_Papier.canceled += instance.OnSeparuj_Papier;
                @Separuj_Plasty.started += instance.OnSeparuj_Plasty;
                @Separuj_Plasty.performed += instance.OnSeparuj_Plasty;
                @Separuj_Plasty.canceled += instance.OnSeparuj_Plasty;
                @Start_Game.started += instance.OnStart_Game;
                @Start_Game.performed += instance.OnStart_Game;
                @Start_Game.canceled += instance.OnStart_Game;
                @End_Game.started += instance.OnEnd_Game;
                @End_Game.performed += instance.OnEnd_Game;
                @End_Game.canceled += instance.OnEnd_Game;
            }
        }
    }
    public GameActions @Game => new GameActions(this);
    public interface IGameActions
    {
        void OnR_Move(InputAction.CallbackContext context);
        void OnL_Move(InputAction.CallbackContext context);
        void OnSeparuj_Sklo(InputAction.CallbackContext context);
        void OnSeparuj_Papier(InputAction.CallbackContext context);
        void OnSeparuj_Plasty(InputAction.CallbackContext context);
        void OnStart_Game(InputAction.CallbackContext context);
        void OnEnd_Game(InputAction.CallbackContext context);
    }
}
