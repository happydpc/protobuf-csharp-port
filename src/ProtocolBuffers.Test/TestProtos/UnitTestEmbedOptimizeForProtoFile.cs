// Generated by the protocol buffer compiler.  DO NOT EDIT!

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace Google.ProtocolBuffers.TestProtos {
  
  public static partial class UnitTestEmbedOptimizeForProtoFile {
  
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static readonly pbd::FileDescriptor descriptor = pbd::FileDescriptor.InternalBuildGeneratedFileFrom(
        global::System.Convert.FromBase64String(
        "CjFnb29nbGUvcHJvdG9idWYvdW5pdHRlc3RfZW1iZWRfb3B0aW1pemVfZm9y" + 
        "LnByb3RvEhFwcm90b2J1Zl91bml0dGVzdBokZ29vZ2xlL3Byb3RvYnVmL2Nz" + 
        "aGFycF9vcHRpb25zLnByb3RvGitnb29nbGUvcHJvdG9idWYvdW5pdHRlc3Rf" + 
        "b3B0aW1pemVfZm9yLnByb3RvIqEBChlUZXN0RW1iZWRPcHRpbWl6ZWRGb3JT" + 
        "aXplEkEKEG9wdGlvbmFsX21lc3NhZ2UYASABKAsyJy5wcm90b2J1Zl91bml0" + 
        "dGVzdC5UZXN0T3B0aW1pemVkRm9yU2l6ZRJBChByZXBlYXRlZF9tZXNzYWdl" + 
        "GAIgAygLMicucHJvdG9idWZfdW5pdHRlc3QuVGVzdE9wdGltaXplZEZvclNp" + 
        "emVCS0gBwj5GCiFHb29nbGUuUHJvdG9jb2xCdWZmZXJzLlRlc3RQcm90b3MS" + 
        "IVVuaXRUZXN0RW1iZWRPcHRpbWl6ZUZvclByb3RvRmlsZQ=="),
        new pbd::FileDescriptor[] {
          global::Google.ProtocolBuffers.DescriptorProtos.CSharpOptions.Descriptor, 
          global::Google.ProtocolBuffers.TestProtos.UnitTestOptimizeForProtoFile.Descriptor, 
        });
    #endregion
    
    #region Static variables
    internal static readonly pbd::MessageDescriptor internal__static_protobuf_unittest_TestEmbedOptimizedForSize__Descriptor
        = Descriptor.MessageTypes[0];
    internal static pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.TestProtos.TestEmbedOptimizedForSize, global::Google.ProtocolBuffers.TestProtos.TestEmbedOptimizedForSize.Builder> internal__static_protobuf_unittest_TestEmbedOptimizedForSize__FieldAccessorTable
        = new pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.TestProtos.TestEmbedOptimizedForSize, global::Google.ProtocolBuffers.TestProtos.TestEmbedOptimizedForSize.Builder>(internal__static_protobuf_unittest_TestEmbedOptimizedForSize__Descriptor,
            new string[] { "OptionalMessage", "RepeatedMessage", });
    #endregion
  }
  #region Messages
  public sealed partial class TestEmbedOptimizedForSize : pb::GeneratedMessage<TestEmbedOptimizedForSize, TestEmbedOptimizedForSize.Builder> {
    private static readonly TestEmbedOptimizedForSize defaultInstance = new Builder().BuildPartial();
    public static TestEmbedOptimizedForSize DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override TestEmbedOptimizedForSize DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override TestEmbedOptimizedForSize ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::Google.ProtocolBuffers.TestProtos.UnitTestEmbedOptimizeForProtoFile.internal__static_protobuf_unittest_TestEmbedOptimizedForSize__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<TestEmbedOptimizedForSize, TestEmbedOptimizedForSize.Builder> InternalFieldAccessors {
      get { return global::Google.ProtocolBuffers.TestProtos.UnitTestEmbedOptimizeForProtoFile.internal__static_protobuf_unittest_TestEmbedOptimizedForSize__FieldAccessorTable; }
    }
    
    private bool hasOptionalMessage;
    private global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize optionalMessage_ = global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize.DefaultInstance;
    public bool HasOptionalMessage {
      get { return hasOptionalMessage; }
    }
    public global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize OptionalMessage {
      get { return optionalMessage_; }
    }
    
    private pbc::PopsicleList<global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize> repeatedMessage_ = new pbc::PopsicleList<global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize>();
    public scg::IList<global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize> RepeatedMessageList {
      get { return repeatedMessage_; }
    }
    public int RepeatedMessageCount {
      get { return repeatedMessage_.Count; }
    }
    public global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize GetRepeatedMessage(int index) {
      return repeatedMessage_[index];
    }
    
    public override bool IsInitialized {
      get {
        if (HasOptionalMessage) {
          if (!OptionalMessage.IsInitialized) return false;
        }
        foreach (global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize element in RepeatedMessageList) {
          if (!element.IsInitialized) return false;
        }
        return true;
      }
    }
    
    public override void WriteTo(pb::CodedOutputStream output) {
      if (HasOptionalMessage) {
        output.WriteMessage(1, OptionalMessage);
      }
      foreach (global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize element in RepeatedMessageList) {
        output.WriteMessage(2, element);
      }
      UnknownFields.WriteTo(output);
    }
    
    private int memoizedSerializedSize = -1;
    public override int SerializedSize {
      get {
        int size = memoizedSerializedSize;
        if (size != -1) return size;
        
        size = 0;
        if (HasOptionalMessage) {
          size += pb::CodedOutputStream.ComputeMessageSize(1, OptionalMessage);
        }
        foreach (global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize element in RepeatedMessageList) {
          size += pb::CodedOutputStream.ComputeMessageSize(2, element);
        }
        size += UnknownFields.SerializedSize;
        memoizedSerializedSize = size;
        return size;
      }
    }
    
    public static TestEmbedOptimizedForSize ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static TestEmbedOptimizedForSize ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static TestEmbedOptimizedForSize ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static TestEmbedOptimizedForSize ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static TestEmbedOptimizedForSize ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static TestEmbedOptimizedForSize ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static TestEmbedOptimizedForSize ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static TestEmbedOptimizedForSize ParseFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder ToBuilder() { return CreateBuilder(this); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(TestEmbedOptimizedForSize prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::GeneratedBuilder<TestEmbedOptimizedForSize, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      TestEmbedOptimizedForSize result = new TestEmbedOptimizedForSize();
      
      protected override TestEmbedOptimizedForSize MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new TestEmbedOptimizedForSize();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return TestEmbedOptimizedForSize.Descriptor; }
      }
      
      public override TestEmbedOptimizedForSize DefaultInstanceForType {
        get { return TestEmbedOptimizedForSize.DefaultInstance; }
      }
      
      public override TestEmbedOptimizedForSize BuildPartial() {
        result.repeatedMessage_.MakeReadOnly();
        TestEmbedOptimizedForSize returnMe = result;
        result = null;
        return returnMe;
      }
      
      public override Builder MergeFrom(pb::IMessage other) {
        if (other is TestEmbedOptimizedForSize) {
          return MergeFrom((TestEmbedOptimizedForSize) other);
        } else {
          base.MergeFrom(other);
          return this;
        }
      }
      
      public override Builder MergeFrom(TestEmbedOptimizedForSize other) {
        if (other == TestEmbedOptimizedForSize.DefaultInstance) return this;
        if (other.HasOptionalMessage) {
          MergeOptionalMessage(other.OptionalMessage);
        }
        if (other.repeatedMessage_.Count != 0) {
          base.AddRange(other.repeatedMessage_, result.repeatedMessage_);
        }
        this.MergeUnknownFields(other.UnknownFields);
        return this;
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input) {
        return MergeFrom(input, pb::ExtensionRegistry.Empty);
      }
      
      public override Builder MergeFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
        pb::UnknownFieldSet.Builder unknownFields = pb::UnknownFieldSet.CreateBuilder(this.UnknownFields);
        while (true) {
          uint tag = input.ReadTag();
          switch (tag) {
            case 0: {
              this.UnknownFields = unknownFields.Build();
              return this;
            }
            default: {
              if (!ParseUnknownField(input, unknownFields, extensionRegistry, tag)) {
                this.UnknownFields = unknownFields.Build();
                return this;
              }
              break;
            }
            case 10: {
              global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize.Builder subBuilder = global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize.CreateBuilder();
              if (HasOptionalMessage) {
                subBuilder.MergeFrom(OptionalMessage);
              }
              input.ReadMessage(subBuilder, extensionRegistry);
              OptionalMessage = subBuilder.BuildPartial();
              break;
            }
            case 18: {
              global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize.Builder subBuilder = global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize.CreateBuilder();
              input.ReadMessage(subBuilder, extensionRegistry);
              AddRepeatedMessage(subBuilder.BuildPartial());
              break;
            }
          }
        }
      }
      
      
      public bool HasOptionalMessage {
       get { return result.HasOptionalMessage; }
      }
      public global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize OptionalMessage {
        get { return result.OptionalMessage; }
        set { SetOptionalMessage(value); }
      }
      public Builder SetOptionalMessage(global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.hasOptionalMessage = true;
        result.optionalMessage_ = value;
        return this;
      }
      public Builder SetOptionalMessage(global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        result.hasOptionalMessage = true;
        result.optionalMessage_ = builderForValue.Build();
        return this;
      }
      public Builder MergeOptionalMessage(global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        if (result.HasOptionalMessage &&
            result.optionalMessage_ != global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize.DefaultInstance) {
            result.optionalMessage_ = global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize.CreateBuilder(result.optionalMessage_).MergeFrom(value).BuildPartial();
        } else {
          result.optionalMessage_ = value;
        }
        result.hasOptionalMessage = true;
        return this;
      }
      public Builder ClearOptionalMessage() {
        result.hasOptionalMessage = false;
        result.optionalMessage_ = global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize.DefaultInstance;
        return this;
      }
      
      public scg::IList<global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize> RepeatedMessageList {
        get { return result.repeatedMessage_; }
      }
      public int RepeatedMessageCount {
        get { return result.RepeatedMessageCount; }
      }
      public global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize GetRepeatedMessage(int index) {
        return result.GetRepeatedMessage(index);
      }
      public Builder SetRepeatedMessage(int index, global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.repeatedMessage_[index] = value;
        return this;
      }
      public Builder SetRepeatedMessage(int index, global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        result.repeatedMessage_[index] = builderForValue.Build();
        return this;
      }
      public Builder AddRepeatedMessage(global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize value) {
        pb::ThrowHelper.ThrowIfNull(value, "value");
        result.repeatedMessage_.Add(value);
        return this;
      }
      public Builder AddRepeatedMessage(global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize.Builder builderForValue) {
        pb::ThrowHelper.ThrowIfNull(builderForValue, "builderForValue");
        result.repeatedMessage_.Add(builderForValue.Build());
        return this;
      }
      public Builder AddRangeRepeatedMessage(scg::IEnumerable<global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize> values) {
        base.AddRange(values, result.repeatedMessage_);
        return this;
      }
      public Builder ClearRepeatedMessage() {
        result.repeatedMessage_.Clear();
        return this;
      }
    }
  }
  
  #endregion
  
}
