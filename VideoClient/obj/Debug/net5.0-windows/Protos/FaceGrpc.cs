// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/face.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace VideoClient {
  /// <summary>
  /// The greeting service definition.
  /// </summary>
  public static partial class FaceRecongnise
  {
    static readonly string __ServiceName = "greet.FaceRecongnise";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::VideoClient.FaceRequest> __Marshaller_greet_FaceRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::VideoClient.FaceRequest.Parser));
    static readonly grpc::Marshaller<global::VideoClient.FaceReply> __Marshaller_greet_FaceReply = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::VideoClient.FaceReply.Parser));

    static readonly grpc::Method<global::VideoClient.FaceRequest, global::VideoClient.FaceReply> __Method_RecongnizationByFace = new grpc::Method<global::VideoClient.FaceRequest, global::VideoClient.FaceReply>(
        grpc::MethodType.DuplexStreaming,
        __ServiceName,
        "RecongnizationByFace",
        __Marshaller_greet_FaceRequest,
        __Marshaller_greet_FaceReply);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::VideoClient.FaceReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for FaceRecongnise</summary>
    public partial class FaceRecongniseClient : grpc::ClientBase<FaceRecongniseClient>
    {
      /// <summary>Creates a new client for FaceRecongnise</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public FaceRecongniseClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for FaceRecongnise that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public FaceRecongniseClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected FaceRecongniseClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected FaceRecongniseClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual grpc::AsyncDuplexStreamingCall<global::VideoClient.FaceRequest, global::VideoClient.FaceReply> RecongnizationByFace(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return RecongnizationByFace(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncDuplexStreamingCall<global::VideoClient.FaceRequest, global::VideoClient.FaceReply> RecongnizationByFace(grpc::CallOptions options)
      {
        return CallInvoker.AsyncDuplexStreamingCall(__Method_RecongnizationByFace, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override FaceRecongniseClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new FaceRecongniseClient(configuration);
      }
    }

  }
}
#endregion
