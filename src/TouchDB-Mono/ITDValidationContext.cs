﻿/**
 * Original iOS version by Jens Alfke
 * Java port by Marty Schoch
 * Ported to C# by John Zablocki
 *
 * Copyright (c) 2012 Couchbase, Inc. All rights reserved.
 *
 * Licensed under the Apache License, Version 2.0 (the "License"); you may not use this file
 * except in compliance with the License. You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software distributed under the
 * License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
 * either express or implied. See the License for the specific language governing permissions
 * and limitations under the License.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TouchDB.Mono
{
	/// <summary>
	/// Context passed into a TDValidationBlock.
	/// </summary>
	public interface ITDValidationContext
	{
		/**
     * 
     */
		TDRevision getCurrentRevision();

		/**
		 * The type of HTTP status to report, if the validate block returns NO.
		 * The default value is 403 ("Forbidden").
		 */
		TDStatus getErrorType();
		void setErrorType(TDStatus status);

		/**
		 * The error message to return in the HTTP response, if the validate block returns NO.
		 * The default value is "invalid document".
		 */
		String getErrorMessage();
		void setErrorMessage(String message);
	}
}