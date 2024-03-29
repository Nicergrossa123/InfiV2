﻿using GTANetworkAPI;
using GVRP.Module.ClientUI.Apps;
using GVRP.Module.Players;
using GVRP.Module.Players.Db;
using Newtonsoft.Json;

namespace GVRP.Module.Telefon.App
{
    public class TelefonSettingsApp : SimpleApp
    {
        public TelefonSettingsApp() : base("TelefonSettings") { }

        [RemoteEvent]
        public void requestPhoneData(Player p_Player)
        {
            // JSON struc: guthaben, nummer
            //TriggerEvent(p_Player, "requestPhoneData", l_Json);
            DbPlayer l_DbPlayer = p_Player.GetPlayer();
            if (l_DbPlayer == null)
                return;

            PhoneData l_Data = new PhoneData()
            {
                guthaben = l_DbPlayer.guthaben[0],
                number = (int)l_DbPlayer.handy[0]
            };

            var l_Json = NAPI.Util.ToJson(l_Data);

            TriggerEvent(p_Player, "responsePhoneData", l_Json);
        }
    }

    public class PhoneData
    {
        [JsonProperty(PropertyName = "guthaben")]
        public int guthaben { get; set; }

        [JsonProperty(PropertyName = "number")]
        public int number { get; set; }
    }
}
