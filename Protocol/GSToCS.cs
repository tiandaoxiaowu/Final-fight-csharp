// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: GSToCS.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GSToCS {

  /// <summary>Holder for reflection information generated from GSToCS.proto</summary>
  public static partial class GSToCSReflection {

    #region Descriptor
    /// <summary>File descriptor for GSToCS.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static GSToCSReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CgxHU1RvQ1MucHJvdG8SBkdTVG9DUyI+CgtVc2VyT2ZmTGluZRIcCgVtZ3Np",
            "ZBgBIAEoDjINLkdTVG9DUy5Nc2dJRBIRCgl1c2VybmV0aWQYAiABKAUiNAoG",
            "QXNraW5nEhwKBW1nc2lkGAEgASgOMg0uR1NUb0NTLk1zZ0lEEgwKBHRpbWUY",
            "AiABKAMiVAoQUmVwb3J0R2V0U29tZU1zZxIcCgVtZ3NpZBgBIAEoDjINLkdT",
            "VG9DUy5Nc2dJRBIQCghnb3Rtc2dpZBgCIAEoBRIQCghvdGhlcnZhbBgDIAEo",
            "BCJiCgpBc2tSZWdpc3RlEhwKBW1zZ2lkGAEgASgOMg0uR1NUb0NTLk1zZ0lE",
            "EgwKBGdzaWQYAiABKAUSCgoCaXAYAyABKAkSDAoEcG9ydBgEIAEoBRIOCgZ1",
            "c2Vwd2QYBSABKAkiXwoLUmVwb3J0R0NNc2cSHAoFbXNnaWQYASABKA4yDS5H",
            "U1RvQ1MuTXNnSUQSDAoEbnNpZBgCIAEoBRISCgpvdGhlcm1zZ2lkGAMgASgF",
            "EhAKCG90aGVybXNnGAQgASgMKuwBCgVNc2dJRBIKCgZ1bmtub3cQABIZChRl",
            "TXNnVG9DU0Zyb21HU19CZWdpbhCAQBIbChZlTXNnVG9DU0Zyb21HU19Bc2tQ",
            "aW5nEIFAEh4KGWVNc2dUb0NTRnJvbUdTX0Fza1JlZ2lzdGUQgkASHwoaZU1z",
            "Z1RvQ1NGcm9tR1NfUmVwb3J0R0NNc2cQg0ASJAofZU1zZ1RvQ1NGcm9tR1Nf",
            "UmVwb3J0R2V0U29tZU1zZxCEQBIfChplTXNnVG9DU0Zyb21HU19Vc2VyT2Zm",
            "TGluZRCFQBIXChJlTXNnVG9DU0Zyb21HU19FbmQQiEBiBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::GSToCS.MsgID), }, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GSToCS.UserOffLine), global::GSToCS.UserOffLine.Parser, new[]{ "Mgsid", "Usernetid" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GSToCS.Asking), global::GSToCS.Asking.Parser, new[]{ "Mgsid", "Time" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GSToCS.ReportGetSomeMsg), global::GSToCS.ReportGetSomeMsg.Parser, new[]{ "Mgsid", "Gotmsgid", "Otherval" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GSToCS.AskRegiste), global::GSToCS.AskRegiste.Parser, new[]{ "Msgid", "Gsid", "Ip", "Port", "Usepwd" }, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GSToCS.ReportGCMsg), global::GSToCS.ReportGCMsg.Parser, new[]{ "Msgid", "Nsid", "Othermsgid", "Othermsg" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum MsgID {
    [pbr::OriginalName("unknow")] Unknow = 0,
    [pbr::OriginalName("eMsgToCSFromGS_Begin")] EMsgToCsfromGsBegin = 8192,
    [pbr::OriginalName("eMsgToCSFromGS_AskPing")] EMsgToCsfromGsAskPing = 8193,
    [pbr::OriginalName("eMsgToCSFromGS_AskRegiste")] EMsgToCsfromGsAskRegiste = 8194,
    [pbr::OriginalName("eMsgToCSFromGS_ReportGCMsg")] EMsgToCsfromGsReportGcmsg = 8195,
    [pbr::OriginalName("eMsgToCSFromGS_ReportGetSomeMsg")] EMsgToCsfromGsReportGetSomeMsg = 8196,
    [pbr::OriginalName("eMsgToCSFromGS_UserOffLine")] EMsgToCsfromGsUserOffLine = 8197,
    [pbr::OriginalName("eMsgToCSFromGS_End")] EMsgToCsfromGsEnd = 8200,
  }

  #endregion

  #region Messages
  public sealed partial class UserOffLine : pb::IMessage<UserOffLine> {
    private static readonly pb::MessageParser<UserOffLine> _parser = new pb::MessageParser<UserOffLine>(() => new UserOffLine());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<UserOffLine> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GSToCS.GSToCSReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserOffLine() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserOffLine(UserOffLine other) : this() {
      mgsid_ = other.mgsid_;
      usernetid_ = other.usernetid_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public UserOffLine Clone() {
      return new UserOffLine(this);
    }

    /// <summary>Field number for the "mgsid" field.</summary>
    public const int MgsidFieldNumber = 1;
    private global::GSToCS.MsgID mgsid_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GSToCS.MsgID Mgsid {
      get { return mgsid_; }
      set {
        mgsid_ = value;
      }
    }

    /// <summary>Field number for the "usernetid" field.</summary>
    public const int UsernetidFieldNumber = 2;
    private int usernetid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Usernetid {
      get { return usernetid_; }
      set {
        usernetid_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as UserOffLine);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(UserOffLine other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Mgsid != other.Mgsid) return false;
      if (Usernetid != other.Usernetid) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Mgsid != 0) hash ^= Mgsid.GetHashCode();
      if (Usernetid != 0) hash ^= Usernetid.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Mgsid != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Mgsid);
      }
      if (Usernetid != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Usernetid);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Mgsid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Mgsid);
      }
      if (Usernetid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Usernetid);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(UserOffLine other) {
      if (other == null) {
        return;
      }
      if (other.Mgsid != 0) {
        Mgsid = other.Mgsid;
      }
      if (other.Usernetid != 0) {
        Usernetid = other.Usernetid;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            mgsid_ = (global::GSToCS.MsgID) input.ReadEnum();
            break;
          }
          case 16: {
            Usernetid = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  public sealed partial class Asking : pb::IMessage<Asking> {
    private static readonly pb::MessageParser<Asking> _parser = new pb::MessageParser<Asking>(() => new Asking());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Asking> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GSToCS.GSToCSReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Asking() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Asking(Asking other) : this() {
      mgsid_ = other.mgsid_;
      time_ = other.time_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Asking Clone() {
      return new Asking(this);
    }

    /// <summary>Field number for the "mgsid" field.</summary>
    public const int MgsidFieldNumber = 1;
    private global::GSToCS.MsgID mgsid_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GSToCS.MsgID Mgsid {
      get { return mgsid_; }
      set {
        mgsid_ = value;
      }
    }

    /// <summary>Field number for the "time" field.</summary>
    public const int TimeFieldNumber = 2;
    private long time_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long Time {
      get { return time_; }
      set {
        time_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Asking);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Asking other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Mgsid != other.Mgsid) return false;
      if (Time != other.Time) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Mgsid != 0) hash ^= Mgsid.GetHashCode();
      if (Time != 0L) hash ^= Time.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Mgsid != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Mgsid);
      }
      if (Time != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(Time);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Mgsid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Mgsid);
      }
      if (Time != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(Time);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Asking other) {
      if (other == null) {
        return;
      }
      if (other.Mgsid != 0) {
        Mgsid = other.Mgsid;
      }
      if (other.Time != 0L) {
        Time = other.Time;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            mgsid_ = (global::GSToCS.MsgID) input.ReadEnum();
            break;
          }
          case 16: {
            Time = input.ReadInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ReportGetSomeMsg : pb::IMessage<ReportGetSomeMsg> {
    private static readonly pb::MessageParser<ReportGetSomeMsg> _parser = new pb::MessageParser<ReportGetSomeMsg>(() => new ReportGetSomeMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReportGetSomeMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GSToCS.GSToCSReflection.Descriptor.MessageTypes[2]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportGetSomeMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportGetSomeMsg(ReportGetSomeMsg other) : this() {
      mgsid_ = other.mgsid_;
      gotmsgid_ = other.gotmsgid_;
      otherval_ = other.otherval_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportGetSomeMsg Clone() {
      return new ReportGetSomeMsg(this);
    }

    /// <summary>Field number for the "mgsid" field.</summary>
    public const int MgsidFieldNumber = 1;
    private global::GSToCS.MsgID mgsid_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GSToCS.MsgID Mgsid {
      get { return mgsid_; }
      set {
        mgsid_ = value;
      }
    }

    /// <summary>Field number for the "gotmsgid" field.</summary>
    public const int GotmsgidFieldNumber = 2;
    private int gotmsgid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Gotmsgid {
      get { return gotmsgid_; }
      set {
        gotmsgid_ = value;
      }
    }

    /// <summary>Field number for the "otherval" field.</summary>
    public const int OthervalFieldNumber = 3;
    private ulong otherval_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ulong Otherval {
      get { return otherval_; }
      set {
        otherval_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReportGetSomeMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReportGetSomeMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Mgsid != other.Mgsid) return false;
      if (Gotmsgid != other.Gotmsgid) return false;
      if (Otherval != other.Otherval) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Mgsid != 0) hash ^= Mgsid.GetHashCode();
      if (Gotmsgid != 0) hash ^= Gotmsgid.GetHashCode();
      if (Otherval != 0UL) hash ^= Otherval.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Mgsid != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Mgsid);
      }
      if (Gotmsgid != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Gotmsgid);
      }
      if (Otherval != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Otherval);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Mgsid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Mgsid);
      }
      if (Gotmsgid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Gotmsgid);
      }
      if (Otherval != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Otherval);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReportGetSomeMsg other) {
      if (other == null) {
        return;
      }
      if (other.Mgsid != 0) {
        Mgsid = other.Mgsid;
      }
      if (other.Gotmsgid != 0) {
        Gotmsgid = other.Gotmsgid;
      }
      if (other.Otherval != 0UL) {
        Otherval = other.Otherval;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            mgsid_ = (global::GSToCS.MsgID) input.ReadEnum();
            break;
          }
          case 16: {
            Gotmsgid = input.ReadInt32();
            break;
          }
          case 24: {
            Otherval = input.ReadUInt64();
            break;
          }
        }
      }
    }

  }

  public sealed partial class AskRegiste : pb::IMessage<AskRegiste> {
    private static readonly pb::MessageParser<AskRegiste> _parser = new pb::MessageParser<AskRegiste>(() => new AskRegiste());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<AskRegiste> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GSToCS.GSToCSReflection.Descriptor.MessageTypes[3]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AskRegiste() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AskRegiste(AskRegiste other) : this() {
      msgid_ = other.msgid_;
      gsid_ = other.gsid_;
      ip_ = other.ip_;
      port_ = other.port_;
      usepwd_ = other.usepwd_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public AskRegiste Clone() {
      return new AskRegiste(this);
    }

    /// <summary>Field number for the "msgid" field.</summary>
    public const int MsgidFieldNumber = 1;
    private global::GSToCS.MsgID msgid_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GSToCS.MsgID Msgid {
      get { return msgid_; }
      set {
        msgid_ = value;
      }
    }

    /// <summary>Field number for the "gsid" field.</summary>
    public const int GsidFieldNumber = 2;
    private int gsid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Gsid {
      get { return gsid_; }
      set {
        gsid_ = value;
      }
    }

    /// <summary>Field number for the "ip" field.</summary>
    public const int IpFieldNumber = 3;
    private string ip_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Ip {
      get { return ip_; }
      set {
        ip_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "port" field.</summary>
    public const int PortFieldNumber = 4;
    private int port_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Port {
      get { return port_; }
      set {
        port_ = value;
      }
    }

    /// <summary>Field number for the "usepwd" field.</summary>
    public const int UsepwdFieldNumber = 5;
    private string usepwd_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Usepwd {
      get { return usepwd_; }
      set {
        usepwd_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as AskRegiste);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(AskRegiste other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Msgid != other.Msgid) return false;
      if (Gsid != other.Gsid) return false;
      if (Ip != other.Ip) return false;
      if (Port != other.Port) return false;
      if (Usepwd != other.Usepwd) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Msgid != 0) hash ^= Msgid.GetHashCode();
      if (Gsid != 0) hash ^= Gsid.GetHashCode();
      if (Ip.Length != 0) hash ^= Ip.GetHashCode();
      if (Port != 0) hash ^= Port.GetHashCode();
      if (Usepwd.Length != 0) hash ^= Usepwd.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Msgid != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Msgid);
      }
      if (Gsid != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Gsid);
      }
      if (Ip.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Ip);
      }
      if (Port != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(Port);
      }
      if (Usepwd.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(Usepwd);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Msgid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Msgid);
      }
      if (Gsid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Gsid);
      }
      if (Ip.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Ip);
      }
      if (Port != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Port);
      }
      if (Usepwd.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Usepwd);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(AskRegiste other) {
      if (other == null) {
        return;
      }
      if (other.Msgid != 0) {
        Msgid = other.Msgid;
      }
      if (other.Gsid != 0) {
        Gsid = other.Gsid;
      }
      if (other.Ip.Length != 0) {
        Ip = other.Ip;
      }
      if (other.Port != 0) {
        Port = other.Port;
      }
      if (other.Usepwd.Length != 0) {
        Usepwd = other.Usepwd;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            msgid_ = (global::GSToCS.MsgID) input.ReadEnum();
            break;
          }
          case 16: {
            Gsid = input.ReadInt32();
            break;
          }
          case 26: {
            Ip = input.ReadString();
            break;
          }
          case 32: {
            Port = input.ReadInt32();
            break;
          }
          case 42: {
            Usepwd = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class ReportGCMsg : pb::IMessage<ReportGCMsg> {
    private static readonly pb::MessageParser<ReportGCMsg> _parser = new pb::MessageParser<ReportGCMsg>(() => new ReportGCMsg());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ReportGCMsg> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GSToCS.GSToCSReflection.Descriptor.MessageTypes[4]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportGCMsg() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportGCMsg(ReportGCMsg other) : this() {
      msgid_ = other.msgid_;
      nsid_ = other.nsid_;
      othermsgid_ = other.othermsgid_;
      othermsg_ = other.othermsg_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ReportGCMsg Clone() {
      return new ReportGCMsg(this);
    }

    /// <summary>Field number for the "msgid" field.</summary>
    public const int MsgidFieldNumber = 1;
    private global::GSToCS.MsgID msgid_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::GSToCS.MsgID Msgid {
      get { return msgid_; }
      set {
        msgid_ = value;
      }
    }

    /// <summary>Field number for the "nsid" field.</summary>
    public const int NsidFieldNumber = 2;
    private int nsid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Nsid {
      get { return nsid_; }
      set {
        nsid_ = value;
      }
    }

    /// <summary>Field number for the "othermsgid" field.</summary>
    public const int OthermsgidFieldNumber = 3;
    private int othermsgid_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Othermsgid {
      get { return othermsgid_; }
      set {
        othermsgid_ = value;
      }
    }

    /// <summary>Field number for the "othermsg" field.</summary>
    public const int OthermsgFieldNumber = 4;
    private pb::ByteString othermsg_ = pb::ByteString.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pb::ByteString Othermsg {
      get { return othermsg_; }
      set {
        othermsg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ReportGCMsg);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ReportGCMsg other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Msgid != other.Msgid) return false;
      if (Nsid != other.Nsid) return false;
      if (Othermsgid != other.Othermsgid) return false;
      if (Othermsg != other.Othermsg) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Msgid != 0) hash ^= Msgid.GetHashCode();
      if (Nsid != 0) hash ^= Nsid.GetHashCode();
      if (Othermsgid != 0) hash ^= Othermsgid.GetHashCode();
      if (Othermsg.Length != 0) hash ^= Othermsg.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Msgid != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) Msgid);
      }
      if (Nsid != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(Nsid);
      }
      if (Othermsgid != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(Othermsgid);
      }
      if (Othermsg.Length != 0) {
        output.WriteRawTag(34);
        output.WriteBytes(Othermsg);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Msgid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Msgid);
      }
      if (Nsid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Nsid);
      }
      if (Othermsgid != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Othermsgid);
      }
      if (Othermsg.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeBytesSize(Othermsg);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ReportGCMsg other) {
      if (other == null) {
        return;
      }
      if (other.Msgid != 0) {
        Msgid = other.Msgid;
      }
      if (other.Nsid != 0) {
        Nsid = other.Nsid;
      }
      if (other.Othermsgid != 0) {
        Othermsgid = other.Othermsgid;
      }
      if (other.Othermsg.Length != 0) {
        Othermsg = other.Othermsg;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            msgid_ = (global::GSToCS.MsgID) input.ReadEnum();
            break;
          }
          case 16: {
            Nsid = input.ReadInt32();
            break;
          }
          case 24: {
            Othermsgid = input.ReadInt32();
            break;
          }
          case 34: {
            Othermsg = input.ReadBytes();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
