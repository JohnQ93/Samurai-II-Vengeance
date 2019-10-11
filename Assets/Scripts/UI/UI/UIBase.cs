using UnityEngine;
using Const;

namespace UIFrame
{
    /// <summary>
    /// UI������
    /// </summary>
    public abstract class UIBase : MonoBehaviour
    {
        //��ǰUI�Ĳ㼶
        public UILayer Layer { get; protected set; }
        private UIState _uiState = UIState.NORMAL;
        public  UIState uiState
        {
            get { return _uiState; }
            set { HandleUIState(value); }
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
            uiState = UIState.INIT;
        }

        protected virtual void Show()
        {
            uiState = UIState.SHOW;
            SetActive(true);
        }

        protected virtual void Hide()
        {
            uiState = UIState.HIDE;
            SetActive(false);
        }

        protected virtual void SetActive(bool active)
        {
            gameObject.SetActive(active);
        }

        public abstract UIState GetUiId();
    }
}