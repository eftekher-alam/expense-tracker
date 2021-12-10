using ExpenseTracker.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExpenseTracker.Models
{
    public class Category
    {
        public Category()
        {
            this.Expense = new List<Expense>();
        }
        public int CategoryId { get; set; }

        [Required, StringLength(50), DisplayName("Category Name")]
        public string CategoryName { get; set; }

        public virtual  ICollection<Expense> Expense { get; set; }
    }

    public class Expense
    {
        public int ExpenseId { get; set; }

        [Required, Column(TypeName = "date"), FutureDateValidation(ErrorMessage = "Future date not allowed")]
        public DateTime Date { get; set; }

        [Required, Column(TypeName = "money")]
        public int Ammount { get; set; }

        [Required, ForeignKey("Category")]
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}
