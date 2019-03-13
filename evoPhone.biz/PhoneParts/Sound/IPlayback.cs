using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evoPhone.biz.PhoneParts.Sound {
    public interface IPlayback {
        void Play(object soundData);

        bool IsConnected { get; set; }
    }
}
