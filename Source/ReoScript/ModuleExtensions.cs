﻿/*****************************************************************************
 * 
 * ReoScript - .NET Script Language Engine
 * 
 * http://www.unvell.com/ReoScript
 *
 * THIS CODE AND INFORMATION IS PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
 * KIND, EITHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
 * IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
 * PURPOSE.
 *
 * This software released under LGPLv3 license.
 * Author: Jing Lu <dujid0@gmail.com>
 * 
 * Copyright (c) 2012-2013 unvell.com, all rights reserved.
 * 
 ****************************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Unvell.ReoScript.Extensions
{
	public interface IModuleLoader
	{
		void LoadModule(ScriptRunningMachine srm);
		void UnloadModule(ScriptRunningMachine srm);
	}

	/// <summary>
	/// Define class as a loader of extension module
	/// </summary>
	[AttributeUsage(AttributeTargets.Class)]
	public class ModuleLoaderAttribute : Attribute
	{
	}
}
