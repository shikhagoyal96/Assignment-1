﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//Install  entity framework 6 on Tools > Manage Nuget Packages > Microsoft Entity Framework (ver 6.4)
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;


namespace PetGrooming.Models
{
    public class Owner
    {
        /*
            An owner is someone who owns one or more pets
            Some things that describe an owner:
                - First Name
                - Last Name
                - Address
                - Phone Number (work)
                - Phone Number (home)

            An owner must reference a list of pets
            
        */
        public int ownerId { get; set; }

        public string ownerFname { get; set; }

        public string ownerLname { get; set; }

        public string ownerAddress { get; set; }

        public int ownerPhoneWork { get; set; }

        public int ownerPhoneHome { get; set; }
    }
}