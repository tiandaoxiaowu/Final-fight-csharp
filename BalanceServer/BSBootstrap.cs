﻿using Core.Misc;
using Shared;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Threading;

namespace BalanceServer
{
	static class BSBootstrap
	{
		private const int HEART_BEAT_CD_TICK = 10;

		private static bool _disposed;
		private static InputHandler _inputHandler;

		static int Main( string[] args )
		{
			Console.Title = "BS";

			AssemblyName[] assemblies = Assembly.GetEntryAssembly().GetReferencedAssemblies();
			foreach ( AssemblyName assembly in assemblies )
				Assembly.Load( assembly );

			Logger.Init( File.ReadAllText( @".\Config\BSLogCfg.xml" ), "BS" );

			_inputHandler = new InputHandler();
			_inputHandler.cmdHandler = HandleInput;
			_inputHandler.Start();

			BS bs = BS.instance;
			ErrorCode eResult = bs.Initialize();

			if ( ErrorCode.Success != eResult )
			{
				Logger.Error( $"Initialize BS fail, error code is {eResult}" );
				return 0;
			}

			eResult = bs.Start();
			if ( ErrorCode.Success != eResult )
			{
				Logger.Error( $"Start BS fail, error code is {eResult}" );
				return 0;
			}

			MainLoop();
			_inputHandler.Stop();

			return 0;
		}

		private static void Dispose()
		{
			_disposed = true;
			BS.instance.Dispose();
		}

		private static void MainLoop()
		{
			Stopwatch sw = new Stopwatch();
			sw.Start();
			long lastElapsed = 0;
			while ( !_disposed )
			{
				long elapsed = sw.ElapsedMilliseconds;
				BS.instance.Update( elapsed, elapsed - lastElapsed );
				_inputHandler.ProcessInput();
				lastElapsed = elapsed;
				Thread.Sleep( HEART_BEAT_CD_TICK );
			}
		}

		private static void HandleInput( string cmd )
		{
			switch ( cmd )
			{
				case "exit":
					Dispose();

					break;
				case "cls":
					Console.Clear();
					break;
			}
		}
	}
}
