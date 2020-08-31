﻿using Caliburn.Micro;
using MqttMonitoringApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MqttMonitoringApp.ViewModels
{
    class CustomPopupViewModel : Conductor<object>
    {
        private string brokerIp;
        public string BokerIP
        {
            get => brokerIp;
            set {
                brokerIp = value;
                NotifyOfPropertyChange(() => BokerIP);
            }
        }
        private string topic;
        public string Topic
        {
            get => topic;
            set 
            {
                topic = value;
                NotifyOfPropertyChange(() => Topic);
            }

        }
        public CustomPopupViewModel(string title)
        {
            DisplayName = title;

            BokerIP = "localhost";
            Topic = "home/device/data/";
        }
        public void AcceptClose()
        {
            Commons.BROKERHOST = BokerIP;
            Commons.PUB_TOPIC = Topic;
            TryClose(true);
        }
    }
}
