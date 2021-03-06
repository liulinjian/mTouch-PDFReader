//
// mTouch-PDFReader library
// DocumentBookmarkManager.cs (Document bookmarks manager)
//
//  Author:
//       Alexander Matsibarov (macasun) <amatsibarov@gmail.com>
//
//  Copyright (c) 2012 Alexander Matsibarov
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
//

using System;
using System.Collections.Generic;
using mTouchPDFReader.Library.Interfaces;
using mTouchPDFReader.Library.Data.Objects;

namespace mTouchPDFReader.Library.Managers
{
	public class DocumentBookmarkManager : IDocumentBookmarkManager
	{
		#region Logic	
		/// <summary>
		/// Hidden constructor to create instance only from RC.
		/// </summary>
		protected DocumentBookmarkManager()	{}

		/// <summary>
		/// Creates the new <see cref="DocumentBookmark"/> object.
		/// </summary>.
		/// </param>
		public virtual DocumentBookmark GetNew(int docId, string name, int pageNumber)
		{
			return new DocumentBookmark {
				Id = -1,
				DocId = docId, 
				Name = name,
				PageNumber = pageNumber
			};
		}

		/// <summary>
		/// Gets the <see cref="DocumentBookmark"/> list by the <see cref="docId"/>.
		/// </summary>
		/// <param name="docId">The PDF document Id.</param>
		/// <returns>The <see cref="DocumentBookmark"/> objects list.</returns>
		public virtual List<DocumentBookmark> LoadList(int docId)
		{
			return new List<DocumentBookmark>();
		}
		
		/// <summary>
		/// Saves the <see cref="DocumentBookmark"/> object. 
		/// </summary>
		/// <param name="bookmark">The bookmark object.</param>
		public virtual void Save(DocumentBookmark bookmark)
		{
			// Noting
		}	
		
		/// <summary>
		/// Deletes the <see cref="DocumentBookmark"/> object by <see cref="bookmarkId"/>.
		/// </summary>
		/// <param name="bookmarkId">The bookmark id.</param>
		public virtual void Delete(int bookmarkId)
		{
			// Nothing
		}		
		#endregion
	}
}