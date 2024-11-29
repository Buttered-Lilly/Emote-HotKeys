using MelonLoader;
using UnityEngine;
using HarmonyLib;

[assembly: MelonInfo(typeof(Emote_HotKeys.Core), "Emote HotKeys", "1.0.0", "Lilly", null)]
[assembly: MelonGame("KisSoft", "ATLYSS")]

namespace Emote_HotKeys
{
    public class Core : MelonMod
    {
        public override void OnUpdate()
        {
            try
            {
                if (Input.GetKeyDown(KeyCode.B))
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