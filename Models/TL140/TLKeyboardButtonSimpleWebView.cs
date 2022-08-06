using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleNet.Models.TL;

namespace TeleNet.Models.TL140
{
	[TLObject(-1598009252)]
    public class TLKeyboardButtonSimpleWebView : TLAbsKeyboardButton
    {
        public override int Constructor
        {
            get
            {
                return -1598009252;
            }
        }

             public string Text {get;set;}
     public string Url {get;set;}


		public void ComputeFlags()
		{
			
		}

        public override void DeserializeBody(BinaryReader br)
        {
            Text = StringUtil.Deserialize(br);
Url = StringUtil.Deserialize(br);

        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            StringUtil.Serialize(Text,bw);
StringUtil.Serialize(Url,bw);

        }
    }
}
