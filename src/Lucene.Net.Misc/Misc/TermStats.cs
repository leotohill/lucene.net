﻿namespace org.apache.lucene.misc
{

	/*
	 * Licensed to the Apache Software Foundation (ASF) under one or more
	 * contributor license agreements.  See the NOTICE file distributed with
	 * this work for additional information regarding copyright ownership.
	 * The ASF licenses this file to You under the Apache License, Version 2.0
	 * (the "License"); you may not use this file except in compliance with
	 * the License.  You may obtain a copy of the License at
	 *
	 *     http://www.apache.org/licenses/LICENSE-2.0
	 *
	 * Unless required by applicable law or agreed to in writing, software
	 * distributed under the License is distributed on an "AS IS" BASIS,
	 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
	 * See the License for the specific language governing permissions and
	 * limitations under the License.
	 */

	using BytesRef = org.apache.lucene.util.BytesRef;

	/// <summary>
	/// Holder for a term along with its statistics
	/// (<seealso cref="#docFreq"/> and <seealso cref="#totalTermFreq"/>).
	/// </summary>
	public sealed class TermStats
	{
	  public BytesRef termtext;
	  public string field;
	  public int docFreq;
	  public long totalTermFreq;

	  internal TermStats(string field, BytesRef termtext, int df, long tf)
	  {
		this.termtext = BytesRef.deepCopyOf(termtext);
		this.field = field;
		this.docFreq = df;
		this.totalTermFreq = tf;
	  }

	  internal string TermText
	  {
		  get
		  {
			return termtext.utf8ToString();
		  }
	  }

	  public override string ToString()
	  {
		return ("TermStats: term=" + termtext.utf8ToString() + " docFreq=" + docFreq + " totalTermFreq=" + totalTermFreq);
	  }
	}
}