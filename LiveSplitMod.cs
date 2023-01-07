using System;
using System.Net.Sockets;
using System.Net;
using MelonLoader;
using UnityEngine;
using UnityEngine.InputSystem;
using System.IO;
using Il2Cpp;
namespace LiveSplitMod 
{
    /*
     * LiveSplitMod - NameSpace used along side the LiveSplitClient to send commands to the server
     * 
     * Place what ever you need within here to start, split, reset etc. for the game you want to mod 
     */
    public class LiveSplitMod : MelonMod
    {
        private static LiveSplitClient? lsm;

        public override void OnInitializeMelon()
        {
            if (lsm == null)
            {
                lsm = new LiveSplitClient();
            }
        }
    }
}