﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil
//     Les modifications apportées à ce fichier seront perdues si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Yakro_2018_uwp_light.Model
{
    public class User : EntityCore
    {
        public virtual int Id
        {
            get;
            set;
        }

        public virtual string UserName
        {
            get;
            set;
        }

        public virtual string Password
        {
            get;
            set;
        }

        public virtual string Email
        {
            get;
            set;
        }

        public virtual string Lattude
        {
            get;
            set;
        }

        public virtual string Longitude
        {
            get;
            set;
        }

        public virtual IEnumerable<Event> Event
        {
            get;
            set;
        }

    }
}

