﻿using Shared.Network;

namespace Shared.Objects
{
    /*
    struct __unaligned __declspec(align(1)) XiStrTeamInfo
    {
      __int64 TeamId;
      __int64 TeamMarkId;
      wchar_t TeamName[13];
      wchar_t TeamDesc[61];
      char TeamUrl[33];
      unsigned int CreateDate;
      unsigned int CloseDate;
      unsigned int BanishDate;
      char OwnChannel[24];
      char TeamState[2];
      unsigned int TeamRanking;
      unsigned int TeamPoint;
      unsigned int ChannelWinCnt;
      unsigned int MemberCnt;
      __int64 TeamTotalExp;
      __int64 TeamTotalMoney;
      unsigned int Version;
      __int64 OwnerId;
      __int64 LeaderId;
      XiStrCharName OwnerName;
      XiStrCharName LeaderName;
    };
    */
    public class Team : ISerializable
    {
        public uint BanishDate;
        public uint ChannelWinCnt;
        public uint CloseDate;
        public uint CreateDate;
        public long LeaderId;
        public string LeaderName; // 21
        public uint MemberCnt;
        public string OwnChannel; // char 24
        public long OwnerId;
        public string OwnerName; // 21
        public string TeamDesc; // unicode 61
        public long TeamId;
        public long TeamMarkId;
        public string TeamName; // unicode 13
        public uint TeamPoint;
        public uint TeamRanking;
        public string TeamState; // char 2
        public long TeamTotalExp;
        public long TeamTotalMoney;
        public string TeamUrl; // char 33
        public uint Version;

        // 243 <-- length

        //Wrong Packet Size. CMD(841) CmdLen: : 692, AnalysisSize: 393
        // We're still missing ~209 bytes of data
        public void Serialize(PacketWriter writer)
        {
            writer.Write(TeamId);
            writer.Write(TeamMarkId);
            writer.WriteUnicodeStatic(TeamName, 13); // unicode 13
            writer.WriteUnicodeStatic(TeamDesc, 61); // unicode 61
            writer.WriteAsciiStatic(TeamUrl, 33); // char 33
            writer.Write(CreateDate);
            writer.Write(CloseDate);
            writer.Write(BanishDate);
            writer.WriteAsciiStatic(OwnChannel, 24); // char 24
            writer.WriteAsciiStatic(TeamState, 2); // char 2
            writer.Write(TeamRanking);
            writer.Write(TeamPoint);
            writer.Write(ChannelWinCnt);
            writer.Write(MemberCnt);
            writer.Write(TeamTotalExp);
            writer.Write(TeamTotalMoney);
            writer.Write(Version);
            writer.Write(OwnerId);
            writer.Write(LeaderId);
            writer.WriteUnicodeStatic(OwnerName, 21); // 21
            writer.WriteUnicodeStatic(LeaderName, 21); // 21
        }
    }
}