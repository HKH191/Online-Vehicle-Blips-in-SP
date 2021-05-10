
using System;
using System.Collections.Generic;

using GTA;
using System.Windows.Forms;
using GTA.Native;
using GTA.Math;
using System.Drawing;


namespace OnlineVehicleBlipsInSp
{
    public class Class1 : Script
    {
        ScriptSettings Config;
        public Vehicle[] Vehicles;
        public bool LoadBlips;
        public bool LoadExtraBlips;
        public bool EnableColor;
        public int Timer;
        public bool OnlyActiveInInteriors;
        public bool UseBusinessColors;
        public Class1()
        {

            Aborted += OnShutdown;
            Tick += OnTick;
            KeyDown += OnKeyDown;
            Interval = 1;
            LoadIniFile("scripts//OnlineBlipsMod.ini");
            Vehicles = World.GetNearbyVehicles(Game.Player.Character.Position, 4000f);
        }
        public void EnableBlips()
        {
            Vehicles = World.GetNearbyVehicles(Game.Player.Character.Position, 100f);
            foreach (Vehicle V in Vehicles)
            {
                
                    #region Blips On

                if (!V.CurrentBlip.Exists() && V.IsAlive==true)
                {
                    if (V.Model == VehicleHash.Avenger)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Avenger;


                    }
                    if (V.Model == VehicleHash.Deathbike)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Deathbike;


                    }
                    if (V.Model == VehicleHash.Deathbike2)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Deathbike;


                    }
                    if (V.Model == VehicleHash.Deathbike3)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Deathbike;


                    }
                    if (V.Model == VehicleHash.Avenger2)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Avenger;


                    }
                    if (V.Model == VehicleHash.Akula)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Akula;


                    }
                    if (V.Model == VehicleHash.AlphaZ1)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.AlphaZ1;
                    }
                    if (V.Model == VehicleHash.APC)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.APC;
                    }
                    if (V.Model == VehicleHash.Strikeforce)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.B11StrikeForce;
                    }
                    if (V.Model == VehicleHash.Barrage)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Barrage;
                    }
                    if (V.Model == VehicleHash.Bombushka)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Bombushka;
                    }
                    if (V.Model == VehicleHash.Brutus)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Brutus;
                    }
                    if (V.Model == VehicleHash.Brutus2)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Brutus;
                    }
                    if (V.Model == VehicleHash.Brutus3)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Brutus;
                    }
                    if (V.Model == VehicleHash.Caracara)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Caracara;
                    }
                    if (V.Model == VehicleHash.Cerberus)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Cerberus;
                    }
                    if (V.Model == VehicleHash.Cerberus2)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Cerberus;
                    }
                    if (V.Model == VehicleHash.Cerberus3)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Cerberus;
                    }
                    if (V.Model == VehicleHash.Chernobog)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Chernobog;
                    }
                    if (V.Model == VehicleHash.Deluxo)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Deluxo;
                    }
                    if (V.Model == VehicleHash.Dominator4)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Dominator;
                    }
                    if (V.Model == VehicleHash.Dominator5)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Dominator;
                    }
                    if (V.Model == VehicleHash.Dominator6)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Dominator;
                    }
                    if (V.Model == VehicleHash.Dune3)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.DuneFAV;
                    }
                    if (V.Model == VehicleHash.HalfTrack)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.HalfTrack;
                    }
                    if (V.Model == VehicleHash.Havok)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Havok;
                    }
                    if (V.Model == VehicleHash.Howard)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.HowardNX25;
                    }
                    if (V.Model == VehicleHash.Impaler)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Impaler;
                    }
                    if (V.Model == VehicleHash.Impaler2)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Impaler;
                    }
                    if (V.Model == VehicleHash.Impaler3)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Impaler;
                    }
                    if (V.Model == VehicleHash.Impaler3)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Impaler;
                    }
                    if (V.Model == VehicleHash.Imperator)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Imperator;
                    }
                    if (V.Model == VehicleHash.Imperator2)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Imperator;
                    }
                    if (V.Model == VehicleHash.Imperator3)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Imperator;
                    }
                    if (V.Model == VehicleHash.Issi4)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Issi;
                    }
                    if (V.Model == VehicleHash.Issi5)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Issi;
                    }
                    if (V.Model == VehicleHash.Issi6)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Issi;
                    }
                    if (V.Model == VehicleHash.Khanjari)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Khanjali;
                    }
                    if (V.Model == VehicleHash.Mogul)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Mogul;
                    }
                    if (V.Model == VehicleHash.Mule4)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.MuleCustom;
                    }
                    if (V.Model == VehicleHash.Nokota)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.P45Nokota;
                    }
                    if (V.Model == VehicleHash.Oppressor)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Oppressor;
                    }
                    if (V.Model == VehicleHash.Oppressor2)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.OppressorMkII;
                    }
                    if (V.Model == VehicleHash.Pyro)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Pyro;
                    }
                    if (V.Model == VehicleHash.Rogue)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Rogue;
                    }
                    if (V.Model == VehicleHash.Ruiner2)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Ruiner2000;
                    }
                    if (V.Model == VehicleHash.Scarab)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Scarab;
                    }
                    if (V.Model == VehicleHash.Scarab2)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Scarab;
                    }
                    if (V.Model == VehicleHash.Scarab3)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Scarab;
                    }
                    if (V.Model == VehicleHash.Scramjet)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Scramjet;
                    }
                    if (V.Model == VehicleHash.Seabreeze)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Seabreeze;
                    }
                    if (V.Model == VehicleHash.SeaSparrow)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.SeaSparrow;
                    }
                    if (V.Model == VehicleHash.SlamVan4)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Slamvam;
                    }
                    if (V.Model == VehicleHash.SlamVan5)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Slamvam;
                    }
                    if (V.Model == VehicleHash.SlamVan6)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Slamvam;
                    }
                    if (V.Model == VehicleHash.Starling)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Starling;
                    }
                    if (V.Model == VehicleHash.Stromberg)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Stromberg;
                    }
                    if (V.Model == VehicleHash.Technical)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.TechnicalAqua;
                    }
                    if (V.Model == VehicleHash.Technical2)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.TechnicalAqua;
                    }
                    if (V.Model == VehicleHash.Technical3)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.TechnicalAqua;
                    }
                    if (V.Model == VehicleHash.Thruster)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Thruster;
                    }
                    if (V.Model == VehicleHash.Tula)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Tula;
                    }
                    if (V.Model == VehicleHash.Limo2)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.TurretedLimo;
                    }
                    if (V.Model == VehicleHash.Microlight)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Ultralight;
                    }
                    if (V.Model == VehicleHash.Molotok)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.V65Molotok;
                    }
                    if (V.Model == VehicleHash.Volatol)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.Volatol;
                    }
                    if (V.Model == VehicleHash.Tampa3)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.WeaponizedTampa;
                    }
                    if (V.Model == VehicleHash.ZR380)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.ZR380;
                    }
                    if (V.Model == VehicleHash.ZR3802)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.ZR380;
                    }
                    if (V.Model == VehicleHash.ZR3803)
                    {
                        V.AddBlip();
                        V.CurrentBlip.Sprite = BlipSprite.ZR380;
                    }
                    if (V.CurrentBlip != null)
                    {
                        if (EnableColor == true)
                        {
                            List<dynamic> listofvehicles = new List<dynamic>();
                            BlipColor[] allvehiclehashes = (BlipColor[])Enum.GetValues(typeof(BlipColor));
                            for (int i = 0; i < allvehiclehashes.Length; i++)
                            {
                                listofvehicles.Add(allvehiclehashes[i]);

                            }
                            var Random = new Random();
                            var BlipColor = Random.Next(0, listofvehicles.Count);
                            V.CurrentBlip.Color = listofvehicles[BlipColor];
                        }
                    }
                    if (V.IsAlive == false)
                    {
                        V.CurrentBlip.Remove();
                        V.IsPersistent = false;
                    }
                }
            }
            #endregion
                   

        }
        public void OnKeyDown(object sender, KeyEventArgs e)
        {

        }
        private void OnShutdown(object sender, EventArgs e)
        {
            var A_0 = true;
            if (A_0)
            {

                foreach (Vehicle V in Vehicles)
                {
                    if (V.CurrentBlip != null)
                    {
                        V.CurrentBlip.Remove();
                    }
                }

            }
        }
        void LoadIniFile(string iniName)
        {
            try
            {
                Config = ScriptSettings.Load(iniName);



                LoadBlips = Config.GetValue<bool>("Setup", "LoadBlips", LoadBlips);
                LoadExtraBlips = Config.GetValue<bool>("Setup", "LoadExtraBlips", LoadExtraBlips);
                EnableColor = Config.GetValue<bool>("Setup", "EnableColor", EnableColor);
                OnlyActiveInInteriors = Config.GetValue<bool>("Setup", "OnlyActiveInInteriors", OnlyActiveInInteriors);
                UseBusinessColors = Config.GetValue<bool>("Setup", "UseBusinessColors", UseBusinessColors);
            }
            catch (Exception e)
            {
                UI.Notify("~r~Error~w~: " + iniName + ".ini Failed To Load.");
            }
        }
        private void OnTick(object sender, EventArgs e)
        {
            if (Timer == 48)
            {
                Vehicles = World.GetNearbyVehicles(Game.Player.Character.Position, 300f);
                foreach (Vehicle V in Vehicles)
                {
                    if(V!=null)
                    {
                        if(V.CurrentBlip!=null)
                        {
                            if (V.IsAlive == false)
                            {
                                V.CurrentBlip.Remove();
                                V.IsPersistent = false;
                            }
                        }
                    }
              
                }
                Timer = 0;
                if (LoadBlips == true)
                {
                    
                    EnableBlips();
                }
                else 
                if(OnlyActiveInInteriors==true)
                {
                    if (World.GetDistance(Game.Player.Character.Position, new Vector3(-1272.119f, -3012.927f, -46.66276f))<400f)
                    {
                        EnableBlips();
                        //new Vector3(-1272.119f, -3012.927f, -46.66276f);
                        //Hanger
                        if(UseBusinessColors==true)
                        {
                            foreach (Vehicle V in Vehicles)
                            {
                                if (V != null)
                                {
                                    if (V.CurrentBlip != null)
                                    {

                                        V.CurrentBlip.Color = BlipColor.Red;
                                         
                                        
                                    }
                                }

                            }
                        }
                      
                    }
                    if (World.GetDistance(Game.Player.Character.Position, new Vector3(439.7794f, 5162.643f, -88.70331f)) < 600f)
                    {
                        EnableBlips();
                        // new Vector3(439.7794f, 5162.643f, -88.70331f);
                        //Arena War Interior
                        if (UseBusinessColors == true)
                        {
                            foreach (Vehicle V in Vehicles)
                            {
                                if (V != null)
                                {
                                    if (V.CurrentBlip != null)
                                    {

                                        V.CurrentBlip.Color = BlipColor.Pink;


                                    }
                                }

                            }
                        }
                    }
                    if (World.GetDistance(Game.Player.Character.Position, new Vector3(394.6558f, 4825.691f, -57.60463f)) < 600f)
                    {
                        EnableBlips();
                        //  new Vector3(394.6558f, 4825.691f, -57.60463f);
                        //Facility
                        if (UseBusinessColors == true)
                        {
                            foreach (Vehicle V in Vehicles)
                            {
                                if (V != null)
                                {
                                    if (V.CurrentBlip != null)
                                    {

                                        V.CurrentBlip.Color = BlipColor.Purple;


                                    }
                                }

                            }
                        }
                    }
                    if (World.GetDistance(Game.Player.Character.Position, new Vector3(898.3629f, -3210.564f, -98.72517f)) < 600f)
                    {
                        EnableBlips();
                        //  new Vector3(898.3629f, -3210.564f, -98.72517f);
                        //Bunker
                        if (UseBusinessColors == true)
                        {
                            foreach (Vehicle V in Vehicles)
                            {
                                if (V != null)
                                {
                                    if (V.CurrentBlip != null)
                                    {

                                        V.CurrentBlip.Color = BlipColor.Orange;


                                    }
                                }

                            }
                        }
                    }
                    if (World.GetDistance(Game.Player.Character.Position, new Vector3(2815f, -3909f, 140)) < 600f)
                    {
                        EnableBlips(    );
                        //  new Vector3(2815f, -3909f, 140);
                        //Arena
                        if (UseBusinessColors == true)
                        {
                            foreach (Vehicle V in Vehicles)
                            {
                                if (V != null)
                                {
                                    if (V.CurrentBlip != null)
                                    {

                                        V.CurrentBlip.Color = BlipColor.Pink;


                                    }
                                }

                            }
                        }
                    }
                    if (World.GetDistance(Game.Player.Character.Position, new Vector3(-88f, -831.570f, 221f)) <100f ||
                        World.GetDistance(Game.Player.Character.Position, new Vector3(-1389, -473, 79f)) <100f)//Maze Bank
                    {
                        EnableBlips();
                        //  new Vector3(2815f, -3909f, 140);
                        //Arena
                        if (UseBusinessColors == true)
                        {
                            foreach (Vehicle V in Vehicles)
                            {
                                if (V != null)
                                {
                                    if (V.CurrentBlip != null)
                                    {

                                        V.CurrentBlip.Color = BlipColor.Blue;


                                    }
                                }

                            }
                        }
                    }

                    if (World.GetDistance(Game.Player.Character.Position, new Vector3(-190.843f, -588.043f, 135f)) < 100f ||
                       World.GetDistance(Game.Player.Character.Position, new Vector3(-144f, -594, 167f)) < 100f)//Arcadius
                    {
                        EnableBlips();
                        //  new Vector3(2815f, -3909f, 140);
                        //Arena
                        if (UseBusinessColors == true)
                        {
                            foreach (Vehicle V in Vehicles)
                            {
                                if (V != null)
                                {
                                    if (V.CurrentBlip != null)
                                    {

                                        V.CurrentBlip.Color = BlipColor.Yellow;


                                    }
                                }

                            }
                        }
                    }

                    if (World.GetDistance(Game.Player.Character.Position, new Vector3(-1388.21F, -487.512F, 56F)) <100f ||
               World.GetDistance(Game.Player.Character.Position, new Vector3(-75f, -819f, 285f)) < 100f)//Maze Bank West
                    {
                        EnableBlips();
                        //  new Vector3(2815f, -3909f, 140);
                        //Arena
                        if (UseBusinessColors == true)
                        {
                            foreach (Vehicle V in Vehicles)
                            {
                                if (V != null)
                                {
                                    if (V.CurrentBlip != null)
                                    {

                                        V.CurrentBlip.Color = BlipColor.Red;


                                    }
                                }

                            }
                        }
                    }

                    if (World.GetDistance(Game.Player.Character.Position, new Vector3(-1588.75f, -572.097f, 85.5f)) < 100f ||
          World.GetDistance(Game.Player.Character.Position, new Vector3(-1578f, -577, 105f)) < 100f)//Lombok
                    {
                        EnableBlips();
                        //  new Vector3(2815f, -3909f, 140);
                        //Arena
                        if (UseBusinessColors == true)
                        {
                            foreach (Vehicle V in Vehicles)
                            {
                                if (V != null)
                                {
                                    if (V.CurrentBlip != null)
                                    {

                                        V.CurrentBlip.Color = BlipColor.Green;


                                    }
                                }

                            }
                        }
                    }

                }
            }
            
                if (Timer != 48)
                {
                    Timer++;
                }


            
        }

    }
}
