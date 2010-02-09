using System;
using System.Globalization;
using Mogre;

namespace Wof.Controller.Indicators
{
    /// <summary>
    /// Klasa przechowuj�ca informacje o pojedynczej wiadomo�ci. 
    /// x, y - wsp�rz�dne w zakresie [0-1], licz�c od lewego g�rnego rogu ekranu (nale�y pami�ta� o tym, �e istnieje niewielki margines)
    /// time - czas przez jaki pokazywana jest wiadomo��.
    /// </summary>
    public class MessageEntry
    {
        private bool blinking;

        public bool Blinking
        {
            get { return blinking; }
        }


        private bool permanent;

        public bool Permanent
        {
            get { return permanent; }
        }

        protected float x;

        public float X
        {
            get { return x; }
        }

        public void IncreaseX(float x)
        {
            this.x += x;
        }

        protected float y;

        public float Y
        {
            get { return y; }
        }

        public void IncreaseY(float y)
        {
            this.y += y;
        }


        private String message;

        public String Message
        {
            get { return message; }
        }

        private uint time;

        public uint Time
        {
            get { return time; }
        }

        private float charHeight;

        public float CharHeight
        {
            get { return charHeight; }
        }

        public String getCharHeightString()
        {
            return StringConverter.ToString(charHeight);
            //return String.Format(EngineConfig.Nfi, "{0:f}", charHeight);
        }

        private ColourValue colourTop;

        public String ColourTop
        {

            get { return String.Format("{0:f} {1:f} {2:f}", StringConverter.ToString(colourTop.r), StringConverter.ToString(colourTop.g), StringConverter.ToString(colourTop.b)); }
        }

        private ColourValue colourBottom;

        public String ColourBottom
        {
            get { return String.Format("{0:f} {1:f} {2:f}", StringConverter.ToString(colourBottom.r), StringConverter.ToString(colourBottom.g), StringConverter.ToString(colourBottom.b)); }
        }


        private static ColourValue defaultColourTop = new ColourValue(0.6f, 0.34f, 0.34f);

        public static ColourValue DefaultColourTop
        {
            get { return defaultColourTop; }
        }

        private static ColourValue defaultColourBottom = new ColourValue(0.8f, 0.1f, 0.1f);
       
        protected int charsPerLine = 55;

        public static ColourValue DefaultColourBottom
        {
            get { return defaultColourBottom; }
        }

        public int CharsPerLine
        {
            get { return charsPerLine; }
            set { charsPerLine = value; }
        }

        protected virtual void Init()
        {
            
        }

        public MessageEntry(float x, float y, uint time, String message, float charHeight, ColourValue colourTop,
                            ColourValue colourBottom, bool blinking, bool permanent)
        {
            this.x = x;
            this.y = y;
            this.time = time;
            this.message = message;
            this.charHeight = charHeight;
            this.colourTop = colourTop;
            this.colourBottom = colourBottom;
            this.blinking = blinking;
            this.permanent = permanent;
            Init();
                    
        }

        public MessageEntry(uint time, String message, float charHeight, ColourValue colourTop, ColourValue colourBottom)
            : this(0, 0, time, message, charHeight, colourTop, colourBottom, false, false)

        {
        }

      

        public MessageEntry(uint time, String message)
            : this(0, 0, time, message, EngineConfig.CurrentFontSize, DefaultColourTop, DefaultColourBottom, false, false)
        {
        }

    

        public MessageEntry(float x, float y, String message, bool blinking, bool permanent)
            : this(x, y, 3000, message, EngineConfig.CurrentFontSize, DefaultColourTop, DefaultColourBottom, blinking, permanent)
        {
        }

        public MessageEntry(float x, float y, String message)
            : this(x, y, message, false, false)
        {
        }

        public MessageEntry(float x, float y, String message, uint time)
            : this(x, y, time, message, EngineConfig.CurrentFontSize, DefaultColourTop, DefaultColourBottom, false, false)
        {
        }

        public MessageEntry(String message) : this(4000, message)
        {
        }
    }
}