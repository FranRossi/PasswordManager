﻿using Obligatorio1_DA1.Exceptions;
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
        private string _notes;
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
        public Category Category
        {
            get => _category;
            set
            {
                if (!this.User.Categories.Contains(value))
                    throw new ItemInvalidCategoryException();
                _category = value;
            }

        }


        private void ValidateNotes(string value)
        {
            if (!Validator.MaxLengthOfString(value, Item.MaxNoteLength))
                throw new ItemNotesTooLongException();
        }
    }
}
