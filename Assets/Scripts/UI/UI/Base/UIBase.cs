using UnityEngine;
using Const;
using System.Collections.Generic;

namespace UIFrame
{
    /// <summary>
    /// UI������
    /// </summary>
    public abstract class UIBase : MonoBehaviour
    {
        private UIState _uiState = UIState.NORMAL;
        public  UIState uiState
        {
            get { return _uiState; }
            set { 
                HandleUIState(value);
                _uiState = value;
            }
        }

        private void HandleUIState(UIState value)
        {
            switch (value)
            {
                case UIState.INIT:
                    if (_uiState == UIState.NORMAL)
                    {
                        Init();
                    }
                    break;
                case UIState.SHOW:
                    if (_uiState == UIState.NORMAL)
                    {
                        Init();
                        Show();
                    }
                    else
                    {
                        Show();
                    }
                    break;
                case UIState.HIDE:
                    Hide();
                    break;
            }
        }

        protected virtual void Init()
        {
            
        }

        protected virtual void Show()
        {
            
        }

        protected virtual void Hide()
        {
            
        }

        protected virtual void SetActive(bool active)
        {
            gameObject.SetActive(active);
        }

        public abstract UiId GetUiId();
        public abstract List<Transform> GetBtnParents();
        public abstract UILayer GetUiLayer();
    }
}
