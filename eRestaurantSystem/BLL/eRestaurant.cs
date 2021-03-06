﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using eRestaurantSystem.Entities;
using eRestaurantSystem.DAL;
using System.ComponentModel;
#endregion

namespace eRestaurantSystem.BLL
{
    [DataObject]
    public class eRestaurant
    {
        [DataObjectMethod(DataObjectMethodType.Select,false)]
        public List<SpecialEvent> SpecialEvent_List()
        {
            //interfacing with our Context class
            using(eRestaurantContext context= new eRestaurantContext())
            {
                return context.SpecialEvents.ToList();
            }
        }
    }
}
