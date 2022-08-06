using System.IO;

namespace TeleNet.Models.TL.Help
{
    [TLObject(398898678)]
    public class TLSupport : TLObject
    {
        public override int Constructor
        {
            get
            {
                return 398898678;
            }
        }

        public string PhoneNumber { get; set; }
        public TLAbsUser User { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            PhoneNumber = StringUtil.Deserialize(br);
            User = (TLAbsUser)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            StringUtil.Serialize(PhoneNumber, bw);
            ObjectUtils.SerializeObject(User, bw);

        }
    }
}
