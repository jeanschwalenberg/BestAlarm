using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BestAlarm.Models;
using BestAlarm.Controllers;

namespace BestAlarm.Models {
    public class Alarm {
        //TODOAlarmID will eventually need to handle like 5 values or maybe 10
        public int AlarmID = 0;
        //AlarmName does not have to be nullable because it is a string[array of chars] and can be null
        public string AlarmName { get; set; }
        //TODO cuz be real, AlarmSound is gonna be at least two controllers and a day of research
        public string AlarmSound { get; set; }
        //TODO AlarmTimeSelected really needs to be a manpulated string
        public DateTime AlarmTimeSelected { get; set; }
        //TODO SnoozeAllowed gets set in HomeController... fuck me, maybe I overload the instantiation?
        //... considering I'm cold-coding this at [now] 2:44am with no notes/research/reference allowed...
        //AAaaaaayyyeeeee am the bowl god.
        public bool SnoozeAllowed = false;
        //ditto above comments(SnoozeAllowed)
        public bool UseTwentyFourHourClock = false;
        //2 below might not be bools, definitely should be in HomeController or elsewhere
        public bool ValidateVolume = false;
        public bool ValidateVsVarious = false;
    }
}