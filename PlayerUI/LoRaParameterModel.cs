using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerUI
{
    class LoRaParameterModel
    {
        private string appEUI = "";
        private string appsKey = "";
        private string devAddr = "";
        private string devEUI= "";
        private string nwksKey = "";
        private string gatewayChannel = "";
        private string loRaChannel = "";
        private string radioFrequency = "";
        private string sf = "";
        private string cfsfDataRate = "";
        // 成員則是透過公用唯讀屬性存取
        public string AppEUI
        {
            get { return appEUI; }
            set { appEUI = value; }
        }

        public string AppsKey
        {
            get { return appsKey; }
            set { appsKey = value; }
        }
        public string DevAddr
        {
            get { return devAddr; }
            set { devAddr = value; }
        }
        public string DevEUI
        {
            get { return devEUI; }
            set { devEUI = value; }
        }
        public string NwksKey
        {
            get { return nwksKey; }
            set { nwksKey = value; }
        }
        public string GatewayChannel
        {
            get { return gatewayChannel; }
            set { gatewayChannel = value; }
        }
        public string LoRaChannel
        {
            get { return loRaChannel; }
            set { loRaChannel = value; }
        }
        public string RadioFrequency
        {
            get { return radioFrequency; }
            set { radioFrequency = value; }
        }
        public string Sf
        {
            get { return sf; }
            set { sf = value; }
        }
        public string CfsfDataRate
        {
            get { return cfsfDataRate; }
            set { cfsfDataRate = value; }
        }
    }
}
