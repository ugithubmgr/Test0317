using Abp.Domain.Services;
using ProFess.Mit.Data;

namespace ProFess.Mit
{
    public interface ISaveMitData : IDomainService
    {
        /// <summary>
        /// �f�[�^�o�^
        /// </summary>
        /// <param name="prmData"></param>
        void RegisterIFData(MitLinkData prmData);
        void RegisterIFData2(MitLinkData prmData);
        void RegisterIFData3(MitLinkData prmData);
        void RegisterIFData4(MitLinkData prmData);
    }
}
