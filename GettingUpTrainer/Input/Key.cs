using System.Configuration;
using System.Xml.Serialization;

namespace GettingUpTrainer
{
    [SettingsSerializeAs(SettingsSerializeAs.Xml)]
    public class Key
    {
        private int keyId;
        private string keyName;
        private bool keyDown;

        public Key()
        {
            // Used for XML serialization
        }

        public Key(int keyId, string keyName)
        {
            this.keyId = keyId;
            this.keyName = keyName;
        }

        public string Name
        {
            get
            {
                return keyName;
            }
            set
            {
                keyName = value;
            }
        }

        public int Id
        {
            get
            {
                return keyId;
            }
            set
            {
                keyId = value;
            }
        }

        [XmlIgnore]
        public bool IsKeyDown
        {
            get
            {
                return keyDown;
            }
            set
            {
                keyDown = value;
            }
        }
    }
}
