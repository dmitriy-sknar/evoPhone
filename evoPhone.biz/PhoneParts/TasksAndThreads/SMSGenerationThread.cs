using System.Threading;

namespace evoPhone.biz.PhoneParts.TasksAndThreads {
    public class SMSGenerationThread {
        private Thread vSMSGenerationThread;
        private Mobile vMobile;
        private bool vPause = true;
        private object vThreadLock = new object();

        public SMSGenerationThread(Mobile mobile) {
            vSMSGenerationThread = new Thread(GenerateSMS);
            vSMSGenerationThread.IsBackground = true;
            vSMSGenerationThread.Start();
            vMobile = mobile;
        }

        private void GenerateSMS() {
            //call is made directly to SMSProvider so far there is no logic about Message Receiving etc. It could be modified later.
            while (true) {
                if (vPause) {
                    lock (vThreadLock) {
                        Monitor.Wait(vThreadLock);
                    }
                }
                vMobile?.SmsStorage?.RaiseSMSReceivedEvent();
                Thread.Sleep(5000);
            }
        }

        public void Start() {
            //vSMSGenerationThread.Resume();
            vPause = false;
            lock (vThreadLock) {
                Monitor.Pulse(vThreadLock);
            }
        }

        public void Stop() {
            //vSMSGenerationThread.Suspend();
            vPause = true;
        }
    }
}