﻿/*
 * Copyright 2008 Adam Witczak, Jakub Tężycki, Kamil Sławiński, Tomasz Bilski, Emil Hornung, Michał Ziober
 *
 * This file is part of Wings Of Fury 2.
 * 
 * Freeware Licence Agreement
 * 
 * This licence agreement only applies to the free version of this software.
 * Terms and Conditions
 * 
 * BY DOWNLOADING, INSTALLING, USING, TRANSMITTING, DISTRIBUTING OR COPYING THIS SOFTWARE ("THE SOFTWARE"), YOU AGREE TO THE TERMS OF THIS AGREEMENT (INCLUDING THE SOFTWARE LICENCE AND DISCLAIMER OF WARRANTY) WITH WINGSOFFURY2.COM THE OWNER OF ALL RIGHTS IN RESPECT OF THE SOFTWARE.
 * 
 * PLEASE READ THIS DOCUMENT CAREFULLY BEFORE USING THE SOFTWARE.
 *  
 * IF YOU DO NOT AGREE TO ANY OF THE TERMS OF THIS LICENCE THEN DO NOT DOWNLOAD, INSTALL, USE, TRANSMIT, DISTRIBUTE OR COPY THE SOFTWARE.
 * 
 * THIS DOCUMENT CONSTITUES A LICENCE TO USE THE SOFTWARE ON THE TERMS AND CONDITIONS APPEARING BELOW.
 * 
 * The Software is licensed to you without charge for use only upon the terms of this licence, and WINGSOFFURY2.COM reserves all rights not expressly granted to you. WINGSOFFURY2.COM retains ownership of all copies of the Software.
 * 1. Licence
 * 
 * You may use the Software without charge.
 *  
 * You may distribute exact copies of the Software to anyone.
 * 2. Restrictions
 * 
 * WINGSOFFURY2.COM reserves the right to revoke the above distribution right at any time, for any or no reason.
 *  
 * YOU MAY NOT MODIFY, ADAPT, TRANSLATE, RENT, LEASE, LOAN, SELL, REQUEST DONATIONS OR CREATE DERIVATE WORKS BASED UPON THE SOFTWARE OR ANY PART THEREOF.
 * 
 * The Software contains trade secrets and to protect them you may not decompile, reverse engineer, disassemble or otherwise reduce the Software to a humanly perceivable form. You agree not to divulge, directly or indirectly, until such trade secrets cease to be confidential, for any reason not your own fault.
 * 3. Termination
 * 
 * This licence is effective until terminated. The Licence will terminate automatically without notice from WINGSOFFURY2.COM if you fail to comply with any provision of this Licence. Upon termination you must destroy the Software and all copies thereof. You may terminate this Licence at any time by destroying the Software and all copies thereof. Upon termination of this licence for any reason you shall continue to be bound by the provisions of Section 2 above. Termination will be without prejudice to any rights WINGSOFFURY2.COM may have as a result of this agreement.
 * 4. Disclaimer of Warranty, Limitation of Remedies
 * 
 * TO THE FULL EXTENT PERMITTED BY LAW, WINGSOFFURY2.COM HEREBY EXCLUDES ALL CONDITIONS AND WARRANTIES, WHETHER IMPOSED BY STATUTE OR BY OPERATION OF LAW OR OTHERWISE, NOT EXPRESSLY SET OUT HEREIN. THE SOFTWARE, AND ALL ACCOMPANYING FILES, DATA AND MATERIALS ARE DISTRIBUTED "AS IS" AND WITH NO WARRANTIES OF ANY KIND, WHETHER EXPRESS OR IMPLIED. WINGSOFFURY2.COM DOES NOT WARRANT, GUARANTEE OR MAKE ANY REPRESENTATIONS REGARDING THE USE, OR THE RESULTS OF THE USE, OF THE SOFTWARE WITH RESPECT TO ITS CORRECTNESS, ACCURACY, RELIABILITY, CURRENTNESS OR OTHERWISE. THE ENTIRE RISK OF USING THE SOFTWARE IS ASSUMED BY YOU. WINGSOFFURY2.COM MAKES NO EXPRESS OR IMPLIED WARRANTIES OR CONDITIONS INCLUDING, WITHOUT LIMITATION, THE WARRANTIES OF MERCHANTABILITY OR FITNESS FOR A PARTICULAR PURPOSE WITH RESPECT TO THE SOFTWARE. NO ORAL OR WRITTEN INFORMATION OR ADVICE GIVEN BY WINGSOFFURY2.COM, IT'S DISTRIBUTORS, AGENTS OR EMPLOYEES SHALL CREATE A WARRANTY, AND YOU MAY NOT RELY ON ANY SUCH INFORMATION OR ADVICE.
 * 
 * IMPORTANT NOTE: Nothing in this Agreement is intended or shall be construed as excluding or modifying any statutory rights, warranties or conditions which by virtue of any national or state Fair Trading, Trade Practices or other such consumer legislation may not be modified or excluded. If permitted by such legislation, however, WINGSOFFURY2.COM' liability for any breach of any such warranty or condition shall be and is hereby limited to the supply of the Software licensed hereunder again as WINGSOFFURY2.COM at its sole discretion may determine to be necessary to correct the said breach.
 * 
 * IN NO EVENT SHALL WINGSOFFURY2.COM BE LIABLE FOR ANY SPECIAL, INCIDENTAL, INDIRECT OR CONSEQUENTIAL DAMAGES (INCLUDING, WITHOUT LIMITATION, DAMAGES FOR LOSS OF BUSINESS PROFITS, BUSINESS INTERRUPTION, AND THE LOSS OF BUSINESS INFORMATION OR COMPUTER PROGRAMS), EVEN IF WINGSOFFURY2.COM OR ANY WINGSOFFURY2.COM REPRESENTATIVE HAS BEEN ADVISED OF THE POSSIBILITY OF SUCH DAMAGES. IN ADDITION, IN NO EVENT DOES WINGSOFFURY2.COM AUTHORISE YOU TO USE THE SOFTWARE IN SITUATIONS WHERE FAILURE OF THE SOFTWARE TO PERFORM CAN REASONABLY BE EXPECTED TO RESULT IN A PHYSICAL INJURY, OR IN LOSS OF LIFE. ANY SUCH USE BY YOU IS ENTIRELY AT YOUR OWN RISK, AND YOU AGREE TO HOLD WINGSOFFURY2.COM HARMLESS FROM ANY CLAIMS OR LOSSES RELATING TO SUCH UNAUTHORISED USE.
 * 5. General
 * 
 * All rights of any kind in the Software which are not expressly granted in this Agreement are entirely and exclusively reserved to and by WINGSOFFURY2.COM.
 * 
 * 
 */

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using System.Text;

using MOIS;
using Wof.Misc;

namespace Wof.Controller.Input.KeyboardAndJoystick
{
	
	
    /// <summary>
    /// Mapa klawiszy odpowiadajaca odpowiednim zadaniom.
    /// </summary>
    public class KeyMap : IniFileConfiguration<KeyMap>
    {
    	private static Dictionary<KeyCode, String> russianKeyMapping;
    	private static Dictionary<KeyCode, String> ukrainianKeyMapping;
    	
        #region Private Constructor

        private KeyMap() : base("KeyMap") 
        {
        	russianKeyMapping = new Dictionary<KeyCode, String>() {         		
        		{KeyCode.KC_GRAVE, "ё"},
        		{KeyCode.KC_Q, "й"},
        		{KeyCode.KC_W, "ц"},
        		{KeyCode.KC_E, "у"},
        		{KeyCode.KC_R, "к"},
        		{KeyCode.KC_T, "е"},        		
        		{KeyCode.KC_Y, "н"},
        		{KeyCode.KC_U, "г"},        		
        		{KeyCode.KC_I, "ш"},
        		{KeyCode.KC_O, "щ"},        		
        		{KeyCode.KC_P, "з"},
        		{KeyCode.KC_LBRACKET, "х"},
        		{KeyCode.KC_RBRACKET, "ъ"},        		
        		{KeyCode.KC_A, "ф"},
        		{KeyCode.KC_S, "ы"},        		
        		{KeyCode.KC_D, "в"},
        		{KeyCode.KC_F, "а"},        		
        		{KeyCode.KC_G, "п"},
        		{KeyCode.KC_H, "р"},        		
        		{KeyCode.KC_J, "о"},
        		{KeyCode.KC_K, "л"},        		
        		{KeyCode.KC_L, "д"},
        		{KeyCode.KC_SEMICOLON, "ж"},        		
        		{KeyCode.KC_APOSTROPHE, "э"}, // '
        		{KeyCode.KC_Z, "я"},        		
        		{KeyCode.KC_X, "ч"},
        		{KeyCode.KC_C, "c"},        		
        		{KeyCode.KC_V, "м"},
        		{KeyCode.KC_B, "и"},        		
        		{KeyCode.KC_N, "т"},
        		{KeyCode.KC_M, "ь"},        		        		
        		{KeyCode.KC_COMMA, "б"},
        		{KeyCode.KC_PERIOD, "ю"},
        		{KeyCode.KC_SLASH, "."},        	    	
        	};     
    
        	ukrainianKeyMapping = new Dictionary<KeyCode, String>() {         		
        		{KeyCode.KC_GRAVE, "ё"},
        		{KeyCode.KC_Q, "й"},
        		{KeyCode.KC_W, "ц"},
        		{KeyCode.KC_E, "у"},
        		{KeyCode.KC_R, "к"},
        		{KeyCode.KC_T, "е"},        		
        		{KeyCode.KC_Y, "н"},
        		{KeyCode.KC_U, "г"},        		
        		{KeyCode.KC_I, "ш"},
        		{KeyCode.KC_O, "щ"},        		
        		{KeyCode.KC_P, "з"},
        		{KeyCode.KC_LBRACKET, "х"},
        		{KeyCode.KC_RBRACKET, "ї"},        		
        		{KeyCode.KC_A, "ф"},
        		{KeyCode.KC_S, "і"},        		
        		{KeyCode.KC_D, "в"},
        		{KeyCode.KC_F, "а"},        		
        		{KeyCode.KC_G, "п"},
        		{KeyCode.KC_H, "р"},        		
        		{KeyCode.KC_J, "о"},
        		{KeyCode.KC_K, "л"},        		
        		{KeyCode.KC_L, "д"},
        		{KeyCode.KC_SEMICOLON, "ж"},        		
        		{KeyCode.KC_APOSTROPHE, "є"}, // '
        		{KeyCode.KC_Z, "я"},        		
        		{KeyCode.KC_X, "ч"},
        		{KeyCode.KC_C, "c"},        		
        		{KeyCode.KC_V, "м"},
        		{KeyCode.KC_B, "и"},        		
        		{KeyCode.KC_N, "т"},
        		{KeyCode.KC_M, "ь"},        		        		
        		{KeyCode.KC_COMMA, "б"},
        		{KeyCode.KC_PERIOD, "ю"},
        		{KeyCode.KC_SLASH, "."},        	    	
        	};     
    
        }
        
        #endregion

        #region Singleton

        /// <summary>
        /// Instancja klasy
        /// </summary>
        public static readonly KeyMap Instance = (new KeyMap()).Value;

        #endregion
        
        protected string GetString(string key, string defaultValue)
        {
            try
            {
                string s = GetString(key);
                if(s.Length == 0) return defaultValue;
                return s;
            }
            catch(Exception)
            {
                return defaultValue;
            }
        	
        }
        
        private KeyCode GetKeyCode(string iniKey, string defaultValue)
        {
            return (KeyCode)KeyCode.Parse(typeof(KeyCode), GetString(iniKey, defaultValue));
        }
        
        private MOIS.Keyboard.Modifier GetModifier(string iniKey, string defaultValue)
        {
            return (MOIS.Keyboard.Modifier)KeyCode.Parse(typeof(MOIS.Keyboard.Modifier), GetString(iniKey, defaultValue));
        }
        
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();        	
            sb.AppendLine("KeyMap object:");
            sb.AppendLine("_cam1:" + _cam1);
            sb.AppendLine("_cam2:" + _cam2);
            sb.AppendLine("_cam3:" + _cam3);
            sb.AppendLine("_cam4:" + _cam4);
            sb.AppendLine("_cam5:" + _cam5);
            sb.AppendLine("_cam6:" + _cam6);
            sb.AppendLine("_resetCamera:" + _resetCamera);
            sb.AppendLine("_pausePlane:" + _pausePlane);
            
            

            sb.AppendLine("_altFire:" + _altFire);
            sb.AppendLine("_gunFire:" + _gunFire);
            sb.AppendLine("_up:" + _up);
            sb.AppendLine("_down:" + _down);
            sb.AppendLine("_left:" + _left);
            sb.AppendLine("_right:" + _right);
            sb.AppendLine("_bulletTimeEffect:" + _bulletTimeEffect);
            sb.AppendLine("_enter:" + _enter);
            sb.AppendLine("_back:" + _back);
            sb.AppendLine("_gear:" + _gear);
            sb.AppendLine("_camera:" + _camera);
            sb.AppendLine("_zoomIn:" + _zoomIn);
            sb.AppendLine("_zoomOut:" + _zoomOut);
            sb.AppendLine("_engine:" + _engine);
            sb.AppendLine("_spin:" + _spin);
           
            sb.AppendLine("Joystick options");
  			sb.AppendLine("_currentJoystick:" + _currentJoystick);
            sb.AppendLine("_joystickBulletTimeEffect:" + _joystickBulletTimeEffect);
            sb.AppendLine("_joystickCamera:" + _joystickCamera);
            sb.AppendLine("_joystickEngine:" + _joystickEngine);
            sb.AppendLine("_joystickEnter:" + _joystickEnter);
            sb.AppendLine("_joystickEscape:" + _joystickEscape);
            sb.AppendLine("_joystickGear:" + _joystickGear);
            sb.AppendLine("_joystickGun:" + _joystickGun);
            sb.AppendLine("_joystickRocket:" + _joystickRocket);
            sb.AppendLine("_joystickSpin:" + _joystickSpin);
            sb.AppendLine("_joystickVerticalAxisNo:" + _joystickVerticalAxisNo);
            sb.AppendLine("_joystickHorizontalAxisNo:" + _joystickHorizontalAxisNo);
            sb.AppendLine("_joystickDeadZone:" + _joystickDeadZone);
            sb.AppendLine("_joystickSensivity:" + _joystickSensivity);
            
            return sb.ToString();
        }
        
        public void BackToDefaults(IList<JoyStick> joysticks)
		{
        	_cam1 =KeyCode.KC_F1;        	
            _cam2 = KeyCode.KC_F2;
            _cam3 = KeyCode.KC_F3;
            _cam4 = KeyCode.KC_F4;
            _cam5 = KeyCode.KC_F5;
            _cam6 = KeyCode.KC_F6;
            _resetCamera = KeyCode.KC_V;
            _pausePlane = KeyCode.KC_P;

            _altFire = KeyCode.KC_X;
            _gunFire = KeyCode.KC_Z;
            _up = KeyCode.KC_UP;
            _down = KeyCode.KC_DOWN;
            _left = KeyCode.KC_LEFT;
            _right = KeyCode.KC_RIGHT;        	
            _bulletTimeEffect = KeyCode.KC_SPACE;
            _enter = KeyCode.KC_RETURN;
            _back = KeyCode.KC_ESCAPE;
            _gear = KeyCode.KC_G;
            _camera = KeyCode.KC_C;
            _zoomIn = KeyCode.KC_PGUP;
            _zoomOut = KeyCode.KC_PGDOWN;
            _engine = KeyCode.KC_E;
    		
            try
            {
            	_spin =KeyCode.KC_RCONTROL;
            }
            catch
            {
                _spin = KeyCode.KC_S;
            }
            
            bool found = false;
            for(int k = 0 ; k < joysticks.Count; k++ ) {
            	if((joysticks[k].Vendor()+"_"+joysticks[k].ID).Equals(_currentJoystick)){
            		found = true;
            		break;
            	}
            }
            if(!found) {
            	 _currentJoystick = null;            
	            if(joysticks.Count >0) {            	
	            	_currentJoystick = joysticks[0].Vendor()+"_"+joysticks[0].ID;
	            }
            }
          
            
            _joystickBulletTimeEffect = 8;
            _joystickCamera = 6;
            _joystickEngine = 2;
            _joystickEnter = 4;
            _joystickEscape =5;
            _joystickGear = 3;
            _joystickGun = 4;
            _joystickRocket = 1;
            _joystickSpin = 7;

            _joystickVerticalAxisNo = 0;
            _joystickHorizontalAxisNo = 1;
            _joystickDeadZone = 0.16;
            _joystickSensivity = 1.00;
            
                
       	
		}
        
        public override KeyMap Value
        {
            get 
            {
                KeyMap k = new KeyMap();
                k._cam1 = GetKeyCode("_cam1", "KC_F1");
                k._cam2 = GetKeyCode("_cam2", "KC_F2");
                k._cam3 = GetKeyCode("_cam3", "KC_F3");
                k._cam4 = GetKeyCode("_cam4", "KC_F4");
                k._cam5 = GetKeyCode("_cam5", "KC_F5");
                k._cam6 = GetKeyCode("_cam6", "KC_F6");
                k._resetCamera = GetKeyCode("_resetCamera", "KC_V");
                k._pausePlane = GetKeyCode("_pausePlane", "KC_P");
 
                k._altFire = GetKeyCode("_altFire", "KC_X");
                k._gunFire = GetKeyCode("_gunFire", "KC_Z");
                k._up = GetKeyCode("_up", "KC_UP");
                k._down = GetKeyCode("_down", "KC_DOWN");
                k._left = GetKeyCode("_left", "KC_LEFT");
                k._right = GetKeyCode("_right", "KC_RIGHT");        	
                k._bulletTimeEffect = GetKeyCode("_bulletTimeEffect", "KC_SPACE");
                k._enter = GetKeyCode("_enter", "KC_RETURN");
                k._back = GetKeyCode("_back", "KC_ESCAPE");
                k._gear = GetKeyCode("_gear", "KC_G");
                k._camera = GetKeyCode("_camera", "KC_C");
                k._zoomIn = GetKeyCode("_zoomIn", "KC_PGUP");
                k._zoomOut = GetKeyCode("_zoomOut", "KC_PGDOWN");
                k._engine = GetKeyCode("_engine", "KC_E");
        		
                try
                {
                    k._spin = GetModifier("_spin", "Ctrl");
                }
                catch
                {
                    k._spin = GetKeyCode("_spin", "KC_S");
                }
                
                k._currentJoystick = GetString("_currentJoystick",null);	                
                k._joystickBulletTimeEffect = GetInteger("_joystickBulletTimeEffect", 8);
                k._joystickCamera = GetInteger("_joystickCamera",6);
                k._joystickEngine = GetInteger("_joystickEngine",2);
                k._joystickEnter = GetInteger("_joystickEnter",4);
                k._joystickEscape = GetInteger("_joystickEscape",5);
                k._joystickGear = GetInteger("_joystickGear",3);
                k._joystickGun = GetInteger("_joystickGun",4);
                k._joystickRocket = GetInteger("_joystickRocket",1);
                k._joystickSpin = GetInteger("_joystickSpin",7);
                

                k._joystickVerticalAxisNo = GetInteger("_joystickVerticalAxisNo", 0);
                k._joystickHorizontalAxisNo = GetInteger("_joystickHorizontalAxisNo", 1);
                k._joystickDeadZone = double.Parse(GetString("_joystickDeadZone", "0.16"), new System.Globalization.CultureInfo("en-US"));
                k._joystickSensivity = double.Parse(GetString("_joystickSensivity", "1.00"), new System.Globalization.CultureInfo("en-US"));

                return k;
            }
            set 
            {
                WriteString("_cam1", _cam1.ToString());
                WriteString("_cam2", _cam2.ToString());
                WriteString("_cam3", _cam3.ToString());
                WriteString("_cam4", _cam4.ToString());
                WriteString("_cam5", _cam5.ToString());
                WriteString("_cam6", _cam6.ToString());
                WriteString("_resetCamera", _resetCamera.ToString());
                WriteString("_pausePlane", _pausePlane.ToString());
                
                WriteString("_altFire", _altFire.ToString());
                WriteString("_gunFire", _gunFire.ToString());
                WriteString("_up", _up.ToString());
                WriteString("_down", _down.ToString());
                WriteString("_left", _left.ToString());
                WriteString("_right", _right.ToString());
        	
                WriteString("_bulletTimeEffect", _bulletTimeEffect.ToString());
                WriteString("_enter", _enter.ToString());
                WriteString("_back", _back.ToString());        		
                WriteString("_gear", _gear.ToString());
                WriteString("_camera", _camera.ToString());
                WriteString("_zoomIn", _zoomIn.ToString());
                WriteString("_zoomOut", _zoomOut.ToString());
                
                WriteString("_engine", _engine.ToString());
                WriteString("_spin", _spin.ToString());

				WriteString("_currentJoystick", _currentJoystick);
                WriteString("_joystickBulletTimeEffect", _joystickBulletTimeEffect.ToString());
                WriteString("_joystickCamera", _joystickCamera.ToString());
                WriteString("_joystickEngine", _joystickEngine.ToString());
                WriteString("_joystickEnter", _joystickEnter.ToString());
                WriteString("_joystickEscape", _joystickEscape.ToString());
                WriteString("_joystickGear", _joystickGear.ToString());
                WriteString("_joystickGun", _joystickGun.ToString());
                WriteString("_joystickRocket", _joystickRocket.ToString());
                WriteString("_joystickSpin", _joystickSpin.ToString());
                

                WriteString("_joystickVerticalAxisNo", _joystickVerticalAxisNo.ToString());
                WriteString("_joystickHorizontalAxisNo", _joystickHorizontalAxisNo.ToString());

                WriteString("_joystickDeadZone", _joystickDeadZone.ToString(new System.Globalization.CultureInfo("en-US")));
                WriteString("_joystickSensivity", _joystickSensivity.ToString(new System.Globalization.CultureInfo("en-US")));
           


            }
        	
        }

        #region Key Code


        private KeyCode _cam1 = KeyCode.KC_F1;

        /// <summary>
        /// Pobiera lub ustawia kod klawisza, ktory odpowiada za zmianę kamery
        /// </summary>
        [ControlType(TypeOfControl.Keyboard)]
        public KeyCode Cam1
        {
            get { return _cam1; }
            set { _cam1 = value; }
        }


        private KeyCode _cam2 = KeyCode.KC_F2;

        /// <summary>
        /// Pobiera lub ustawia kod klawisza, ktory odpowiada za zmianę kamery
        /// </summary>
        [ControlType(TypeOfControl.Keyboard)]
        public KeyCode Cam2
        {
            get { return _cam2; }
            set { _cam2 = value; }
        }

        private KeyCode _cam3 = KeyCode.KC_F3;

        /// <summary>
        /// Pobiera lub ustawia kod klawisza, ktory odpowiada za zmianę kamery
        /// </summary>
        [ControlType(TypeOfControl.Keyboard)]
        public KeyCode Cam3
        {
            get { return _cam3; }
            set { _cam3 = value; }
        }


        private KeyCode _cam4 = KeyCode.KC_F4;

        /// <summary>
        /// Pobiera lub ustawia kod klawisza, ktory odpowiada za zmianę kamery
        /// </summary>
        [ControlType(TypeOfControl.Keyboard)] 
        public KeyCode Cam4
        {
            get { return _cam4; }
            set { _cam4 = value; }
        }


        private KeyCode _cam5 = KeyCode.KC_F5;
        
        /// <summary>
        /// Pobiera lub ustawia kod klawisza, ktory odpowiada za zmianę kamery
        /// </summary>
        [ControlType(TypeOfControl.Keyboard)] 
        public KeyCode Cam5
        {
            get { return _cam5; }
            set { _cam5 = value; }
        }

        private KeyCode _cam6 = KeyCode.KC_F6;

        /// <summary>
        /// Pobiera lub ustawia kod klawisza, ktory odpowiada za zmianę kamery
        /// </summary>
        [ControlType(TypeOfControl.Keyboard)]
        public KeyCode Cam6
        {
            get { return _cam6; }
            set { _cam6 = value; }
        }


        private KeyCode _resetCamera = KeyCode.KC_V;
        
        /// <summary>
        /// Pobiera lub ustawia kod klawisza, ktory odpowiada za reset kamery
        /// </summary>
        [ControlType(TypeOfControl.Keyboard)]
        public KeyCode ResetCamera
        {
            get { return _resetCamera; }
            set { _resetCamera = value; }
        }


        private KeyCode _pausePlane = KeyCode.KC_P;
        
        /// <summary>
        /// Pobiera lub ustawia kod klawisza, ktory odpowiada za reset kamery
        /// </summary>
        [ControlType(TypeOfControl.Keyboard)]
        public KeyCode PausePlane
        {
            get { return _pausePlane; }
            set { _pausePlane = value; }
        }        


        private KeyCode _gunFire = KeyCode.KC_Z;

        /// <summary>
        /// Pobiera lub ustawia kod klawisza, ktory odpowiada za strzelanie z dzialka samolotu.
        /// </summary>
        [ControlType(TypeOfControl.Keyboard)] 
        public KeyCode Gun
        {
            get { return _gunFire; }
            set { _gunFire = value; }
        }
        
        
        private KeyCode _up;

        /// <summary>
        /// Pobiera lub ustawia kod klawisza, ktory odpowiada za strzelania z dzialka samolotu.
        /// </summary>
        [ControlType(TypeOfControl.Keyboard)]
        public KeyCode Up
        {
            get { return _up; }
            set { _up = value; }
        }
        
        
        private KeyCode _down;

        /// <summary>
        /// Pobiera lub ustawia kod klawisza, ktory odpowiada za nacisniecie strzalki do dołu
        /// </summary>
        [ControlType(TypeOfControl.Keyboard)]
        public KeyCode Down
        {
            get { return _down; }
            set { _down = value; }
        }
        
        
        private KeyCode _left;

        /// <summary>
        /// Pobiera lub ustawia kod klawisza, ktory odpowiada za nacisniecie strzalki do lewo
        /// </summary>
        [ControlType(TypeOfControl.Keyboard)]
        public KeyCode Left
        {
            get { return _left; }
            set { _left = value; }
        }
        
        
        private KeyCode _right;

        /// <summary>
        /// Pobiera lub ustawia kod klawisza, ktory odpowiada za nacisniecie strzalki do lewo
        /// </summary>
        [ControlType(TypeOfControl.Keyboard)]
        public KeyCode Right
        {
            get { return _right; }
            set { _right = value; }
        }
        

        //---------------------------------------------------

        private KeyCode _altFire;

        /// <summary>
        /// Pobiera lub ustawia kod klawisza, ktory odpowiada za strzelanie rakietami, zrzucaniem bomb i torped, itp.
        /// </summary>
        [ControlType(TypeOfControl.Keyboard)]
        public KeyCode Bombs
        {
            get { return _altFire; }
            set { _altFire = value; }
        }

        //---------------------------------------------------

        
        private KeyCode _bulletTimeEffect;

        /// <summary>
        /// Pobiera lub ustawia kod klawisza, ktory odpowiada za wlaczenie efektu BulletTime.
        /// </summary>
        [ControlType(TypeOfControl.Keyboard)]
        public KeyCode BulletTimeEffect
        {
            get { return _bulletTimeEffect; }
            set { _bulletTimeEffect = value; }
        }
        
        
        private KeyCode _enter;

        /// <summary>
        /// Pobiera lub ustawia kod klawisza, ktory odpowiada za enter.
        /// </summary>
        [ControlType(TypeOfControl.Keyboard)]
        public KeyCode Enter
        {
            get { return _enter; }
            set { _enter = value; }
        }
        
        
        
        private KeyCode _back;

        /// <summary>
        /// Pobiera lub ustawia kod klawisza, ktory odpowiada za esc.
        /// </summary>
        [ControlType(TypeOfControl.Keyboard)]
        public KeyCode Escape
        {
            get { return _back; }
            set { _back = value; }
        }
        
       
        private KeyCode _gear;
       
        /// <summary>
        /// Pobiera lub ustawia kod klawisza, ktory odpowiada za nacisniecie gear
        /// </summary>
        [ControlType(TypeOfControl.Keyboard)]
        public KeyCode Gear
        {
            get { return _gear; }
            set { _gear = value; }
        }
        
        
        
        private KeyCode _camera;

        /// <summary>
        /// Pobiera lub ustawia kod klawisza, ktory odpowiada za zmiane kamery.
        /// </summary>
        [ControlType(TypeOfControl.Keyboard)]
        public KeyCode Camera
        {
            get { return _camera; }
            set { _camera = value; }
        }
        
         
       
        private KeyCode _zoomIn;

        /// <summary>
        /// Pobiera lub ustawia kod klawisza, ktory odpowiada za zoom in.
        /// </summary>
        [ControlType(TypeOfControl.Keyboard)]
        public KeyCode ZoomIn
        {
            get { return _zoomIn; }
            set { _zoomIn = value; }
        }
        
       
        private KeyCode _zoomOut;

        /// <summary>
        /// Pobiera lub ustawia kod klawisza, ktory odpowiada za zoom out.
        /// </summary>
        [ControlType(TypeOfControl.Keyboard)]
        public KeyCode ZoomOut
        {
            get { return _zoomOut; }
            set { _zoomOut = value; }
        }
        
        
      
        private KeyCode _engine;
       
        /// <summary>
        /// Pobiera lub ustawia kod klawisza, ktory odpowiada za nacisniecie strzalki do lewo
        /// </summary>
        [ControlType(TypeOfControl.Keyboard)]
        public KeyCode Engine
        {
            get { return _engine; }
            set { _engine = value; }
        }
        
        
        private object _spin ;
       
        /// <summary>
        /// Pobiera lub ustawia kod klawisza, ktory odpowiada za nacisniecie spina
        /// </summary>
        [ControlType(TypeOfControl.Keyboard)]
        public object Spin
        {
            get { return _spin; }
            set { _spin = value; }
        }



        #region Joystick

       
        private int _joystickBulletTimeEffect;
        
        [ControlType(TypeOfControl.Joystick)]
        public int JoystickBulletiTimeEffect
        {
            get { return _joystickBulletTimeEffect; }
            set { _joystickBulletTimeEffect = value; }
        }

       
        private int _joystickGun;
        
        [ControlType(TypeOfControl.Joystick)]
        public int JoystickGun
        {
            get { return _joystickGun; }
            set { _joystickGun = value; }
        }

       
        private int _joystickEnter;
        
        [ControlType(TypeOfControl.Joystick)]
        public int JoystickEnter
        {
            get { return _joystickEnter; }
            set { _joystickEnter = value; }
        }

       
        private int _joystickGear;
        
        [ControlType(TypeOfControl.Joystick)]
        public int JoystickGear
        {
            get { return _joystickGear; }
            set { _joystickGear = value; }
        }

        
        private int _joystickRocket;
        
        [ControlType(TypeOfControl.Joystick)]
        public int JoystickRocket
        {
            get { return _joystickRocket; }
            set { _joystickRocket = value; }
        }
        
        private int _joystickSpin;
        
        [ControlType(TypeOfControl.Joystick)]
        public int JoystickSpin
        {
            get { return _joystickSpin; }
            set { _joystickSpin = value; }
        }
        
        

        
        private int _joystickCamera;
        
        [ControlType(TypeOfControl.Joystick)]
        public int JoystickCamera
        {
            get { return _joystickCamera; }
            set { _joystickCamera = value; }
        }
          
        private int _joystickEngine;
        
        [ControlType(TypeOfControl.Joystick)]
        public int JoystickEngine
        {
            get { return _joystickEngine; }
            set { _joystickEngine = value; }
        }

        
        private int _joystickEscape;
        
        [ControlType(TypeOfControl.Joystick)]
        public int JoystickEscape
        {
            get { return _joystickEscape; }
            set { _joystickEscape = value; }
        }
        
        
        private string _currentJoystick;
        public string CurrentJoystick
        {
            get { return _currentJoystick; }
            set { _currentJoystick = value; }
        }

        private double _joystickDeadZone;
        public double JoystickDeadZone
        {
        	get { return _joystickDeadZone>0.95 ? 0.95 : _joystickDeadZone; }
            set { _joystickDeadZone = value; }
        }
        
        private double _joystickSensivity;
        public double JoystickSensivity
        {
        	get { 
        		if(_joystickSensivity <= 0.01) {
        			return 0.01;
        		}
        		return _joystickSensivity>3.0 ? 3.0 : _joystickSensivity;
        	}
            set { _joystickSensivity = value; }
        }
        
   		private int _joystickVerticalAxisNo;
        public int JoystickVerticalAxisNo
        {
            get { return _joystickVerticalAxisNo; }
            set { _joystickVerticalAxisNo = value; }
        }

        private int _joystickHorizontalAxisNo;
        public int JoystickHorizontalAxisNo
        {
            get { return _joystickHorizontalAxisNo; }
            set { _joystickHorizontalAxisNo = value; }
        }



    

        #endregion



        #endregion

        #region Public Static Methods

        /// <summary>
        /// Metoda sprawdza czy dany KeyCode jest zajety przez jakas funkcjonalnosc.
        /// </summary>
        /// <param name="presentKeyCode">Aktualny KeyCode dla danej funkcjonalnosci.</param>
        /// <param name="newKeyCode">Nowy KeyCode dla danej funkcjonalnosci.</param>
        /// <returns>Jesli oba parametry sa rowne, to nie ma konfliktu - zwroci false.
        /// Jesli KeyCode podany w drugim parametrze jest zajety przez jakas funkjonalnosc, to metoda zwroci true.
        /// W przeciwnym przypadku false.</returns>
        /*
        public static bool CheckKeyCodeConflict(KeyCode presentKeyCode, KeyCode newKeyCode)
        {
            if (presentKeyCode != newKeyCode)
            {
                KeyCode tmpKeyCode;
                PropertyInfo[] properties = KeyMap.Instance.GetType().GetProperties();
                for (int i = 0; i < properties.Length; i++)
                {
                	object obj = properties[i].GetValue(Instance, null);
                	if(obj is KeyCode){
                		tmpKeyCode = (KeyCode)obj;
                		if (tmpKeyCode == newKeyCode){
	                        return true;
                		}
                	}
                  
                }
            }
            return false;
        }
        
       
      
      
         */
        
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="newValue"></param>
        /// <param name="type"></param>
        /// <param name="conflictExceptions"></param>
        /// <returns></returns>
        public static bool UpdateProperty(String propertyName, object newValue,  TypeOfControl type, String[] conflictExceptions) {
        	
        	if(CheckKeyCodeConflict(propertyName, newValue, type, conflictExceptions)) {
        	   	return false;
        	}
        	
        	PropertyInfo[] properties = KeyMap.Instance.GetType().GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
            	if(properties[i].Name.Equals(propertyName, StringComparison.InvariantCultureIgnoreCase)) {
            		properties[i].SetValue(KeyMap.Instance, newValue, null);
            		KeyMap.Instance.Value = KeyMap.Instance.Value;
            		return true;
            	}
            }
        	
        	return false; // no such property
        }
        
        public static bool UpdateProperty(String propertyName, object newValue,  TypeOfControl type) {
        	return UpdateProperty(propertyName, newValue, type, new string[0]{});
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="propertyName"></param>
        /// <param name="newKeyCode"></param>
        /// <param name="type"></param>
        /// <returns></returns>
        public static bool CheckKeyCodeConflict(String propertyName, object newKeyCode, TypeOfControl type)
        {
        	
        	return  CheckKeyCodeConflict(propertyName, newKeyCode, type, new String[0] {});
       
        }
        
        public static bool ClearOtherControlsWithSameKey(String propertyName, object keyCode, TypeOfControl type, String[] exceptions)
        {
         	
        	KeyCode tmpKeyCode;
            PropertyInfo[] properties = KeyMap.Instance.GetType().GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
            	
            	if(-1 != Array.FindIndex(exceptions, (String exception) => properties[i].Name.Equals(exception, StringComparison.InvariantCultureIgnoreCase))){
            		// 
            		continue;
            	}
       				
            	var attribute = Attribute.GetCustomAttribute(properties[i], typeof(ControlTypeAttribute)) as ControlTypeAttribute;
            
            	
            	if(attribute != null && !properties[i].Name.Equals(propertyName, StringComparison.InvariantCultureIgnoreCase)) {
            		    
            		if(!attribute.Type.Equals(type)) {
            			continue;
            		}
            		
					// other key            		
	            	object obj = properties[i].GetValue(Instance, null);
	            	if(obj is KeyCode && keyCode is KeyCode){
	            		tmpKeyCode = (KeyCode)obj;
	            		if (tmpKeyCode == (KeyCode)keyCode){
	                       properties[i].SetValue(KeyMap.Instance, null, null);
	            		}
	            	}
	            	if(obj is int && keyCode is int){
	            		if (obj.Equals(keyCode)){
	                         properties[i].SetValue(KeyMap.Instance, -1, null);
	            		}
	            	}
            	}
              
            }
           
            return false;
        }
             
        public static bool CheckKeyCodeConflict(String propertyName, object newKeyCode, TypeOfControl type, String[] exceptions)
        {
        	
            KeyCode tmpKeyCode;
            PropertyInfo[] properties = KeyMap.Instance.GetType().GetProperties();
            for (int i = 0; i < properties.Length; i++)
            {
            	
            	if(-1 != Array.FindIndex(exceptions, (String exception) => properties[i].Name.Equals(exception, StringComparison.InvariantCultureIgnoreCase))){
            		// 
            		continue;
            	}
       				
            	var attribute = Attribute.GetCustomAttribute(properties[i], typeof(ControlTypeAttribute)) as ControlTypeAttribute;
            
            	
            	if(attribute != null && !properties[i].Name.Equals(propertyName, StringComparison.InvariantCultureIgnoreCase)) {
            		    
            		if(!attribute.Type.Equals(type)) {
            			continue;
            		}
					// other key            		
	            	object obj = properties[i].GetValue(Instance, null);
	            	if(obj is KeyCode && newKeyCode is KeyCode){
	            		tmpKeyCode = (KeyCode)obj;
	            		if (tmpKeyCode == (KeyCode)newKeyCode){
	                        return true;
	            		}
	            	}
	            	if(obj is int && newKeyCode is int){
	            		if (obj.Equals(newKeyCode)){
	                        return true;
	            		}
	            	}
            	}
              
            }
           
            return false;
        }
        
        
        private static string GetRussianName(KeyCode keyCode)
        {
        	if(russianKeyMapping.ContainsKey(keyCode))
        	{
        		return russianKeyMapping[keyCode];
        	}else
        	{
        		return keyCode.ToString().Substring(3);
        	}
        }
        
        private static string GetUkrainianName(KeyCode keyCode)
        {
        	if(ukrainianKeyMapping.ContainsKey(keyCode))
        	{
        		return ukrainianKeyMapping[keyCode];
        	}else
        	{
        		return keyCode.ToString().Substring(3);
        	}
        }
         
        public static string GetName(object keyCodeOrModifier)
        {
            if(keyCodeOrModifier is KeyCode)
            {
            	if(Languages.LanguageManager.ActualLanguageCode.Equals("ru-RU"))
            	{
            		return GetRussianName((KeyCode)keyCodeOrModifier);
            	}
            	
            	if(Languages.LanguageManager.ActualLanguageCode.Equals("ua-UA"))
            	{
            		return GetUkrainianName((KeyCode)keyCodeOrModifier);
            	}
            	
            	
            	
                return ((KeyCode)keyCodeOrModifier).ToString().Substring(3);
            }else
                if(keyCodeOrModifier is MOIS.Keyboard.Modifier)
                {
                    return ((MOIS.Keyboard.Modifier)keyCodeOrModifier).ToString();
                } else
                {
                    return "";
                }
        			
        	
        }

        #endregion
    }
}