﻿using QLQuanAn.DTO;
using System.Collections.Generic;
using System.Data;

namespace QLQuanAn.DAO
{
    public class CategoryDAO
    {
        private static CategoryDAO instance;

        public static CategoryDAO Instance
        {
            get { if (instance == null) instance = new CategoryDAO(); return CategoryDAO.instance; }
            private set { CategoryDAO.instance = value; }
        }

        private CategoryDAO() { }

        public List<Category> GetListCategory()
        {
            List<Category> list = new List<Category>();

            string query = "SELECT * FROM FoodCategory";

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Category category = new Category(item);

                list.Add(category);
            }

            return list;
        }

        public Category GetCategoryByID(int id)
        {
            Category category = null;

            string query = "SELECT * FROM FoodCategory where id = " + id;

            DataTable data = DataProvider.Instance.ExcuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                category = new Category(item);

                return category;
            }

            return category;
        }

        public bool InsertCategory(string name)
        {
            string query = string.Format("INSERT dbo.FoodCategory (name) VALUES (N'{0}')", name);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateCategory(int idCategory, string nameCategory)
        {
            string query = string.Format("UPDATE dbo.FoodCategory SET name = N'{0}' WHERE id = {1}", nameCategory, idCategory);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteCategory(int idCategory)
        {
            FoodDAO.Instance.DeleteFoodByIDCategory(idCategory);

            string query = string.Format("DELETE FoodCategory WHERE id = {0}", idCategory);
            int result = DataProvider.Instance.ExcuteNonQuery(query);

            return result > 0;
        }

    }
}