using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BepInEx;
using GorillaLocomotion.Swimming;
using UnityEngine;
using Utilla;

namespace WaterGod
{
    [BepInDependency("org.legoandmars.gorillatag.utilla", "1.5.0")]
    [BepInPlugin("com.polar.WaterGod", "WaterGod" , "1.0.0" )]
    public class Plugin : BaseUnityPlugin
    {

        bool inAllowedRoom = false;
        bool doonce = false;

        private void Update()
        {
            if (inAllowedRoom)
            {
                if (!doonce)
                {
                    GameObject.FindObjectOfType<WaterVolume>().gameObject.AddComponent<MeshCollider>();
                    GameObject.FindObjectOfType<WaterVolume>().gameObject.AddComponent<MeshCollider>();
                    GameObject.FindObjectOfType<WaterVolume>().gameObject.AddComponent<MeshCollider>();
                    GameObject.FindObjectOfType<WaterVolume>().gameObject.AddComponent<MeshCollider>();
                    GameObject.FindObjectOfType<WaterVolume>().gameObject.AddComponent<MeshCollider>();
                    GameObject.FindObjectOfType<WaterVolume>().gameObject.AddComponent<MeshCollider>();
                    GameObject.FindObjectOfType<WaterVolume>().gameObject.AddComponent<MeshCollider>();
                    doonce = true;
                }
            }
        }

        [ModdedGamemodeJoin]
        private void RoomJoined(string gamemode)
        {
           
            inAllowedRoom = true;
        }

        [ModdedGamemodeLeave]
        private void RoomLeft(string gamemode)
        {
           
            inAllowedRoom = false;
        }
    }
}
