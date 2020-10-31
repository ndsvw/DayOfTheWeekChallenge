using Blazored.LocalStorage;

namespace DayOfTheWeekChallenge.Core
{
    public class LocalStorageSetting<T> : ISetting
    {
        private readonly string m_Key;

        private T m_Value;

        private readonly ISyncLocalStorageService m_LocalStorage;

        public T Value {
            get => m_Value;
            set
            {
                m_Value = value;
                m_LocalStorage.SetItem(m_Key, value);
            }
        }

        public LocalStorageSetting(ISyncLocalStorageService pLocalStorage, string pKey) : this(pLocalStorage, pKey, default) { }

        public LocalStorageSetting(ISyncLocalStorageService pLocalStorage, string pKey, T pDefaultValue)
        {
            m_Key = pKey;
            m_LocalStorage = pLocalStorage;
            if (m_LocalStorage.ContainKey(m_Key))
            {
                m_Value = m_LocalStorage.GetItem<T>(m_Key);
            }
            else
            {
                m_Value = pDefaultValue;
                m_LocalStorage.SetItem(m_Key, pDefaultValue);
            }
        }
    }
}
