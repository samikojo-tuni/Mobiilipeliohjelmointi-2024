//------------------------------------------------------------------------------
// <auto-generated>
//     This code was auto-generated by com.unity.inputsystem:InputActionCodeGenerator
//     version 1.7.0
//     from Assets/Config/Inputs.inputactions
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

namespace Mobiiliesimerkki
{
    public partial class @Inputs: IInputActionCollection2, IDisposable
    {
        public InputActionAsset asset { get; }
        public @Inputs()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""Inputs"",
    ""maps"": [
        {
            ""name"": ""Menu"",
            ""id"": ""0a83eec3-1cad-4094-9fdc-2c236d009b7a"",
            ""actions"": [
                {
                    ""name"": ""New action"",
                    ""type"": ""Button"",
                    ""id"": ""f9f9f2be-de59-4841-8122-42c941782484"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""e61d058f-ea2f-41a6-9516-26326531d2b6"",
                    ""path"": """",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""New action"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Game"",
            ""id"": ""9cc80d4d-78d9-4181-b77a-082ac67b27b5"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""77469ff3-b4b5-47ff-8929-36312a14db5a"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""df75d6c0-e44b-4d9c-a48b-4f1c12bb51aa"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Arrows"",
                    ""id"": ""ecac9229-2b80-4188-9f73-700da1576188"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""411336a7-9f2d-4718-8ad1-026ac5262af5"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""01d45360-0ba1-40a2-9063-e3a7ed87e322"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""8a793076-1e58-40f5-8f9b-c370175d7f59"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""b6cbea92-49c2-47ac-a04f-35b216a4bc35"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""WASD"",
                    ""id"": ""c2e45b74-deb5-4acb-860b-641e56f31437"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""cf4012f6-1ef5-4392-90c0-7d71cd0ca495"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""44e5f7e7-c178-4022-a5ea-7cce7b3bf18b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""fb61982e-8491-424c-b1de-794887b6ccd4"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""1460c307-62c5-4bdb-9db1-bee324d699c7"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""4cf8aad1-f3ec-4eef-8342-ee547ef54b5e"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9e747183-9c2c-45f6-a2da-4674512243c0"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2d9f1111-ab9a-46ab-8202-4e23a8163763"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""TapControl"",
            ""id"": ""ebafb8e9-afd9-4631-ba03-9e621c992b0d"",
            ""actions"": [
                {
                    ""name"": ""Move"",
                    ""type"": ""Value"",
                    ""id"": ""66779406-75be-41db-9fe8-b22e607cd7ad"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": true
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""22276273-18b4-4348-908e-044d0586a1b3"",
                    ""path"": ""<Touchscreen>/position"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Save"",
            ""id"": ""630f9c38-11fc-41f0-8fbe-25b823f6e6f6"",
            ""actions"": [
                {
                    ""name"": ""QuickSave"",
                    ""type"": ""Button"",
                    ""id"": ""9549e85a-7088-4d46-afc0-f92a10b58ed9"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                },
                {
                    ""name"": ""QuickLoad"",
                    ""type"": ""Button"",
                    ""id"": ""d22391c3-5755-4390-a299-b1d93b900929"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """",
                    ""initialStateCheck"": false
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6c84e38a-10ea-4939-9068-ae83edb9e339"",
                    ""path"": ""<Keyboard>/f5"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""QuickSave"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""95e08ba9-cff2-442f-91b9-f526900cfc2f"",
                    ""path"": ""<Keyboard>/f6"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""QuickLoad"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": []
}");
            // Menu
            m_Menu = asset.FindActionMap("Menu", throwIfNotFound: true);
            m_Menu_Newaction = m_Menu.FindAction("New action", throwIfNotFound: true);
            // Game
            m_Game = asset.FindActionMap("Game", throwIfNotFound: true);
            m_Game_Move = m_Game.FindAction("Move", throwIfNotFound: true);
            m_Game_Interact = m_Game.FindAction("Interact", throwIfNotFound: true);
            // TapControl
            m_TapControl = asset.FindActionMap("TapControl", throwIfNotFound: true);
            m_TapControl_Move = m_TapControl.FindAction("Move", throwIfNotFound: true);
            // Save
            m_Save = asset.FindActionMap("Save", throwIfNotFound: true);
            m_Save_QuickSave = m_Save.FindAction("QuickSave", throwIfNotFound: true);
            m_Save_QuickLoad = m_Save.FindAction("QuickLoad", throwIfNotFound: true);
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

        // Menu
        private readonly InputActionMap m_Menu;
        private List<IMenuActions> m_MenuActionsCallbackInterfaces = new List<IMenuActions>();
        private readonly InputAction m_Menu_Newaction;
        public struct MenuActions
        {
            private @Inputs m_Wrapper;
            public MenuActions(@Inputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @Newaction => m_Wrapper.m_Menu_Newaction;
            public InputActionMap Get() { return m_Wrapper.m_Menu; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(MenuActions set) { return set.Get(); }
            public void AddCallbacks(IMenuActions instance)
            {
                if (instance == null || m_Wrapper.m_MenuActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_MenuActionsCallbackInterfaces.Add(instance);
                @Newaction.started += instance.OnNewaction;
                @Newaction.performed += instance.OnNewaction;
                @Newaction.canceled += instance.OnNewaction;
            }

            private void UnregisterCallbacks(IMenuActions instance)
            {
                @Newaction.started -= instance.OnNewaction;
                @Newaction.performed -= instance.OnNewaction;
                @Newaction.canceled -= instance.OnNewaction;
            }

            public void RemoveCallbacks(IMenuActions instance)
            {
                if (m_Wrapper.m_MenuActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IMenuActions instance)
            {
                foreach (var item in m_Wrapper.m_MenuActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_MenuActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public MenuActions @Menu => new MenuActions(this);

        // Game
        private readonly InputActionMap m_Game;
        private List<IGameActions> m_GameActionsCallbackInterfaces = new List<IGameActions>();
        private readonly InputAction m_Game_Move;
        private readonly InputAction m_Game_Interact;
        public struct GameActions
        {
            private @Inputs m_Wrapper;
            public GameActions(@Inputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_Game_Move;
            public InputAction @Interact => m_Wrapper.m_Game_Interact;
            public InputActionMap Get() { return m_Wrapper.m_Game; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GameActions set) { return set.Get(); }
            public void AddCallbacks(IGameActions instance)
            {
                if (instance == null || m_Wrapper.m_GameActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_GameActionsCallbackInterfaces.Add(instance);
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
            }

            private void UnregisterCallbacks(IGameActions instance)
            {
                @Move.started -= instance.OnMove;
                @Move.performed -= instance.OnMove;
                @Move.canceled -= instance.OnMove;
                @Interact.started -= instance.OnInteract;
                @Interact.performed -= instance.OnInteract;
                @Interact.canceled -= instance.OnInteract;
            }

            public void RemoveCallbacks(IGameActions instance)
            {
                if (m_Wrapper.m_GameActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(IGameActions instance)
            {
                foreach (var item in m_Wrapper.m_GameActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_GameActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public GameActions @Game => new GameActions(this);

        // TapControl
        private readonly InputActionMap m_TapControl;
        private List<ITapControlActions> m_TapControlActionsCallbackInterfaces = new List<ITapControlActions>();
        private readonly InputAction m_TapControl_Move;
        public struct TapControlActions
        {
            private @Inputs m_Wrapper;
            public TapControlActions(@Inputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @Move => m_Wrapper.m_TapControl_Move;
            public InputActionMap Get() { return m_Wrapper.m_TapControl; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(TapControlActions set) { return set.Get(); }
            public void AddCallbacks(ITapControlActions instance)
            {
                if (instance == null || m_Wrapper.m_TapControlActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_TapControlActionsCallbackInterfaces.Add(instance);
                @Move.started += instance.OnMove;
                @Move.performed += instance.OnMove;
                @Move.canceled += instance.OnMove;
            }

            private void UnregisterCallbacks(ITapControlActions instance)
            {
                @Move.started -= instance.OnMove;
                @Move.performed -= instance.OnMove;
                @Move.canceled -= instance.OnMove;
            }

            public void RemoveCallbacks(ITapControlActions instance)
            {
                if (m_Wrapper.m_TapControlActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(ITapControlActions instance)
            {
                foreach (var item in m_Wrapper.m_TapControlActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_TapControlActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public TapControlActions @TapControl => new TapControlActions(this);

        // Save
        private readonly InputActionMap m_Save;
        private List<ISaveActions> m_SaveActionsCallbackInterfaces = new List<ISaveActions>();
        private readonly InputAction m_Save_QuickSave;
        private readonly InputAction m_Save_QuickLoad;
        public struct SaveActions
        {
            private @Inputs m_Wrapper;
            public SaveActions(@Inputs wrapper) { m_Wrapper = wrapper; }
            public InputAction @QuickSave => m_Wrapper.m_Save_QuickSave;
            public InputAction @QuickLoad => m_Wrapper.m_Save_QuickLoad;
            public InputActionMap Get() { return m_Wrapper.m_Save; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(SaveActions set) { return set.Get(); }
            public void AddCallbacks(ISaveActions instance)
            {
                if (instance == null || m_Wrapper.m_SaveActionsCallbackInterfaces.Contains(instance)) return;
                m_Wrapper.m_SaveActionsCallbackInterfaces.Add(instance);
                @QuickSave.started += instance.OnQuickSave;
                @QuickSave.performed += instance.OnQuickSave;
                @QuickSave.canceled += instance.OnQuickSave;
                @QuickLoad.started += instance.OnQuickLoad;
                @QuickLoad.performed += instance.OnQuickLoad;
                @QuickLoad.canceled += instance.OnQuickLoad;
            }

            private void UnregisterCallbacks(ISaveActions instance)
            {
                @QuickSave.started -= instance.OnQuickSave;
                @QuickSave.performed -= instance.OnQuickSave;
                @QuickSave.canceled -= instance.OnQuickSave;
                @QuickLoad.started -= instance.OnQuickLoad;
                @QuickLoad.performed -= instance.OnQuickLoad;
                @QuickLoad.canceled -= instance.OnQuickLoad;
            }

            public void RemoveCallbacks(ISaveActions instance)
            {
                if (m_Wrapper.m_SaveActionsCallbackInterfaces.Remove(instance))
                    UnregisterCallbacks(instance);
            }

            public void SetCallbacks(ISaveActions instance)
            {
                foreach (var item in m_Wrapper.m_SaveActionsCallbackInterfaces)
                    UnregisterCallbacks(item);
                m_Wrapper.m_SaveActionsCallbackInterfaces.Clear();
                AddCallbacks(instance);
            }
        }
        public SaveActions @Save => new SaveActions(this);
        public interface IMenuActions
        {
            void OnNewaction(InputAction.CallbackContext context);
        }
        public interface IGameActions
        {
            void OnMove(InputAction.CallbackContext context);
            void OnInteract(InputAction.CallbackContext context);
        }
        public interface ITapControlActions
        {
            void OnMove(InputAction.CallbackContext context);
        }
        public interface ISaveActions
        {
            void OnQuickSave(InputAction.CallbackContext context);
            void OnQuickLoad(InputAction.CallbackContext context);
        }
    }
}
