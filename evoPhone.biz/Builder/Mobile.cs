﻿using System.Collections.Generic;
using System.Text;
using EvoPhone.Common;

namespace evoPhone.biz {
    public class Mobile {
        public string PhoneModel { get; }
        private readonly Dictionary<string, IPhonePart> vParts = new Dictionary<string, IPhonePart>();

        public Mobile(string phoneModel) {
            PhoneModel = phoneModel;
        }

        public IPhonePart this[string key] {
            get { return vParts[key]; }
            set { vParts[key] = value; }
        }

        public override string ToString() {
            var stringBuilder = new StringBuilder();
            stringBuilder.AppendLine();
            stringBuilder.Append('-', 80);
            stringBuilder.AppendLine();
            stringBuilder.Append($"Phone Model: {PhoneModel}");
            stringBuilder.AppendLine();

            foreach (KeyValuePair<string, IPhonePart> pair in vParts) {
                string status;
                switch (vParts[pair.Key].GetStatus()) {
                    case PartStatus.Activated:
                        status = "Active";
                        break;
                    case PartStatus.Deactivated:
                        status = "Deactivated";
                        break;
                    default:
                        status = "Not Applicable";
                        break;
                }

                stringBuilder.Append($" {pair.Key.FirstCharToUpper()} : {vParts[pair.Key].ToString()}."
                                     + " Part status: " + status);
                stringBuilder.AppendLine();
            }

            stringBuilder.Append('-', 80);
            return stringBuilder.ToString();
        }

        public void SetAllActive() {
            var phoneParts = vParts.Values;
            foreach (IPhonePart phonePart in phoneParts) {
                phonePart.SetActive();
            }
        }

        public void SetScreenOff() {
            foreach (var keyValPair in vParts) {
                if (keyValPair.Key == "screen") {
                    keyValPair.Value.SetDeactivated();
                }
            }
        }
    }
}