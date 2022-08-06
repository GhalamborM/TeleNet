using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleNet.Models.TL;
using TeleNet.Models.TL.Auth;

namespace  TeleNet.Models.TL96.Account
{
    [TLObject(-1516022023)]
    public class TLRequestSendVerifyPhoneCode : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return -1516022023;
            }
        }

        public string PhoneNumber { get; set; }
        public TLCodeSettings Settings { get; set; }
        public TLSentCode Response { get; set; }


        public void ComputeFlags()
        {

        }

        public override void DeserializeBody(BinaryReader br)
        {
            PhoneNumber = StringUtil.Deserialize(br);
            Settings = (TLCodeSettings)ObjectUtils.DeserializeObject(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
            bw.Write(Constructor);
            StringUtil.Serialize(PhoneNumber, bw);
            ObjectUtils.SerializeObject(Settings, bw);

        }

        public override void DeserializeResponse(BinaryReader br)
        {
            Response = (TLSentCode)ObjectUtils.DeserializeObject(br);

        }
    }
}
