//
// mTouch-PDFReader demo
// MyDocumentNoteManager.cs (Simple document note manager)
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
using System.Linq;
using mTouchPDFReader.Library.Managers;
using mTouchPDFReader.Library.Data.Objects;

namespace mTouchPDFReader.Demo.Library
{
	public class MyDocumentNoteManager : DocumentNoteManager
	{
		#region Fields		
		/// <summary>
		/// The document notes list.
		/// </summary>
		private static List<DocumentNote> _AllNotes;		
		#endregion
		
		#region Logic
		/// <summary>
		/// Hidden constructor to create instance only from RC.
		/// </summary>
		protected MyDocumentNoteManager() {}

		/// <summary>
		/// Static.
		/// </summary>
		static MyDocumentNoteManager()
		{
			_AllNotes = new List<DocumentNote>();
		}
		
		/// <summary>
		/// Gets the <see cref="DocumentNote"/> object by the <see cref="docId"/>.
		/// </summary>
		/// <param name="docId">The PDF document Id.</param>
		/// <returns>The <see cref="DocumentNote"/> object.</returns>
		public override DocumentNote Load(int docId)
		{
			var note = _AllNotes.FirstOrDefault(n => n.DocId == docId);
			if (note == null) {
				note = new DocumentNote { Id = -1, DocId = docId, Note = string.Empty };
			}			
			return note;
		}

		/// <summary>
		/// Saves the see cref="DocumentNote"/> object.
		/// </summary>
		/// <param name="note">The <see cref="DocumentNote"/> object.</param>
		public override void Save(DocumentNote note)
		{
			if (!_AllNotes.Contains(note)) {
				note.Id = _AllNotes.Count + 1;
				_AllNotes.Add(note);
			}
		}		
		#endregion
	}
}

