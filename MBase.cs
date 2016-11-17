//using System;
//using System.IO;
//using System.Collections.Generic;
//using Microsoft.Xna.Framework;
//using Microsoft.Xna.Framework.Input;
//using Microsoft.Xna.Framework.Content;
//using Microsoft.Xna.Framework.Graphics;
//using Terraria;
//using Terraria.DataStructures;
//using Terraria.ID;
//using Terraria.ModLoader;

//namespace OmnirsNosPak
//{
//    public class MBase : Mod //MBase can be any name
//    {
//            public MBase() : base() { self = this; }

//            public static MBase self = null;

//            public static Texture2D GetTexture(string name, string prefix = "Textures/")
//            {
//                if (Main.netMode == 2 || Main.dedServ) { return null; }
//                if (precachedTextures.ContainsKey(prefix + name)) return precachedTextures[prefix + name];
//                foreach (KeyValuePair<string, Texture2D> kvp in self.textures)
//                {
//                    string tex = kvp.Key;
//                    if (tex.Contains(prefix) && (tex.Contains("/" + name) || tex.Contains("\\" + name))) { precachedTextures.Add(prefix + name, kvp.Value); return kvp.Value; }
//                }
//                throw new Exception("Texture \"" + name + "\" is missing!");
//            }
//            public static void LoadNonPreTextures(string prefix = "Textures/")
//            {
//                if (Main.netMode == 2 || Main.dedServ) { return; }
//                List<string> keys = new List<string>();
//                foreach (KeyValuePair<string, byte[]> kvp in self.includes)
//                {
//                    string tex = kvp.Key;
//                    if (tex.Contains(prefix) && (tex.Contains("/NPM") || tex.Contains("\\NPM"))) { keys.Add(tex); break; }
//                }
//                foreach (string key in keys)
//                {
//                    using (MemoryStream ms = new MemoryStream(self.includes[key]))
//                        self.textures[key.Remove(key.Length - 5)] = Texture2D.FromStream(API.main.GraphicsDevice, ms);
//                }
//            }
//    }
//}