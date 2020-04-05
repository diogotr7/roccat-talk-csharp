using Roccat_Talk.TalkFX;
using System;
using System.Runtime.InteropServices;

namespace Roccat_Talk
{
    internal static class TalkFxBindings
    {
        private const string x86DllPath = "talkfx-c.dll";
        private const string x64DllPath = "talkfx-c-x64.dll";

        [DllImport(x86DllPath, EntryPoint = "newRoccatTalkHandle", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr newRoccatTalkHandle_x86();

        [DllImport(x64DllPath, EntryPoint = "newRoccatTalkHandle", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr newRoccatTalkHandle_x64();


        [DllImport(x86DllPath, EntryPoint = "destroyRoccatTalkHandle", CallingConvention = CallingConvention.Cdecl)]
        public static extern void destroyRoccatTalkHandle_x86(IntPtr handle);

        [DllImport(x64DllPath, EntryPoint = "destroyRoccatTalkHandle", CallingConvention = CallingConvention.Cdecl)]
        public static extern void destroyRoccatTalkHandle_x64(IntPtr handle);


        internal static class TalkFX
        {
            [DllImport(x86DllPath, EntryPoint = "Set_LED_RGB", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Set_LED_RGB_x86(IntPtr handle, byte bZone, byte bEffect, byte bSpeed, byte colorR, byte colorG, byte colorB);

            [DllImport(x64DllPath, EntryPoint = "Set_LED_RGB", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Set_LED_RGB_x64(IntPtr handle, byte bZone, byte bEffect, byte bSpeed, byte colorR, byte colorG, byte colorB);


            /* TALK FX method -- restore user LED colour at end of program */
            [DllImport(x86DllPath, EntryPoint = "RestoreLEDRGB", CallingConvention = CallingConvention.Cdecl)]
            public static extern void RestoreLEDRGB_x86(IntPtr handle);

            [DllImport(x64DllPath, EntryPoint = "RestoreLEDRGB", CallingConvention = CallingConvention.Cdecl)]
            public static extern void RestoreLEDRGB_x64(IntPtr handle);
        }

        internal static class RyosMKPRO
        {
            //Ryos MK PRO METHODS
            /* initiate connection to Ryos MK PRO keyboard and check if present */
            [DllImport(x86DllPath, EntryPoint = "init_ryos_talk", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool init_ryos_talk_x86(IntPtr handle);

            [DllImport(x64DllPath, EntryPoint = "init_ryos_talk", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool init_ryos_talk_x64(IntPtr handle);


            /* take control of a connected Ryos MK PRO keyboard */
            [DllImport(x86DllPath, EntryPoint = "set_ryos_kb_SDKmode", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool set_ryos_kb_SDKmode_x86(IntPtr handle, bool state);

            [DllImport(x64DllPath, EntryPoint = "set_ryos_kb_SDKmode", CallingConvention = CallingConvention.Cdecl)]
            public static extern bool set_ryos_kb_SDKmode_x64(IntPtr handle, bool state);


            /* basic Ryos MK PRO LED control methods */
            [DllImport(x86DllPath, EntryPoint = "turn_off_all_LEDS", CallingConvention = CallingConvention.Cdecl)]
            public static extern void turn_off_all_LEDS_x86(IntPtr handle);

            [DllImport(x64DllPath, EntryPoint = "turn_off_all_LEDS", CallingConvention = CallingConvention.Cdecl)]
            public static extern void turn_off_all_LEDS_x64(IntPtr handle);


            [DllImport(x86DllPath, EntryPoint = "turn_on_all_LEDS", CallingConvention = CallingConvention.Cdecl)]
            public static extern void turn_on_all_LEDS_x86(IntPtr handle);

            [DllImport(x64DllPath, EntryPoint = "turn_on_all_LEDS", CallingConvention = CallingConvention.Cdecl)]
            public static extern void turn_on_all_LEDS_x64(IntPtr handle);


            /* turn on/off a single LED at specified position */
            [DllImport(x86DllPath, EntryPoint = "set_LED_on", CallingConvention = CallingConvention.Cdecl)]
            public static extern void set_LED_on_x86(IntPtr handle, byte ucPos);

            [DllImport(x64DllPath, EntryPoint = "set_LED_on", CallingConvention = CallingConvention.Cdecl)]
            public static extern void set_LED_on_x64(IntPtr handle, byte ucPos);


            [DllImport(x86DllPath, EntryPoint = "set_LED_off", CallingConvention = CallingConvention.Cdecl)]
            public static extern void set_LED_off_x86(IntPtr handle, byte ucPos);

            [DllImport(x64DllPath, EntryPoint = "set_LED_off", CallingConvention = CallingConvention.Cdecl)]
            public static extern void set_LED_off_x64(IntPtr handle, byte ucPos);


            /* send a whole array as a frame to the keyboard (manipulate mulitple LEDS)*/
            [DllImport(x86DllPath, EntryPoint = "Set_all_LEDS", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Set_all_LEDS_x86(IntPtr handle, byte[] ucLED);

            [DllImport(x64DllPath, EntryPoint = "Set_all_LEDS", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Set_all_LEDS_x64(IntPtr handle, byte[] ucLED);


            /* simple blinking effect on Ryos MK PRO */
            [DllImport(x86DllPath, EntryPoint = "All_Key_Blinking", CallingConvention = CallingConvention.Cdecl)]
            public static extern void All_Key_Blinking_x86(IntPtr handle, int DelayTime, int LoopTimes);

            [DllImport(x64DllPath, EntryPoint = "All_Key_Blinking", CallingConvention = CallingConvention.Cdecl)]
            public static extern void All_Key_Blinking_x64(IntPtr handle, int DelayTime, int LoopTimes);
        }

        internal static class RyosMKFX
        {
            /* setting RGB on Ryos MK FX */
            [DllImport(x86DllPath, EntryPoint = "Set_all_LEDSFX", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Set_all_LEDSFX_x86(IntPtr handle, byte[] ucLEDOnOff, byte[] ucLEDRGB, byte layout);

            [DllImport(x64DllPath, EntryPoint = "Set_all_LEDSFX", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Set_all_LEDSFX_x64(IntPtr handle, byte[] ucLEDOnOff, byte[] ucLEDRGB, byte layout);

            [DllImport(x86DllPath, EntryPoint = "Set_all_LEDSFX_struct", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Set_all_LEDSFX_struct_x86(IntPtr handle, byte[] ucLEDOnOff, Color[] strctLEDRGB, byte layout);

            [DllImport(x64DllPath, EntryPoint = "Set_all_LEDSFX_struct", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Set_all_LEDSFX_struct_x64(IntPtr handle, byte[] ucLEDOnOff, Color[] strctLEDRGB, byte layout);

            [DllImport(x86DllPath, EntryPoint = "Set_all_LEDSFX_individual", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Set_all_LEDSFX_individual_x86(IntPtr handle, byte[] ucLEDOnOff, byte[] ucLEDRed, byte[] ucLEDGreen, byte[] ucLEDBlue, byte layout);

            [DllImport(x64DllPath, EntryPoint = "Set_all_LEDSFX_individual", CallingConvention = CallingConvention.Cdecl)]
            public static extern void Set_all_LEDSFX_individual_x64(IntPtr handle, byte[] ucLEDOnOff, byte[] ucLEDRed, byte[] ucLEDGreen, byte[] ucLEDBlue, byte layout);
        }
    }
}