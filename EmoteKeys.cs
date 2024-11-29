using MelonLoader;
using UnityEngine;
using HarmonyLib;
using Mirror;

[assembly: MelonInfo(typeof(Emote_HotKeys.EmoteKeys), "Emote HotKeys", "1.0.0", "Lilly", null)]
[assembly: MelonGame("KisSoft", "ATLYSS")]

namespace Emote_HotKeys
{
    public class EmoteKeys : MelonMod
    {
        static EmoteKeys instance;
        public Player Localplayer;

        [HarmonyPatch(typeof(Player), "OnGameConditionChange")]
        public static class playerspawn
        {
            private static void Postfix(ref Player __instance)
            {
                if (__instance._currentGameCondition == GameCondition.IN_GAME && __instance.isLocalPlayer)
                {
                    EmoteKeys.instance.Localplayer = __instance;
                }
            }
        }

        public override void OnInitializeMelon()
        {
            instance = this;
        }

        public override void OnUpdate()
        {
            try
            {
                if (Localplayer._inChat || Localplayer._inUI || Localplayer._bufferingStatus || HostConsole._current._isOpen)
                {
                    return;
                }
                else if (Input.GetKeyDown(KeyCode.B))
                {
                    ChatBehaviour._current.Cmd_SendChatMessage("/dance", ChatBehaviour.ChatChannel.ZONE);
                }
                else if (Input.GetKeyDown(KeyCode.N))
                {
                    ChatBehaviour._current.Cmd_SendChatMessage("/clap", ChatBehaviour.ChatChannel.ZONE);
                }
                else if (Input.GetKeyDown(KeyCode.M))
                {
                    ChatBehaviour._current.Cmd_SendChatMessage("/taunt", ChatBehaviour.ChatChannel.ZONE);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha7))
                {
                    ChatBehaviour._current.Cmd_SendChatMessage("/point", ChatBehaviour.ChatChannel.ZONE);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha8))
                {
                    ChatBehaviour._current.Cmd_SendChatMessage("/ponder", ChatBehaviour.ChatChannel.ZONE);
                }
                else if (Input.GetKeyDown(KeyCode.Alpha9))
                {
                    ChatBehaviour._current.Cmd_SendChatMessage("/nod", ChatBehaviour.ChatChannel.ZONE);
                }
            }
            catch (Exception e)
            {
                //MelonLogger.Msg(e);
            }
        }
    }
}