using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeleNet.Models.TL;

namespace TeleNet.Models.TL140.Messages
{
	[TLObject(-869258997)]
    public class TLRequestForwardMessages : TLMethod
    {
        public override int Constructor
        {
            get
            {
                return -869258997;
            }
        }

                public int Flags {get;set;}
        public bool Silent {get;set;}
        public bool Background {get;set;}
        public bool WithMyScore {get;set;}
        public bool DropAuthor {get;set;}
        public bool DropMediaCaptions {get;set;}
        public bool Noforwards {get;set;}
        public TLAbsInputPeer FromPeer {get;set;}
        public TLVector<int> Id {get;set;}
        public TLVector<long> RandomId {get;set;}
        public TLAbsInputPeer ToPeer {get;set;}
        public int? ScheduleDate {get;set;}
        public TLAbsInputPeer SendAs {get;set;}
public TLAbsUpdates Response { get; set;}


		public void ComputeFlags()
		{
			Flags = 0;
Flags = Silent ? (Flags | 32) : (Flags & ~32);
Flags = Background ? (Flags | 64) : (Flags & ~64);
Flags = WithMyScore ? (Flags | 256) : (Flags & ~256);
Flags = DropAuthor ? (Flags | 2048) : (Flags & ~2048);
Flags = DropMediaCaptions ? (Flags | 4096) : (Flags & ~4096);
Flags = Noforwards ? (Flags | 16384) : (Flags & ~16384);
Flags = ScheduleDate != null ? (Flags | 1024) : (Flags & ~1024);
Flags = SendAs != null ? (Flags | 8192) : (Flags & ~8192);

		}

        public override void DeserializeBody(BinaryReader br)
        {
            Flags = br.ReadInt32();
Silent = (Flags & 32) != 0;
Background = (Flags & 64) != 0;
WithMyScore = (Flags & 256) != 0;
DropAuthor = (Flags & 2048) != 0;
DropMediaCaptions = (Flags & 4096) != 0;
Noforwards = (Flags & 16384) != 0;
FromPeer = (TLAbsInputPeer)ObjectUtils.DeserializeObject(br);
Id = (TLVector<int>)ObjectUtils.DeserializeVector<int>(br);
RandomId = (TLVector<long>)ObjectUtils.DeserializeVector<long>(br);
ToPeer = (TLAbsInputPeer)ObjectUtils.DeserializeObject(br);
if ((Flags & 1024) != 0)
ScheduleDate = br.ReadInt32();
else
ScheduleDate = null;

if ((Flags & 8192) != 0)
SendAs = (TLAbsInputPeer)ObjectUtils.DeserializeObject(br);
else
SendAs = null;


        }

        public override void SerializeBody(BinaryWriter bw)
        {
			bw.Write(Constructor);
            ComputeFlags();
bw.Write(Flags);






ObjectUtils.SerializeObject(FromPeer,bw);
ObjectUtils.SerializeObject(Id,bw);
ObjectUtils.SerializeObject(RandomId,bw);
ObjectUtils.SerializeObject(ToPeer,bw);
if ((Flags & 1024) != 0)
bw.Write(ScheduleDate.Value);
if ((Flags & 8192) != 0)
ObjectUtils.SerializeObject(SendAs,bw);

        }

		public override void DeserializeResponse(BinaryReader br)
		{
			Response = (TLAbsUpdates)ObjectUtils.DeserializeObject(br);

		}
    }
}
