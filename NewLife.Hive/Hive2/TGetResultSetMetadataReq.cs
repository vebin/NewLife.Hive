using System;
using System.Text;
using Thrift.Protocol;

namespace NewLife.Hive2
{

#if !SILVERLIGHT
    [Serializable]
#endif
    public partial class TGetResultSetMetadataReq : TBase
    {

        public TOperationHandle OperationHandle { get; set; }

        public TGetResultSetMetadataReq()
        {
        }

        public TGetResultSetMetadataReq(TOperationHandle operationHandle) : this()
        {
            OperationHandle = operationHandle;
        }

        public void Read(TProtocol iprot)
        {
            var isset_operationHandle = false;
            TField field;
            iprot.ReadStructBegin();
            while (true)
            {
                field = iprot.ReadFieldBegin();
                if (field.Type == TType.Stop)
                {
                    break;
                }
                switch (field.ID)
                {
                    case 1:
                        if (field.Type == TType.Struct)
                        {
                            OperationHandle = new TOperationHandle();
                            OperationHandle.Read(iprot);
                            isset_operationHandle = true;
                        }
                        else
                        {
                            TProtocolUtil.Skip(iprot, field.Type);
                        }
                        break;
                    default:
                        TProtocolUtil.Skip(iprot, field.Type);
                        break;
                }
                iprot.ReadFieldEnd();
            }
            iprot.ReadStructEnd();
            if (!isset_operationHandle)
                throw new TProtocolException(TProtocolException.INVALID_DATA);
        }

        public void Write(TProtocol oprot)
        {
            var struc = new TStruct("TGetResultSetMetadataReq");
            oprot.WriteStructBegin(struc);
            var field = new TField
            {
                Name = "operationHandle",
                Type = TType.Struct,
                ID = 1
            };
            oprot.WriteFieldBegin(field);
            OperationHandle.Write(oprot);
            oprot.WriteFieldEnd();
            oprot.WriteFieldStop();
            oprot.WriteStructEnd();
        }

        public override String ToString()
        {
            var sb = new StringBuilder("TGetResultSetMetadataReq(");
            sb.Append("OperationHandle: ");
            sb.Append(OperationHandle == null ? "<null>" : OperationHandle.ToString());
            sb.Append(")");
            return sb.ToString();
        }

    }

}
