using System.Threading;

namespace evoPhone.biz.PhoneParts.TasksAndThreads {
    public class SMSGenerationThread {
        private Thread vSMSGenerationThread;
        private Mobile vMobile;

        public SMSGenerationThread(Mobile mobile) {
            vSMSGenerationThread = new Thread(GenerateSMS);
            vSMSGenerationThread.IsBackground = true;
            vSMSGenerationThread.Start();
            vSMSGenerationThread.Suspend();
            vMobile = mobile;
        }

        private void GenerateSMS() {
            //call is made directly to SMSProvider so far there is no logic about Message Receiving etc. It could be modified later.
            while (true) {
                vMobile.SmsStorage.RaiseSMSReceivedEvent();
                Thread.Sleep(5000);
            }
        }

        public void Start() {
            vSMSGenerationThread.Resume();
        }

        public void Stop() {
            vSMSGenerationThread.Suspend();
        }
    }
}