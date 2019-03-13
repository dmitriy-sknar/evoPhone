namespace evoPhone.biz.PhoneParts.Sound {
    interface IMiniJack {
        bool IsMicrophonePresent { get; }
        bool IsButtonPressed { get; set; }
    }
}
