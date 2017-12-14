using System;
using System.Collections.Generic;

namespace Legacy.Models
{
    public partial class TestQuestionNote
    {
        public TestQuestionNote()
        {
            TestQuestionNoteFile = new HashSet<TestQuestionNoteFile>();
        }

        public int TestQuestionNoteId { get; set; }
        public int TestQuestionId { get; set; }
        public int UserId { get; set; }
        public string Style { get; set; }
        public string Text { get; set; }
        public string RangySelection { get; set; }
        public int StartPosition { get; set; }
        public int EndPosition { get; set; }
        public bool IsPublic { get; set; }
        public byte[] OriginalMd5 { get; set; }
        public int? Number { get; set; }
        public DateTime ActionDate { get; set; }
        public bool? IsNote { get; set; }
        public bool? IsHighlight { get; set; }
        public int? HighlightNumber { get; set; }
        public bool? IsPreferendSection { get; set; }
        public string HighlightText { get; set; }
        public int SpecialtyId { get; set; }

        public Specialty Specialty { get; set; }
        public TestQuestion TestQuestion { get; set; }
        public Users User { get; set; }
        public ICollection<TestQuestionNoteFile> TestQuestionNoteFile { get; set; }
    }
}
