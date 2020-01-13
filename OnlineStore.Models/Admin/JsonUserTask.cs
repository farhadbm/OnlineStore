﻿using OnlineStore.Providers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Models.Admin
{
    public class JsonUserTask
    {
        public int ID { get; set; }
        public DateTime UserTaskDate { get; set; }

        public string PersianUserTaskDate
        {
            get
            {
                if (UserTaskDate == new DateTime())
                    return "";

                return Utilities.ToPersianDate(UserTaskDate);
            }
            set
            {
                if (String.IsNullOrWhiteSpace(value))
                    UserTaskDate = DateTime.Now;

                UserTaskDate = Utilities.ToEnglishDate(value);
            }
        }
    }
}
