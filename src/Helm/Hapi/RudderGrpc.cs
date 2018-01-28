// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: hapi/rudder/rudder.proto
// </auto-generated>
// Original file comments:
// Copyright 2017 The Kubernetes Authors All rights reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
#pragma warning disable 1591
#region Designer generated code

using System;
using System.Threading;
using System.Threading.Tasks;
using grpc = global::Grpc.Core;

namespace Hapi.Services.Rudder {
  public static partial class ReleaseModuleService
  {
    static readonly string __ServiceName = "hapi.services.rudder.ReleaseModuleService";

    static readonly grpc::Marshaller<global::Hapi.Services.Rudder.VersionReleaseRequest> __Marshaller_VersionReleaseRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Hapi.Services.Rudder.VersionReleaseRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Hapi.Services.Rudder.VersionReleaseResponse> __Marshaller_VersionReleaseResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Hapi.Services.Rudder.VersionReleaseResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Hapi.Services.Rudder.InstallReleaseRequest> __Marshaller_InstallReleaseRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Hapi.Services.Rudder.InstallReleaseRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Hapi.Services.Rudder.InstallReleaseResponse> __Marshaller_InstallReleaseResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Hapi.Services.Rudder.InstallReleaseResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Hapi.Services.Rudder.DeleteReleaseRequest> __Marshaller_DeleteReleaseRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Hapi.Services.Rudder.DeleteReleaseRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Hapi.Services.Rudder.DeleteReleaseResponse> __Marshaller_DeleteReleaseResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Hapi.Services.Rudder.DeleteReleaseResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Hapi.Services.Rudder.RollbackReleaseRequest> __Marshaller_RollbackReleaseRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Hapi.Services.Rudder.RollbackReleaseRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Hapi.Services.Rudder.RollbackReleaseResponse> __Marshaller_RollbackReleaseResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Hapi.Services.Rudder.RollbackReleaseResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Hapi.Services.Rudder.UpgradeReleaseRequest> __Marshaller_UpgradeReleaseRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Hapi.Services.Rudder.UpgradeReleaseRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Hapi.Services.Rudder.UpgradeReleaseResponse> __Marshaller_UpgradeReleaseResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Hapi.Services.Rudder.UpgradeReleaseResponse.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Hapi.Services.Rudder.ReleaseStatusRequest> __Marshaller_ReleaseStatusRequest = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Hapi.Services.Rudder.ReleaseStatusRequest.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Hapi.Services.Rudder.ReleaseStatusResponse> __Marshaller_ReleaseStatusResponse = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Hapi.Services.Rudder.ReleaseStatusResponse.Parser.ParseFrom);

    static readonly grpc::Method<global::Hapi.Services.Rudder.VersionReleaseRequest, global::Hapi.Services.Rudder.VersionReleaseResponse> __Method_Version = new grpc::Method<global::Hapi.Services.Rudder.VersionReleaseRequest, global::Hapi.Services.Rudder.VersionReleaseResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "Version",
        __Marshaller_VersionReleaseRequest,
        __Marshaller_VersionReleaseResponse);

    static readonly grpc::Method<global::Hapi.Services.Rudder.InstallReleaseRequest, global::Hapi.Services.Rudder.InstallReleaseResponse> __Method_InstallRelease = new grpc::Method<global::Hapi.Services.Rudder.InstallReleaseRequest, global::Hapi.Services.Rudder.InstallReleaseResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "InstallRelease",
        __Marshaller_InstallReleaseRequest,
        __Marshaller_InstallReleaseResponse);

    static readonly grpc::Method<global::Hapi.Services.Rudder.DeleteReleaseRequest, global::Hapi.Services.Rudder.DeleteReleaseResponse> __Method_DeleteRelease = new grpc::Method<global::Hapi.Services.Rudder.DeleteReleaseRequest, global::Hapi.Services.Rudder.DeleteReleaseResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteRelease",
        __Marshaller_DeleteReleaseRequest,
        __Marshaller_DeleteReleaseResponse);

    static readonly grpc::Method<global::Hapi.Services.Rudder.RollbackReleaseRequest, global::Hapi.Services.Rudder.RollbackReleaseResponse> __Method_RollbackRelease = new grpc::Method<global::Hapi.Services.Rudder.RollbackReleaseRequest, global::Hapi.Services.Rudder.RollbackReleaseResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "RollbackRelease",
        __Marshaller_RollbackReleaseRequest,
        __Marshaller_RollbackReleaseResponse);

    static readonly grpc::Method<global::Hapi.Services.Rudder.UpgradeReleaseRequest, global::Hapi.Services.Rudder.UpgradeReleaseResponse> __Method_UpgradeRelease = new grpc::Method<global::Hapi.Services.Rudder.UpgradeReleaseRequest, global::Hapi.Services.Rudder.UpgradeReleaseResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpgradeRelease",
        __Marshaller_UpgradeReleaseRequest,
        __Marshaller_UpgradeReleaseResponse);

    static readonly grpc::Method<global::Hapi.Services.Rudder.ReleaseStatusRequest, global::Hapi.Services.Rudder.ReleaseStatusResponse> __Method_ReleaseStatus = new grpc::Method<global::Hapi.Services.Rudder.ReleaseStatusRequest, global::Hapi.Services.Rudder.ReleaseStatusResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReleaseStatus",
        __Marshaller_ReleaseStatusRequest,
        __Marshaller_ReleaseStatusResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Hapi.Services.Rudder.RudderReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ReleaseModuleService</summary>
    public abstract partial class ReleaseModuleServiceBase
    {
      public virtual global::System.Threading.Tasks.Task<global::Hapi.Services.Rudder.VersionReleaseResponse> Version(global::Hapi.Services.Rudder.VersionReleaseRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// InstallRelease requests installation of a chart as a new release.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Hapi.Services.Rudder.InstallReleaseResponse> InstallRelease(global::Hapi.Services.Rudder.InstallReleaseRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// DeleteRelease requests deletion of a named release.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Hapi.Services.Rudder.DeleteReleaseResponse> DeleteRelease(global::Hapi.Services.Rudder.DeleteReleaseRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// RollbackRelease rolls back a release to a previous version.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Hapi.Services.Rudder.RollbackReleaseResponse> RollbackRelease(global::Hapi.Services.Rudder.RollbackReleaseRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// UpgradeRelease updates release content.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Hapi.Services.Rudder.UpgradeReleaseResponse> UpgradeRelease(global::Hapi.Services.Rudder.UpgradeReleaseRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      /// <summary>
      /// ReleaseStatus retrieves release status.
      /// </summary>
      /// <param name="request">The request received from the client.</param>
      /// <param name="context">The context of the server-side call handler being invoked.</param>
      /// <returns>The response to send back to the client (wrapped by a task).</returns>
      public virtual global::System.Threading.Tasks.Task<global::Hapi.Services.Rudder.ReleaseStatusResponse> ReleaseStatus(global::Hapi.Services.Rudder.ReleaseStatusRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Client for ReleaseModuleService</summary>
    public partial class ReleaseModuleServiceClient : grpc::ClientBase<ReleaseModuleServiceClient>
    {
      /// <summary>Creates a new client for ReleaseModuleService</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public ReleaseModuleServiceClient(grpc::Channel channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for ReleaseModuleService that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public ReleaseModuleServiceClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected ReleaseModuleServiceClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected ReleaseModuleServiceClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      public virtual global::Hapi.Services.Rudder.VersionReleaseResponse Version(global::Hapi.Services.Rudder.VersionReleaseRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return Version(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual global::Hapi.Services.Rudder.VersionReleaseResponse Version(global::Hapi.Services.Rudder.VersionReleaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_Version, null, options, request);
      }
      public virtual grpc::AsyncUnaryCall<global::Hapi.Services.Rudder.VersionReleaseResponse> VersionAsync(global::Hapi.Services.Rudder.VersionReleaseRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return VersionAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncUnaryCall<global::Hapi.Services.Rudder.VersionReleaseResponse> VersionAsync(global::Hapi.Services.Rudder.VersionReleaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_Version, null, options, request);
      }
      /// <summary>
      /// InstallRelease requests installation of a chart as a new release.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Hapi.Services.Rudder.InstallReleaseResponse InstallRelease(global::Hapi.Services.Rudder.InstallReleaseRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return InstallRelease(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// InstallRelease requests installation of a chart as a new release.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Hapi.Services.Rudder.InstallReleaseResponse InstallRelease(global::Hapi.Services.Rudder.InstallReleaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_InstallRelease, null, options, request);
      }
      /// <summary>
      /// InstallRelease requests installation of a chart as a new release.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Hapi.Services.Rudder.InstallReleaseResponse> InstallReleaseAsync(global::Hapi.Services.Rudder.InstallReleaseRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return InstallReleaseAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// InstallRelease requests installation of a chart as a new release.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Hapi.Services.Rudder.InstallReleaseResponse> InstallReleaseAsync(global::Hapi.Services.Rudder.InstallReleaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_InstallRelease, null, options, request);
      }
      /// <summary>
      /// DeleteRelease requests deletion of a named release.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Hapi.Services.Rudder.DeleteReleaseResponse DeleteRelease(global::Hapi.Services.Rudder.DeleteReleaseRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteRelease(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// DeleteRelease requests deletion of a named release.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Hapi.Services.Rudder.DeleteReleaseResponse DeleteRelease(global::Hapi.Services.Rudder.DeleteReleaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_DeleteRelease, null, options, request);
      }
      /// <summary>
      /// DeleteRelease requests deletion of a named release.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Hapi.Services.Rudder.DeleteReleaseResponse> DeleteReleaseAsync(global::Hapi.Services.Rudder.DeleteReleaseRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return DeleteReleaseAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// DeleteRelease requests deletion of a named release.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Hapi.Services.Rudder.DeleteReleaseResponse> DeleteReleaseAsync(global::Hapi.Services.Rudder.DeleteReleaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_DeleteRelease, null, options, request);
      }
      /// <summary>
      /// RollbackRelease rolls back a release to a previous version.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Hapi.Services.Rudder.RollbackReleaseResponse RollbackRelease(global::Hapi.Services.Rudder.RollbackReleaseRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RollbackRelease(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// RollbackRelease rolls back a release to a previous version.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Hapi.Services.Rudder.RollbackReleaseResponse RollbackRelease(global::Hapi.Services.Rudder.RollbackReleaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_RollbackRelease, null, options, request);
      }
      /// <summary>
      /// RollbackRelease rolls back a release to a previous version.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Hapi.Services.Rudder.RollbackReleaseResponse> RollbackReleaseAsync(global::Hapi.Services.Rudder.RollbackReleaseRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return RollbackReleaseAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// RollbackRelease rolls back a release to a previous version.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Hapi.Services.Rudder.RollbackReleaseResponse> RollbackReleaseAsync(global::Hapi.Services.Rudder.RollbackReleaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_RollbackRelease, null, options, request);
      }
      /// <summary>
      /// UpgradeRelease updates release content.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Hapi.Services.Rudder.UpgradeReleaseResponse UpgradeRelease(global::Hapi.Services.Rudder.UpgradeReleaseRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpgradeRelease(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// UpgradeRelease updates release content.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Hapi.Services.Rudder.UpgradeReleaseResponse UpgradeRelease(global::Hapi.Services.Rudder.UpgradeReleaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_UpgradeRelease, null, options, request);
      }
      /// <summary>
      /// UpgradeRelease updates release content.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Hapi.Services.Rudder.UpgradeReleaseResponse> UpgradeReleaseAsync(global::Hapi.Services.Rudder.UpgradeReleaseRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return UpgradeReleaseAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// UpgradeRelease updates release content.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Hapi.Services.Rudder.UpgradeReleaseResponse> UpgradeReleaseAsync(global::Hapi.Services.Rudder.UpgradeReleaseRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_UpgradeRelease, null, options, request);
      }
      /// <summary>
      /// ReleaseStatus retrieves release status.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Hapi.Services.Rudder.ReleaseStatusResponse ReleaseStatus(global::Hapi.Services.Rudder.ReleaseStatusRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ReleaseStatus(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// ReleaseStatus retrieves release status.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Hapi.Services.Rudder.ReleaseStatusResponse ReleaseStatus(global::Hapi.Services.Rudder.ReleaseStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_ReleaseStatus, null, options, request);
      }
      /// <summary>
      /// ReleaseStatus retrieves release status.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Hapi.Services.Rudder.ReleaseStatusResponse> ReleaseStatusAsync(global::Hapi.Services.Rudder.ReleaseStatusRequest request, grpc::Metadata headers = null, DateTime? deadline = null, CancellationToken cancellationToken = default(CancellationToken))
      {
        return ReleaseStatusAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// ReleaseStatus retrieves release status.
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Hapi.Services.Rudder.ReleaseStatusResponse> ReleaseStatusAsync(global::Hapi.Services.Rudder.ReleaseStatusRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_ReleaseStatus, null, options, request);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override ReleaseModuleServiceClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new ReleaseModuleServiceClient(configuration);
      }
    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ReleaseModuleServiceBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_Version, serviceImpl.Version)
          .AddMethod(__Method_InstallRelease, serviceImpl.InstallRelease)
          .AddMethod(__Method_DeleteRelease, serviceImpl.DeleteRelease)
          .AddMethod(__Method_RollbackRelease, serviceImpl.RollbackRelease)
          .AddMethod(__Method_UpgradeRelease, serviceImpl.UpgradeRelease)
          .AddMethod(__Method_ReleaseStatus, serviceImpl.ReleaseStatus).Build();
    }

  }
}
#endregion
