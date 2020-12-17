using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookListRazor.Web.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace BookListRazor.Web.Pages.BookList
{
    public class CreateModel : PageModel
    {
        private readonly DataContext _db;

        public CreateModel(DataContext db)
        {
            _db = db;
        }

        public Book Book { get; set; }

        public void OnGet()
        {

        }
    }
}