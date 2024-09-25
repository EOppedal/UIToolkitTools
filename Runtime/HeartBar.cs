using UnityEngine;
using UnityEngine.UIElements;

namespace UIToolkitTools {
    [UxmlElement] 
    public partial class HeartBar : VisualElement {
        private int _heartCount;
        private Sprite _heartIcon;

        [UxmlAttribute]
        public int HeartCount {
            get => _heartCount;
            set {
                _heartCount = value;
                UpdateHearts(_heartCount);
            }
        }

        [UxmlAttribute]
        public Sprite HeartIcon {
            get => _heartIcon;
            set {
                _heartIcon = value;
                UpdateHearts(HeartCount);
            }
        }

        private void UpdateHearts(int heartCount) {
            if (_heartIcon == null) return;
            
            Clear();

            for (var i = 0; i < heartCount; i++) {
                var heartImage = new VisualElement {
                    style = {
                        backgroundImage = new StyleBackground(_heartIcon),
                        marginRight = 1,
                        width = 15,
                        height = 12
                    }
                };
                Add(heartImage);
            }
        }
    }   
}