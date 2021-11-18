using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P2_1_1204020
{
    public class book_1204020 : Product_1204020
    {
        protected string pageCount;

        public book_1204020(string Mytype, string title, string pagecount) : base(Mytype, title)
        {
            this.pageCount = pagecount;
        }

        public string PageCount
        {
            get
            {
                return pageCount;
            }


            set
            {
                pageCount = value;
            }


        }

    }
}
