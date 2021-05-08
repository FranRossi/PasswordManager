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

        private Category _category;
        private string notes;
        public User User { get; set; }
        public string Notes
        {
            get => notes;
            set
            {
                ValidateNotes(value);
                notes = value;
            }

        }
        public Category Category
        {
            get => _category;
            set
            {
                if (!this.User.Categories.Contains(value))
                    throw new InvalidItemCategoryException();
                this._category = value;
            }

        }


        private void ValidateNotes(string value)
        {
            if (value == null)
                return;
            if (!Validator.MaxLengthOfString(value, Item.MaxNoteLength))
                throw new NotesTooLongException();
        }
    }
}
