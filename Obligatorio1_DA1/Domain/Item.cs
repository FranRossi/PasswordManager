using Obligatorio1_DA1.Exceptions;
using Obligatorio1_DA1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Obligatorio1_DA1.Domain
{
    public abstract class Item
    {
        public const int MaxNoteLength = 250;

        private string _notes;

        public int Id { get; set; }
        public User User { get; set; }
        public string Notes
        {
            get => _notes;
            set
            {
                ValidateNotes(value);
                _notes = value;
            }

        }
        public Category Category { get; set; }

        private void ValidateNotes(string notesToValidate)
        {
            if (notesToValidate != null && !Validator.MaxLengthOfString(notesToValidate, Item.MaxNoteLength))
                throw new ItemNotesTooLongException();
        }
    }
}
