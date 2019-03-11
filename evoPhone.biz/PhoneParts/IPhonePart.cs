using EvoPhone.Common;

namespace evoPhone.biz {
    public interface IPhonePart {
        string ToString();

        PartStatus GetStatus();

        void SetActive();

        void SetDeactivated();
    }
}