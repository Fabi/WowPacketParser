// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: bgs/low/pb/client/club_service.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Club.V1 {

  /// <summary>Holder for reflection information generated from bgs/low/pb/client/club_service.proto</summary>
  public static partial class ClubServiceReflection {

    #region Descriptor
    /// <summary>File descriptor for bgs/low/pb/client/club_service.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ClubServiceReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRiZ3MvbG93L3BiL2NsaWVudC9jbHViX3NlcnZpY2UucHJvdG8SFGJncy5w",
            "cm90b2NvbC5jbHViLnYxGiRiZ3MvbG93L3BiL2NsaWVudC9jbHViX3JlcXVl",
            "c3QucHJvdG8ysCsKC0NsdWJTZXJ2aWNlElEKCVN1YnNjcmliZRImLmJncy5w",
            "cm90b2NvbC5jbHViLnYxLlN1YnNjcmliZVJlcXVlc3QaFC5iZ3MucHJvdG9j",
            "b2wuTm9EYXRhIgaC+SsCCAESVQoLVW5zdWJzY3JpYmUSKC5iZ3MucHJvdG9j",
            "b2wuY2x1Yi52MS5VbnN1YnNjcmliZVJlcXVlc3QaFC5iZ3MucHJvdG9jb2wu",
            "Tm9EYXRhIgaC+SsCCAISWwoGQ3JlYXRlEiMuYmdzLnByb3RvY29sLmNsdWIu",
            "djEuQ3JlYXRlUmVxdWVzdBokLmJncy5wcm90b2NvbC5jbHViLnYxLkNyZWF0",
            "ZVJlc3BvbnNlIgaC+SsCCAMSTQoHRGVzdHJveRIkLmJncy5wcm90b2NvbC5j",
            "bHViLnYxLkRlc3Ryb3lSZXF1ZXN0GhQuYmdzLnByb3RvY29sLk5vRGF0YSIG",
            "gvkrAggEEnMKDkdldERlc2NyaXB0aW9uEisuYmdzLnByb3RvY29sLmNsdWIu",
            "djEuR2V0RGVzY3JpcHRpb25SZXF1ZXN0GiwuYmdzLnByb3RvY29sLmNsdWIu",
            "djEuR2V0RGVzY3JpcHRpb25SZXNwb25zZSIGgvkrAggFEmoKC0dldENsdWJU",
            "eXBlEiguYmdzLnByb3RvY29sLmNsdWIudjEuR2V0Q2x1YlR5cGVSZXF1ZXN0",
            "GikuYmdzLnByb3RvY29sLmNsdWIudjEuR2V0Q2x1YlR5cGVSZXNwb25zZSIG",
            "gvkrAggGEl0KD1VwZGF0ZUNsdWJTdGF0ZRIsLmJncy5wcm90b2NvbC5jbHVi",
            "LnYxLlVwZGF0ZUNsdWJTdGF0ZVJlcXVlc3QaFC5iZ3MucHJvdG9jb2wuTm9E",
            "YXRhIgaC+SsCCAcSYwoSVXBkYXRlQ2x1YlNldHRpbmdzEi8uYmdzLnByb3Rv",
            "Y29sLmNsdWIudjEuVXBkYXRlQ2x1YlNldHRpbmdzUmVxdWVzdBoULmJncy5w",
            "cm90b2NvbC5Ob0RhdGEiBoL5KwIICBJHCgRKb2luEiEuYmdzLnByb3RvY29s",
            "LmNsdWIudjEuSm9pblJlcXVlc3QaFC5iZ3MucHJvdG9jb2wuTm9EYXRhIgaC",
            "+SsCCB4SSQoFTGVhdmUSIi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5MZWF2ZVJl",
            "cXVlc3QaFC5iZ3MucHJvdG9jb2wuTm9EYXRhIgaC+SsCCB8SRwoES2ljaxIh",
            "LmJncy5wcm90b2NvbC5jbHViLnYxLktpY2tSZXF1ZXN0GhQuYmdzLnByb3Rv",
            "Y29sLk5vRGF0YSIGgvkrAgggEmQKCUdldE1lbWJlchImLmJncy5wcm90b2Nv",
            "bC5jbHViLnYxLkdldE1lbWJlclJlcXVlc3QaJy5iZ3MucHJvdG9jb2wuY2x1",
            "Yi52MS5HZXRNZW1iZXJSZXNwb25zZSIGgvkrAgghEmcKCkdldE1lbWJlcnMS",
            "Jy5iZ3MucHJvdG9jb2wuY2x1Yi52MS5HZXRNZW1iZXJzUmVxdWVzdBooLmJn",
            "cy5wcm90b2NvbC5jbHViLnYxLkdldE1lbWJlcnNSZXNwb25zZSIGgvkrAggi",
            "EmEKEVVwZGF0ZU1lbWJlclN0YXRlEi4uYmdzLnByb3RvY29sLmNsdWIudjEu",
            "VXBkYXRlTWVtYmVyU3RhdGVSZXF1ZXN0GhQuYmdzLnByb3RvY29sLk5vRGF0",
            "YSIGgvkrAggjEmkKFVVwZGF0ZVN1YnNjcmliZXJTdGF0ZRIyLmJncy5wcm90",
            "b2NvbC5jbHViLnYxLlVwZGF0ZVN1YnNjcmliZXJTdGF0ZVJlcXVlc3QaFC5i",
            "Z3MucHJvdG9jb2wuTm9EYXRhIgaC+SsCCCQSUwoKQXNzaWduUm9sZRInLmJn",
            "cy5wcm90b2NvbC5jbHViLnYxLkFzc2lnblJvbGVSZXF1ZXN0GhQuYmdzLnBy",
            "b3RvY29sLk5vRGF0YSIGgvkrAgglElcKDFVuYXNzaWduUm9sZRIpLmJncy5w",
            "cm90b2NvbC5jbHViLnYxLlVuYXNzaWduUm9sZVJlcXVlc3QaFC5iZ3MucHJv",
            "dG9jb2wuTm9EYXRhIgaC+SsCCCYSWwoOU2VuZEludml0YXRpb24SKy5iZ3Mu",
            "cHJvdG9jb2wuY2x1Yi52MS5TZW5kSW52aXRhdGlvblJlcXVlc3QaFC5iZ3Mu",
            "cHJvdG9jb2wuTm9EYXRhIgaC+SsCCDISXwoQQWNjZXB0SW52aXRhdGlvbhIt",
            "LmJncy5wcm90b2NvbC5jbHViLnYxLkFjY2VwdEludml0YXRpb25SZXF1ZXN0",
            "GhQuYmdzLnByb3RvY29sLk5vRGF0YSIGgvkrAggzEmEKEURlY2xpbmVJbnZp",
            "dGF0aW9uEi4uYmdzLnByb3RvY29sLmNsdWIudjEuRGVjbGluZUludml0YXRp",
            "b25SZXF1ZXN0GhQuYmdzLnByb3RvY29sLk5vRGF0YSIGgvkrAgg0El8KEFJl",
            "dm9rZUludml0YXRpb24SLS5iZ3MucHJvdG9jb2wuY2x1Yi52MS5SZXZva2VJ",
            "bnZpdGF0aW9uUmVxdWVzdBoULmJncy5wcm90b2NvbC5Ob0RhdGEiBoL5KwII",
            "NRJwCg1HZXRJbnZpdGF0aW9uEiouYmdzLnByb3RvY29sLmNsdWIudjEuR2V0",
            "SW52aXRhdGlvblJlcXVlc3QaKy5iZ3MucHJvdG9jb2wuY2x1Yi52MS5HZXRJ",
            "bnZpdGF0aW9uUmVzcG9uc2UiBoL5KwIINhJzCg5HZXRJbnZpdGF0aW9ucxIr",
            "LmJncy5wcm90b2NvbC5jbHViLnYxLkdldEludml0YXRpb25zUmVxdWVzdBos",
            "LmJncy5wcm90b2NvbC5jbHViLnYxLkdldEludml0YXRpb25zUmVzcG9uc2Ui",
            "BoL5KwIINxJbCg5TZW5kU3VnZ2VzdGlvbhIrLmJncy5wcm90b2NvbC5jbHVi",
            "LnYxLlNlbmRTdWdnZXN0aW9uUmVxdWVzdBoULmJncy5wcm90b2NvbC5Ob0Rh",
            "dGEiBoL5KwIIPBJfChBBY2NlcHRTdWdnZXN0aW9uEi0uYmdzLnByb3RvY29s",
            "LmNsdWIudjEuQWNjZXB0U3VnZ2VzdGlvblJlcXVlc3QaFC5iZ3MucHJvdG9j",
            "b2wuTm9EYXRhIgaC+SsCCD0SYQoRRGVjbGluZVN1Z2dlc3Rpb24SLi5iZ3Mu",
            "cHJvdG9jb2wuY2x1Yi52MS5EZWNsaW5lU3VnZ2VzdGlvblJlcXVlc3QaFC5i",
            "Z3MucHJvdG9jb2wuTm9EYXRhIgaC+SsCCD4ScAoNR2V0U3VnZ2VzdGlvbhIq",
            "LmJncy5wcm90b2NvbC5jbHViLnYxLkdldFN1Z2dlc3Rpb25SZXF1ZXN0Gisu",
            "YmdzLnByb3RvY29sLmNsdWIudjEuR2V0U3VnZ2VzdGlvblJlc3BvbnNlIgaC",
            "+SsCCD8ScwoOR2V0U3VnZ2VzdGlvbnMSKy5iZ3MucHJvdG9jb2wuY2x1Yi52",
            "MS5HZXRTdWdnZXN0aW9uc1JlcXVlc3QaLC5iZ3MucHJvdG9jb2wuY2x1Yi52",
            "MS5HZXRTdWdnZXN0aW9uc1Jlc3BvbnNlIgaC+SsCCEASbQoMQ3JlYXRlVGlj",
            "a2V0EikuYmdzLnByb3RvY29sLmNsdWIudjEuQ3JlYXRlVGlja2V0UmVxdWVz",
            "dBoqLmJncy5wcm90b2NvbC5jbHViLnYxLkNyZWF0ZVRpY2tldFJlc3BvbnNl",
            "IgaC+SsCCEYSWQoNRGVzdHJveVRpY2tldBIqLmJncy5wcm90b2NvbC5jbHVi",
            "LnYxLkRlc3Ryb3lUaWNrZXRSZXF1ZXN0GhQuYmdzLnByb3RvY29sLk5vRGF0",
            "YSIGgvkrAghHElcKDFJlZGVlbVRpY2tldBIpLmJncy5wcm90b2NvbC5jbHVi",
            "LnYxLlJlZGVlbVRpY2tldFJlcXVlc3QaFC5iZ3MucHJvdG9jb2wuTm9EYXRh",
            "IgaC+SsCCEgSZAoJR2V0VGlja2V0EiYuYmdzLnByb3RvY29sLmNsdWIudjEu",
            "R2V0VGlja2V0UmVxdWVzdBonLmJncy5wcm90b2NvbC5jbHViLnYxLkdldFRp",
            "Y2tldFJlc3BvbnNlIgaC+SsCCEkSZwoKR2V0VGlja2V0cxInLmJncy5wcm90",
            "b2NvbC5jbHViLnYxLkdldFRpY2tldHNSZXF1ZXN0GiguYmdzLnByb3RvY29s",
            "LmNsdWIudjEuR2V0VGlja2V0c1Jlc3BvbnNlIgaC+SsCCEoSSwoGQWRkQmFu",
            "EiMuYmdzLnByb3RvY29sLmNsdWIudjEuQWRkQmFuUmVxdWVzdBoULmJncy5w",
            "cm90b2NvbC5Ob0RhdGEiBoL5KwIIUBJRCglSZW1vdmVCYW4SJi5iZ3MucHJv",
            "dG9jb2wuY2x1Yi52MS5SZW1vdmVCYW5SZXF1ZXN0GhQuYmdzLnByb3RvY29s",
            "Lk5vRGF0YSIGgvkrAghRElsKBkdldEJhbhIjLmJncy5wcm90b2NvbC5jbHVi",
            "LnYxLkdldEJhblJlcXVlc3QaJC5iZ3MucHJvdG9jb2wuY2x1Yi52MS5HZXRC",
            "YW5SZXNwb25zZSIGgvkrAghSEl4KB0dldEJhbnMSJC5iZ3MucHJvdG9jb2wu",
            "Y2x1Yi52MS5HZXRCYW5zUmVxdWVzdBolLmJncy5wcm90b2NvbC5jbHViLnYx",
            "LkdldEJhbnNSZXNwb25zZSIGgvkrAghTEl0KD1N1YnNjcmliZVN0cmVhbRIs",
            "LmJncy5wcm90b2NvbC5jbHViLnYxLlN1YnNjcmliZVN0cmVhbVJlcXVlc3Qa",
            "FC5iZ3MucHJvdG9jb2wuTm9EYXRhIgaC+SsCCGQSYQoRVW5zdWJzY3JpYmVT",
            "dHJlYW0SLi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5VbnN1YnNjcmliZVN0cmVh",
            "bVJlcXVlc3QaFC5iZ3MucHJvdG9jb2wuTm9EYXRhIgaC+SsCCGUSbQoMQ3Jl",
            "YXRlU3RyZWFtEikuYmdzLnByb3RvY29sLmNsdWIudjEuQ3JlYXRlU3RyZWFt",
            "UmVxdWVzdBoqLmJncy5wcm90b2NvbC5jbHViLnYxLkNyZWF0ZVN0cmVhbVJl",
            "c3BvbnNlIgaC+SsCCGYSWQoNRGVzdHJveVN0cmVhbRIqLmJncy5wcm90b2Nv",
            "bC5jbHViLnYxLkRlc3Ryb3lTdHJlYW1SZXF1ZXN0GhQuYmdzLnByb3RvY29s",
            "Lk5vRGF0YSIGgvkrAghnEmQKCUdldFN0cmVhbRImLmJncy5wcm90b2NvbC5j",
            "bHViLnYxLkdldFN0cmVhbVJlcXVlc3QaJy5iZ3MucHJvdG9jb2wuY2x1Yi52",
            "MS5HZXRTdHJlYW1SZXNwb25zZSIGgvkrAghoEmcKCkdldFN0cmVhbXMSJy5i",
            "Z3MucHJvdG9jb2wuY2x1Yi52MS5HZXRTdHJlYW1zUmVxdWVzdBooLmJncy5w",
            "cm90b2NvbC5jbHViLnYxLkdldFN0cmVhbXNSZXNwb25zZSIGgvkrAghpEmEK",
            "EVVwZGF0ZVN0cmVhbVN0YXRlEi4uYmdzLnByb3RvY29sLmNsdWIudjEuVXBk",
            "YXRlU3RyZWFtU3RhdGVSZXF1ZXN0GhQuYmdzLnByb3RvY29sLk5vRGF0YSIG",
            "gvkrAghqElsKDlNldFN0cmVhbUZvY3VzEisuYmdzLnByb3RvY29sLmNsdWIu",
            "djEuU2V0U3RyZWFtRm9jdXNSZXF1ZXN0GhQuYmdzLnByb3RvY29sLk5vRGF0",
            "YSIGgvkrAghrEoIBChNHZXRTdHJlYW1Wb2ljZVRva2VuEjAuYmdzLnByb3Rv",
            "Y29sLmNsdWIudjEuR2V0U3RyZWFtVm9pY2VUb2tlblJlcXVlc3QaMS5iZ3Mu",
            "cHJvdG9jb2wuY2x1Yi52MS5HZXRTdHJlYW1Wb2ljZVRva2VuUmVzcG9uc2Ui",
            "BoL5KwIIbBJlChNLaWNrRnJvbVN0cmVhbVZvaWNlEjAuYmdzLnByb3RvY29s",
            "LmNsdWIudjEuS2lja0Zyb21TdHJlYW1Wb2ljZVJlcXVlc3QaFC5iZ3MucHJv",
            "dG9jb2wuTm9EYXRhIgaC+SsCCG0ScQoNQ3JlYXRlTWVzc2FnZRIqLmJncy5w",
            "cm90b2NvbC5jbHViLnYxLkNyZWF0ZU1lc3NhZ2VSZXF1ZXN0GisuYmdzLnBy",
            "b3RvY29sLmNsdWIudjEuQ3JlYXRlTWVzc2FnZVJlc3BvbnNlIgeC+SsDCJYB",
            "EnQKDkRlc3Ryb3lNZXNzYWdlEisuYmdzLnByb3RvY29sLmNsdWIudjEuRGVz",
            "dHJveU1lc3NhZ2VSZXF1ZXN0GiwuYmdzLnByb3RvY29sLmNsdWIudjEuRGVz",
            "dHJveU1lc3NhZ2VSZXNwb25zZSIHgvkrAwiXARJrCgtFZGl0TWVzc2FnZRIo",
            "LmJncy5wcm90b2NvbC5jbHViLnYxLkVkaXRNZXNzYWdlUmVxdWVzdBopLmJn",
            "cy5wcm90b2NvbC5jbHViLnYxLkVkaXRNZXNzYWdlUmVzcG9uc2UiB4L5KwMI",
            "mAESYAoQU2V0TWVzc2FnZVBpbm5lZBItLmJncy5wcm90b2NvbC5jbHViLnYx",
            "LlNldE1lc3NhZ2VQaW5uZWRSZXF1ZXN0GhQuYmdzLnByb3RvY29sLk5vRGF0",
            "YSIHgvkrAwiZARJkChJTZXRUeXBpbmdJbmRpY2F0b3ISLy5iZ3MucHJvdG9j",
            "b2wuY2x1Yi52MS5TZXRUeXBpbmdJbmRpY2F0b3JSZXF1ZXN0GhQuYmdzLnBy",
            "b3RvY29sLk5vRGF0YSIHgvkrAwiaARJqChVBZHZhbmNlU3RyZWFtVmlld1Rp",
            "bWUSMi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5BZHZhbmNlU3RyZWFtVmlld1Rp",
            "bWVSZXF1ZXN0GhQuYmdzLnByb3RvY29sLk5vRGF0YSIHgvkrAwibARJ6ChBH",
            "ZXRTdHJlYW1IaXN0b3J5Ei0uYmdzLnByb3RvY29sLmNsdWIudjEuR2V0U3Ry",
            "ZWFtSGlzdG9yeVJlcXVlc3QaLi5iZ3MucHJvdG9jb2wuY2x1Yi52MS5HZXRT",
            "dHJlYW1IaXN0b3J5UmVzcG9uc2UiB4L5KwMInAESegoQR2V0U3RyZWFtTWVz",
            "c2FnZRItLmJncy5wcm90b2NvbC5jbHViLnYxLkdldFN0cmVhbU1lc3NhZ2VS",
            "ZXF1ZXN0Gi4uYmdzLnByb3RvY29sLmNsdWIudjEuR2V0U3RyZWFtTWVzc2Fn",
            "ZVJlc3BvbnNlIgeC+SsDCJ0BGjWC+SspCiFibmV0LnByb3RvY29sLmNsdWIu",
            "djEuQ2x1YlNlcnZpY2UqBGNsdWKK+SsEEAEYAUIFSAKAAQBQAA=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { WowPacketParserModule.V10_0_0_46181.Protos.V10_2_0_52649.Bgs.Protocol.Club.V1.ClubRequestReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, null));
    }
    #endregion

  }
}

#endregion Designer generated code