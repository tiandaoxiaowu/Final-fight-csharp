﻿using Core.Misc;
using Google.Protobuf;
using Shared;
using Shared.Net;

namespace GateServer.Net
{
	public class M2BSession : CliSession
	{
		protected M2BSession( uint id ) : base( id )
		{
			this.msgCenter.Register( ( int )BSToGS.MsgID.EMsgToGsfromBsAskRegisterRet, this.MsgInitHandler );
			this.msgCenter.Register( ( int )BSToGS.MsgID.EMsgToGsfromBsOneUserLoginToken, this.MsgOneUserLoginTokenHandler );
		}

		protected override void SendInitData()
		{
			Logger.Info( "BS Connected, try to register me." );
			GSToBS.AskRegister askRegister = new GSToBS.AskRegister
			{
				Gsid = GS.instance.gsConfig.n32GSID,
				Listenport = GS.instance.gsConfig.n32GCListenPort
			};
			GS.instance.SendMsgToSession( this.id, askRegister, ( int )GSToBS.MsgID.EMsgToBsfromGsAskRegister );
		}

		protected override void OnRealEstablish()
		{
			Logger.Info( "BS Connected and register ok." );
		}

		protected override void OnClose()
		{
			Logger.Info( "BS DisConnect." );
		}

		#region msg handlers
		private ErrorCode MsgInitHandler( byte[] data, int offset, int size, int msgID )
		{
			this.SetInited( true, true );
			return ErrorCode.Success;
		}

		/// <summary>
		/// BS通知有客户端登陆
		/// </summary>
		private ErrorCode MsgOneUserLoginTokenHandler( byte[] data, int offset, int size, int msgID )
		{
			BSToGS.OneUserLoginToken reportAllClientInf = new BSToGS.OneUserLoginToken();
			reportAllClientInf.MergeFrom( data, offset, size );

			GS.instance.gsStorage.AddUserToken( reportAllClientInf.UserName, reportAllClientInf.Token );
			//回应BS客户端家已经登陆GS
			this.owner.SendMsgToSession( this.id, reportAllClientInf, ( int )GSToBS.MsgID.EMsgToBsfromGsOneUserLoginTokenRet );
			return ErrorCode.Success;
		}
		#endregion
	}
}