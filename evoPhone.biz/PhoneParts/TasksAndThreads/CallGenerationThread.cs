using System.Threading;

namespace evoPhone.biz.PhoneParts.TasksAndThreads {
    public class CallGenerationThread {
        private Thread vCallGenerationThread;
        private Mobile vMobile;
        private bool vPause = true;
        private object vThreadLock = new object();

        public CallGenerationThread(Mobile mobile) {
            vCallGenerationThread = new Thread(GenerateCall);
            vCallGenerationThread.IsBackground = true;
            vCallGenerationThread.Start();
            vMobile = mobile;
        }

        private void GenerateCall() {
            while (true) {
                if (vPause) {
                    lock (vThreadLock) {
                        Monitor.Wait(vThreadLock);
                    }
                }
                vMobile.CallStorage.RaiseSMSReceivedEvent();
                Thread.Sleep(5000);
            }
        }

        public void Start() {
            //vCallGenerationThread.Resume();
            vPause = false;
            lock (vThreadLock) {
                Monitor.Pulse(vThreadLock);
            }
        }

        public void Stop() {
            //vCallGenerationThread.Suspend();
            vPause = true;
        }
    }
}