﻿using NS.DigitalMenuData.Entities;
using NS.DigitalMenuModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NS.DigitalMenuRepo
{
    public interface IMenuRepo
    {
        bool AddDish(MenuModel menuModel);

        List<Menu> ShowDishes();

        Menu GetDishById(int DishId);
        bool UpdateDish(MenuModel menuModel);

        //bool Delete(StudentModel studentModel, int Id);

        //List<StudentDeptModel> GetStudent();
    }
}
